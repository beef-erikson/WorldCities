using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCitiesAPI.Data.Models;

[Table("Countries")]
public class Country
{
    /***** PROPERTIES *****/
    
    /// <summary>
    /// The unique id and primary key of this country.
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// Country name (in UTF8 format)
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Country code (in ISO 3166-1 alpha-2 format)
    /// </summary>
    public string ISO2 { get; set; } = null!;

    /// <summary>
    /// Country code (in ISO 3166-1 alpha-3 format)
    /// </summary>
    public string ISO3 { get; set; } = null!;
    
    /********* NAVIGATION PROPERTIES *********/

    /// <summary>
    /// A collection of cities belonging to this country.
    /// </summary>
    public ICollection<City>? Cities { get; set; } = null!;
}