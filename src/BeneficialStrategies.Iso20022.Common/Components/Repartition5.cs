// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how the amount of the investment plan is split amongst the funds.
/// </summary>
[IsoId("_1RgcgU_eEeaB8-OWTiMVrQ")]
[DisplayName("Repartition")]
public partial record Repartition5
{
    #nullable enable
    
    /// <summary>
    /// Amount, units or percentage of financial instrument invested or withdrawn.
    /// </summary>
    [IsoId("_1p5uYU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required UnitsOrAmountOrPercentage1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Detailed information about the security or investment fund.
    /// </summary>
    [IsoId("_1p5uY0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrument56 FinancialInstrument { get; init; } 
    
    /// <summary>
    /// When a fund has multiple currencies within same ISIN, this indicates the currency of the savings or withdrawal plan.
    /// </summary>
    [IsoId("_1p5uZU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Currency Of Plan")]
    [IsoXmlTag("CcyOfPlan")]
    public ActiveOrHistoricCurrencyCode? CurrencyOfPlan { get; init; } 
    
    
    #nullable disable
    
}
