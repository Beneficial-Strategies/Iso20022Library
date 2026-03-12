// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a person via its first name and surname.
/// </summary>
[IsoId("_FhKN1bqcEemCAOifqHrKJw")]
[DisplayName("Person Name")]
public partial record PersonName3
{
    #nullable enable
    
    /// <summary>
    /// Prefix, as a title before a person&apos;s name.
    /// </summary>
    [IsoId("_LmDvgbqcEemCAOifqHrKJw")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    [IsoId("_FhKN2LqcEemCAOifqHrKJw")]
    [DisplayName("First Name")]
    [IsoXmlTag("FrstNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text FirstName { get; init; } 
    
    /// <summary>
    /// Name (s) by which a natural person is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_FhKN2bqcEemCAOifqHrKJw")]
    [DisplayName("Surname")]
    [IsoXmlTag("Srnm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Surname { get; init; } 
    
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_FhKN17qcEemCAOifqHrKJw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public PostalAddress26? Address { get; init; } 
    
    
    #nullable disable
    
}
