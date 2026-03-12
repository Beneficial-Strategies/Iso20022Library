// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the foreign exchange trade including Spot\Forward\NDF that is captured.
/// </summary>
[IsoId("_IWV_wA2MEeSw7Op2IIeBeQ")]
[DisplayName("Trade")]
public partial record Trade3
{
    #nullable enable
    
    /// <summary>
    /// Price of the execution of the trade.
    /// </summary>
    [IsoId("_aPM3sQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Execution Price")]
    [IsoXmlTag("ExctnPric")]
    public required ActiveCurrencyAnd13DecimalAmount ExecutionPrice { get; init; } 
    
    /// <summary>
    /// Amount of trade in trading currency.
    /// </summary>
    [IsoId("_ZP3hoQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Last Quantity")]
    [IsoXmlTag("LastQty")]
    public required CurrencyAndAmount LastQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the settlment period of the foreign exchange trade.
    /// </summary>
    [IsoId("_5e0S4IaBEeSspsEopx56mg")]
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public required SettlementDateCode SettlementType { get; init; } 
    
    /// <summary>
    /// Specifies the date on which the trade will be settled.
    /// </summary>
    [IsoId("_zqtBsQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; } 
    
    /// <summary>
    /// Specifies the valuation rate used for the trade.
    /// </summary>
    [IsoId("_doQmQYaCEeSspsEopx56mg")]
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate3 ValuationRate { get; init; } 
    
    /// <summary>
    /// Specifies the forward points of the trade if needed.
    /// </summary>
    [IsoId("_N8HR8YaMEeSzIqahkBT6cQ")]
    [DisplayName("Forward Points")]
    [IsoXmlTag("FwdPts")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ForwardPoints { get; init; } 
    
    /// <summary>
    /// Amount of trade in corresponding currency.
    /// </summary>
    [IsoId("_WyqfYQ2MEeSw7Op2IIeBeQ")]
    [DisplayName("Calculated Counterparty Currency Last Quantity")]
    [IsoXmlTag("ClctdCtrPtyCcyLastQty")]
    public required CurrencyAndAmount CalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the value date of spot transaction.
    /// </summary>
    [IsoId("_zV_V9A2MEeSw7Op2IIeBeQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Measurement of the amount of the trade values converted in the US dollars.
    /// </summary>
    [IsoId("_sqMCcIaEEeSzIqahkBT6cQ")]
    [DisplayName("Risk Amount")]
    [IsoXmlTag("RskAmt")]
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 
    
    /// <summary>
    /// Security identification of the trade.
    /// </summary>
    [IsoId("_U5Fn8IaIEeSzIqahkBT6cQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification18 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the ISO code of the fixing currency.
    /// </summary>
    [IsoId("_4irkELMeEeSOJaFmPosvyg")]
    [DisplayName("Fixing Currency")]
    [IsoXmlTag("FxgCcy")]
    public CurrencyCode? FixingCurrency { get; init; } 
    
    /// <summary>
    /// Date at which the rate determination is made in the NDF trade.
    /// </summary>
    [IsoId("_YuYQwESYEeS6cOLECtYLrA")]
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FixingDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the spot trade is produced by the option.
    /// </summary>
    [IsoId("_r_EfUESNEeS6cOLECtYLrA")]
    [DisplayName("Option Indicator")]
    [IsoXmlTag("OptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OptionIndicator { get; init; } 
    
    /// <summary>
    /// Indicate the trade whether it&apos;s exchange delta.
    /// </summary>
    [IsoId("_o6Tt0ESNEeS6cOLECtYLrA")]
    [DisplayName("Delta Indicator")]
    [IsoXmlTag("DltaInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DeltaIndicator { get; init; } 
    
    /// <summary>
    /// Some associated trade reference needs to be specified.
    /// </summary>
    [IsoId("_CP330YaNEeSzIqahkBT6cQ")]
    [DisplayName("Associated Trade Reference")]
    [IsoXmlTag("AssoctdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AssociatedTradeReference { get; init; } 
    
    
    #nullable disable
    
}
