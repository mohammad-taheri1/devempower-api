using AutoMapper;
using DevEmpowerApiV6.Core.DTO.Tickets;
using DevEmpowerApiV6.Core.Entities;

namespace DevEmpowerApiV6.Core.AutoMapper;

public class AutoMapperConfigProfile : Profile
{
    public AutoMapperConfigProfile()
    {
        // Tickets
        CreateMap<CreateTicketDto, Ticket>();
        CreateMap<Ticket, GetTicketDto>();
        CreateMap<UpdateTicketDto, Ticket>();
    }
}
