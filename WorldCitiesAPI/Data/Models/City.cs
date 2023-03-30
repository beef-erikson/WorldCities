using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCitiesAPI.Data.Models;

[Table("Cities")]
public class City
{
    /***** PROPERTIES *****/
    
    /// <summary>
    /// The unique id and primary key of this city.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }
    
    /// <summary>
    /// City name (in UTF8 format)
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// City Latitude
    /// </summary>
    [Column(TypeName = "decimal(7,4)")]
    public decimal Lat { get; set; }
    
    /// <summary>
    /// City Longitude
    /// </summary>
    [Column(TypeName = "decimal(7,4)")]
    public decimal Lon { get; set; }
    
    /// <summary>
    /// Country Id (foreign key)
    /// </summary>
    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    
    /********* NAVIGATION PROPERTIES *********/
    
    /// <summary>
    /// The country this city belongs to.
    /// </summary>
    public Country? Country { get; set; } = null!;
}