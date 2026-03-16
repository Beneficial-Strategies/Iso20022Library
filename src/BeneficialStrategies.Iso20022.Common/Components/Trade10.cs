// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade10.
/// </summary>
[IsoId("_jXw8Ae3vEe6nAu63uIo75Q")]
[DisplayName("Trade10")]
public partial record Trade10
{
    #nullable enable

    /// <summary>
    /// Associated Trade Reference.
    /// </summary>
    [DisplayName("Associated Trade Reference")]
    [IsoXmlTag("AssoctdTradRef")]
    public ValueList<IsoMax70Text> AssociatedTradeReference { get; init; } = [];

    /// <summary>
    /// Calculated Counterparty Currency Last Quantity.
    /// </summary>
    [DisplayName("Calculated Counterparty Currency Last Quantity")]
    [IsoXmlTag("ClctdCtrPtyCcyLastQty")]
    public required ActiveCurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; init; } 

    /// <summary>
    /// Delta Indicator.
    /// </summary>
    [DisplayName("Delta Indicator")]
    [IsoXmlTag("DltaInd")]
    public IsoTrueFalseIndicator? DeltaIndicator { get; init; } 

    /// <summary>
    /// Execution Price.
    /// </summary>
    [DisplayName("Execution Price")]
    [IsoXmlTag("ExctnPric")]
    public required ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; init; } 

    /// <summary>
    /// Fixing Currency.
    /// </summary>
    [DisplayName("Fixing Currency")]
    [IsoXmlTag("FxgCcy")]
    public ActiveCurrencyCode? FixingCurrency { get; init; } 

    /// <summary>
    /// Fixing Date.
    /// </summary>
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    public IsoISODate? FixingDate { get; init; } 

    /// <summary>
    /// Forward Points.
    /// </summary>
    [DisplayName("Forward Points")]
    [IsoXmlTag("FwdPts")]
    public IsoDecimalNumber? ForwardPoints { get; init; } 

    /// <summary>
    /// Last Quantity.
    /// </summary>
    [DisplayName("Last Quantity")]
    [IsoXmlTag("LastQty")]
    public required ActiveCurrencyAndAmount LastQuantity { get; init; } 

    /// <summary>
    /// Option Indicator.
    /// </summary>
    [DisplayName("Option Indicator")]
    [IsoXmlTag("OptnInd")]
    public IsoTrueFalseIndicator? OptionIndicator { get; init; } 

    /// <summary>
    /// Risk Amount.
    /// </summary>
    [DisplayName("Risk Amount")]
    [IsoXmlTag("RskAmt")]
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 

    /// <summary>
    /// Security Identification.
    /// </summary>
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification18 SecurityIdentification { get; init; } 

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required IsoISODate SettlementDate { get; init; } 

    /// <summary>
    /// Settlement Type.
    /// </summary>
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public required SettlementDate8Code SettlementType { get; init; } 

    /// <summary>
    /// Valuation Rate.
    /// </summary>
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate3 ValuationRate { get; init; } 

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required IsoISODate ValueDate { get; init; } 

    
    #nullable disable
    
}
