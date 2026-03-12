// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for the settlement fails as defined in the relevant regulation.
/// </summary>
[IsoId("_QHUzx76YEemHTLTzJg7M-A")]
[DisplayName("Settlement Failure Reason")]
public partial record SettlementFailureReason2
{
    #nullable enable
    
    /// <summary>
    /// Main reasons for settlement fails during the reporting period.
    /// </summary>
    [IsoId("_QMoKg76YEemHTLTzJg7M-A")]
    [DisplayName("Main Reasons")]
    [IsoXmlTag("MainRsns")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public required IsoMax2048Text MainReasons { get; init; } 
    
    /// <summary>
    /// Measures to improve settlement efficiency.
    /// </summary>
    [IsoId("_QMoKhb6YEemHTLTzJg7M-A")]
    [DisplayName("Efficiency Improvement")]
    [IsoXmlTag("EffcncyImprvmt")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public required IsoMax2048Text EfficiencyImprovement { get; init; } 
    
    
    #nullable disable
    
}
