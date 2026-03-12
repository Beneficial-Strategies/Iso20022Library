// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_PbrI9dp-Ed-ak6NoX_4Aeg_290283595")]
[DisplayName("Name And Address")]
public partial record NameAndAddress9
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PbrI9tp-Ed-ak6NoX_4Aeg_290283597")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_PbrI99p-Ed-ak6NoX_4Aeg_291203604")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LongPostalAddress2Choice_? Address { get; init; } 
    
    
    #nullable disable
    
}
