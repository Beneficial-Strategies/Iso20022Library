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
[IsoId("_PZcUU9p-Ed-ak6NoX_4Aeg_-2099385393")]
[DisplayName("Name And Address")]
public partial record NameAndAddress3
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and is usually used to identify that identity.
    /// </summary>
    [IsoId("_PZcUVNp-Ed-ak6NoX_4Aeg_-2047670244")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_PZcUVdp-Ed-ak6NoX_4Aeg_-1111154172")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress1 Address { get; init; } 
    
    
    #nullable disable
    
}
