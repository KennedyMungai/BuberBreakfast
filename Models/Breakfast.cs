using System;
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
}