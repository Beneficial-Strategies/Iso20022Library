// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on derivatives submitted for reconciliation per group of derivative contract.
/// </summary>
[IsoId("_5fxLwVfcEeqZr5K1Woax-g")]
[DisplayName("Reconciliation Statistics Per Derivative Contract Group")]
public partial record ReconciliationStatisticsPerDerivativeContractGroup3
{
    #nullable enable
    
    /// <summary>
    /// Detailed statistics on privately traded over-the-counter derivatives.
    /// </summary>
    [IsoId("_53z4UVfcEeqZr5K1Woax-g")]
    [DisplayName("OTC")]
    [IsoXmlTag("OTC")]
    public required ReconciliationStatisticsPerDerivativeType3 OTC { get; init; } 
    
    /// <summary>
    /// Detailed statistics on exchange-traded derivatives.
    /// </summary>
    [IsoId("_53z4U1fcEeqZr5K1Woax-g")]
    [DisplayName("ETD")]
    [IsoXmlTag("ETD")]
    public required ReconciliationStatisticsPerDerivativeType3 ETD { get; init; } 
    
    
    #nullable disable
    
}
