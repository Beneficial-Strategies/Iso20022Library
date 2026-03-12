// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information expressed in a proprietary manner.
/// </summary>
[IsoId("_P_luVdp-Ed-ak6NoX_4Aeg_811645724")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification7
{
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_P_luVtp-Ed-ak6NoX_4Aeg_858746211")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public required IsoMax8Text Issuer { get; init; } 
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_P_luV9p-Ed-ak6NoX_4Aeg_858746099")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Information { get; init; } 
    
    
    #nullable disable
    
}
