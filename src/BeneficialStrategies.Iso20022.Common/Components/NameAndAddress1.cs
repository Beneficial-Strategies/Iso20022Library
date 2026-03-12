// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_VFxlA9p-Ed-ak6NoX_4Aeg_-1749124756")]
[DisplayName("Name And Address")]
public partial record NameAndAddress1
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_VFxlBNp-Ed-ak6NoX_4Aeg_-1749124755")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_VFxlBdp-Ed-ak6NoX_4Aeg_-1749124754")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required LongPostalAddress1Choice_ Address { get; init; } 
    
    
    #nullable disable
    
}
