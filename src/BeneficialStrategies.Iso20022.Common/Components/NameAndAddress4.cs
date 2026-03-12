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
[IsoId("_PbOdAtp-Ed-ak6NoX_4Aeg_674890865")]
[DisplayName("Name And Address")]
public partial record NameAndAddress4
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PbOdA9p-Ed-ak6NoX_4Aeg_674890882")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_PbOdBNp-Ed-ak6NoX_4Aeg_1771784210")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required PostalAddress1 Address { get; init; } 
    
    
    #nullable disable
    
}
