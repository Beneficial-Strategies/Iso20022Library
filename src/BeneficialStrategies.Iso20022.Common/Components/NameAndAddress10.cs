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
[IsoId("_Pa7iEdp-Ed-ak6NoX_4Aeg_1232530799")]
[DisplayName("Name And Address")]
public partial record NameAndAddress10
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and is usually used to identify that party.
    /// </summary>
    [IsoId("_Pa7iEtp-Ed-ak6NoX_4Aeg_1232531078")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_Pa7iE9p-Ed-ak6NoX_4Aeg_1232531138")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress6 Address { get; init; } 
    
    
    #nullable disable
    
}
