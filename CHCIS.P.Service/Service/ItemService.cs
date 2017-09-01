using System;
using System.ServiceModel;
using Xx.His.Service;
using CHCIS.P.Contract.Service;
using CHCIS.P.Contract.Message;
using CHCIS.P.Domain;

namespace CHCIS.P.Service
{
    [GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ItemService : AbstractService<BsItem, ItemDto>, IItemService
    {
        [Obsolete]
        protected override void Configure()
        {
            CreateMap<BsItem, ItemDto>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID));
        }

        public override ItemDto Create(ItemDto itemDTO)
        {
            itemDTO.Validate();

            var entity = itemDTO.MapTo<BsItem>();
            
            entity = SetDefaultValue(entity);

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Create<BsItem>(entity);
                });

                return entity.MapTo<ItemDto>();
            }
        }

        public override void Update(ItemDto itemDTO)
        {
            itemDTO.Validate();

            var entity = itemDTO.MapTo<BsItem>();
            
            entity = SetDefaultValue(entity);

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {                 
                    uow.Update<BsItem>(entity);
                });
            }
        }

        private BsItem SetDefaultValue(BsItem item)
        {
            item.UnitInId = item.UnitDiagId;
            
            //TODO: 社区治疗费
            item.FeeZyId = 348; 
            item.OptionPrice = false;
            item.LimitTotalMz = 0;
            item.LimitTotalZy = 0;
            item.IsSpecSum = false;
            item.IsNew = false;
            item.IsChildAdd = false;
            item.IsBedFee = false;
            item.IsOpsAdd = false;
            item.LsfeeTurn = 0;
            item.LsAdviceType = 0;
            item.IconIndex = 0;
            item.IsCitySum = false;

            return item;
        }
    }
}
