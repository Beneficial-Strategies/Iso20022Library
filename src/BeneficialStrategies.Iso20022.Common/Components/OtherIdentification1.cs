// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other accepted financial instrument&apos;s identification than ISIN.
/// </summary>
[IsoId("_UokEk9p-Ed-ak6NoX_4Aeg_462750527")]
[DisplayName("Other Identification")]
public partial record OtherIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_UokElNp-Ed-ak6NoX_4Aeg_-843603921")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Identifies the suffix of the security identification.
    /// </summary>
    [IsoId("_UokEldp-Ed-ak6NoX_4Aeg_-130667248")]
    [DisplayName("Suffix")]
    [IsoXmlTag("Sfx")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? Suffix { get; init; } 
    
    /// <summary>
    /// Type of the identification.
    /// </summary>
    [IsoId("_UokEltp-Ed-ak6NoX_4Aeg_1403030983")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IdentificationSource3Choice_ Type { get; init; } 
    
    
    #nullable disable
    
}
