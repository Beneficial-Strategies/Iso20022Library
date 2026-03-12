// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on reconciliation per type of derivative.
/// </summary>
[IsoId("_530fYVfcEeqZr5K1Woax-g")]
[DisplayName("Reconciliation Statistics Per Derivative Type")]
public partial record ReconciliationStatisticsPerDerivativeType3
{
    #nullable enable
    
    /// <summary>
    /// Detailed statistics on reconciliation for all derivatives.
    /// </summary>
    [IsoId("_6PTLQVfcEeqZr5K1Woax-g")]
    [DisplayName("All Derivatives")]
    [IsoXmlTag("AllDerivs")]
    public required DetailedReconciliationStatistics2 AllDerivatives { get; init; } 
    
    /// <summary>
    /// Detailed statistics on reconciliation for outstanding derivatives.
    /// </summary>
    [IsoId("_6PTLQ1fcEeqZr5K1Woax-g")]
    [DisplayName("Outstanding Derivatives")]
    [IsoXmlTag("OutsdngDerivs")]
    public required DetailedReconciliationStatistics2 OutstandingDerivatives { get; init; } 
    
    
    #nullable disable
    
}
