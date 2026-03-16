// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Equalisation4.
/// </summary>
[IsoId("_3yi-ERy9Ee6xZagVxBkKsg")]
[DisplayName("Equalisation4")]
public partial record Equalisation4
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 

    /// <summary>
    /// Contingent Liquidation Per Unit.
    /// </summary>
    [DisplayName("Contingent Liquidation Per Unit")]
    [IsoXmlTag("CntngntLqdtnPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? ContingentLiquidationPerUnit { get; init; } 

    /// <summary>
    /// Depreciation Deposit Per Unit.
    /// </summary>
    [DisplayName("Depreciation Deposit Per Unit")]
    [IsoXmlTag("DprctnDpstPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? DepreciationDepositPerUnit { get; init; } 

    /// <summary>
    /// Equalisation Credit Per Unit.
    /// </summary>
    [DisplayName("Equalisation Credit Per Unit")]
    [IsoXmlTag("EqulstnCdtPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? EqualisationCreditPerUnit { get; init; } 

    /// <summary>
    /// Equalisation Methodology Type.
    /// </summary>
    [DisplayName("Equalisation Methodology Type")]
    [IsoXmlTag("EqulstnMthdlgyTp")]
    public EqualisationMethodologyType1Code? EqualisationMethodologyType { get; init; } 

    /// <summary>
    /// Gross Asset Value.
    /// </summary>
    [DisplayName("Gross Asset Value")]
    [IsoXmlTag("GrssAsstVal")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAssetValue { get; init; } 

    /// <summary>
    /// High Watermark.
    /// </summary>
    [DisplayName("High Watermark")]
    [IsoXmlTag("HghWtrmrk")]
    public ActiveOrHistoricCurrencyAndAmount? HighWatermark { get; init; } 

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; } 

    
    #nullable disable
    
}
