using System.Collections.Generic;

public class ParkingLot
{
    public List<ParkingSpace> Spaces { get; private set; }

    public List<ParkingTicket> ActiveTickets { get; private set; }

    private ParkingFeeCalculator calculator;

    public ParkingLot(int numberOfSpaces, ParkingFeeCalculator feeCalculator)
    {
        calculator = feeCalculator;

        Spaces = new List<ParkingSpace>();
        ActiveTickets = new List<ParkingTicket>();

        for (int i = 1; i <= numberOfSpaces; i++)
        {
            Spaces.Add(new ParkingSpace(i));
        }
    }

    public ParkingTicket ParkVehicle(Vehicle vehicle)
    {
        foreach (ParkingTicket ticket in ActiveTickets)
        {
            if (ticket.Vehicle.PlateNumber == vehicle.PlateNumber)
            {
                return null;
            }
        }

        foreach (ParkingSpace space in Spaces)
        {
            if (!space.IsOccupied)
            {
                space.Occupy(vehicle);

                ParkingTicket ticket =
                    new ParkingTicket(vehicle, space);

                ActiveTickets.Add(ticket);

                return ticket;
            }
        }

        return null;
    }
}