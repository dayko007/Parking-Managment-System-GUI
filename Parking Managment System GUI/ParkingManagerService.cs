using System;
using System.Linq;
using System.Collections.Generic;

public class ParkingManagerService
{
    private ParkingLot parkingLot;
    private ParkingFeeCalculator feeCalculator;

    public decimal TotalRevenue { get; private set; }

    public ParkingManagerService()
    {
        feeCalculator = new ParkingFeeCalculator(3.00m);

        parkingLot = new ParkingLot(12, feeCalculator);
    }

    public List<ParkingSpace> GetSpaces()
    {
        return parkingLot.Spaces;
    }

    public int GetAvailableSpaces()
    {
        return parkingLot.Spaces.Count(
            space => !space.IsOccupied);
    }

    public int GetOccupiedSpaces()
    {
        return parkingLot.Spaces.Count(
            space => space.IsOccupied);
    }

    public ParkingTicket ParkVehicle(string plate, string type)
    {
        if (string.IsNullOrWhiteSpace(plate))
        {
            throw new Exception("Enter plate number.");
        }

        if (string.IsNullOrWhiteSpace(type))
        {
            throw new Exception("Select vehicle type.");
        }

        Vehicle vehicle = new Vehicle(plate, type);

        ParkingTicket ticket = parkingLot.ParkVehicle(vehicle);

        if (ticket == null)
        {
            throw new Exception(
                "Vehicle already parked or parking lot is full.");
        }

        return ticket;
    }

    public ParkingTicket FindVehicle(string plate)
    {
        return parkingLot.ActiveTickets.FirstOrDefault(
            t => t.Vehicle.PlateNumber.Equals(
                plate,
                StringComparison.OrdinalIgnoreCase));
    }

    public decimal CalculateFee(ParkingTicket ticket)
    {
        return feeCalculator.CalculateFee(
            ticket.CalculateDuration());
    }

    public decimal ReleaseVehicle(string plate)
    {
        ParkingTicket ticket = FindVehicle(plate);

        if (ticket == null)
        {
            throw new Exception("Vehicle not found.");
        }

        decimal fee = CalculateFee(ticket);

        ticket.CloseTicket();

        ticket.Space.Release();

        parkingLot.ActiveTickets.Remove(ticket);

        TotalRevenue += fee;

        return fee;
    }
}