﻿namespace DevEmpowerApiV6.Core.DTO.Tickets;

public class CreateTicketDto
{
    public DateTime Time { get; set; }
    public string PassengerName { get; set; }
    public long PassengerSSN { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public int Price { get; set; }
}
