// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Factors used in the calculation of the pay in schedule.
/// </summary>
[IsoId("_S3PXsAEcEeCQm6a_G2yO_w_-1038379529")]
[DisplayName("Pay In Factors")]
public partial record PayInFactors1
{
    #nullable enable
    
    /// <summary>
    /// Maximum allowed sum of short positions in all currencies, converted to base currency, during settlement.
    /// </summary>
    [IsoId("_S3PXsQEcEeCQm6a_G2yO_w_-1671491994")]
    [DisplayName("Aggregate Short Position Limit")]
    [IsoXmlTag("AggtShrtPosLmt")]
    public required ActiveCurrencyAndAmount AggregateShortPositionLimit { get; init; } 
    
    /// <summary>
    /// Currency specific pay-in factors.
    /// </summary>
    [IsoId("_S3PXsgEcEeCQm6a_G2yO_w_1288597221")]
    [DisplayName("Currency Factors")]
    [IsoXmlTag("CcyFctrs")]
    public ValueList<CurrencyFactors1> CurrencyFactors { get; init; } = [];
    // ID for the above is _S3PXsgEcEeCQm6a_G2yO_w_1288597221
    
    
    #nullable disable
    
}
