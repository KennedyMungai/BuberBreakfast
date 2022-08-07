using System;
using ErrorOr;

namespace BuberBreakfast.Models;

public class Breakfast
{
    public Guid Id { get;}
    public string? Name { get;}
    public string? Description { get;}
    public DateTime StartDateTime { get;}
    public DateTime EndDateTime { get;}
    public DateTime LastModifiedDateTime { get;}
    public List<string> Savoury { get;}
    public List<string> Sweet { get;}

    public Breakfast(
        Guid id, 
        string name, 
        string description, 
        DateTime startDateTime, 
        DateTime endDateTime, 
        DateTime lastModifiedDateTime, 
        List<string> savoury, 
        List<string> sweet)
    {
        // Enforce the invariants
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savoury = savoury;
        Sweet = sweet;
    }

    public static ErrorOr<Breakfast> Create()
    {
        
    }
}