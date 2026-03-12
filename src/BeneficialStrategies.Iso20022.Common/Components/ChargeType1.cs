// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the charge type.
/// </summary>
[IsoId("_VPKKidp-Ed-ak6NoX_4Aeg_-1856414852")]
[DisplayName("Charge Type")]
public partial record ChargeType1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VPKKitp-Ed-ak6NoX_4Aeg_-1531335263")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required ChargeType6Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    [IsoId("_VPKKi9p-Ed-ak6NoX_4Aeg_-1531335262")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
