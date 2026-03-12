// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the commission type.
/// </summary>
[IsoId("_VPm2fNp-Ed-ak6NoX_4Aeg_-1440307664")]
[DisplayName("Commission Type")]
public partial record CommissionType1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VPwncNp-Ed-ak6NoX_4Aeg_-1169716015")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required CommissionType5Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of commission.
    /// </summary>
    [IsoId("_VPwncdp-Ed-ak6NoX_4Aeg_-1169716014")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
