using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleEric.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Years { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = [];
}

public class Address
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Client))]
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
    public string Country { get; set; }
    public string StateOrProvince { get; set; }
    public string Address1 { get; set; }
    public string City { get; set; }
}
