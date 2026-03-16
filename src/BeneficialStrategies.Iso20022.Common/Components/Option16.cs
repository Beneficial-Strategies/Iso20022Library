// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Option16.
/// </summary>
[IsoId("_e7Wn0e3_Ee6nAu63uIo75Q")]
[DisplayName("Option16")]
public partial record Option16
{
    #nullable enable

    /// <summary>
    /// Additional Option Information.
    /// </summary>
    [DisplayName("Additional Option Information")]
    [IsoXmlTag("AddtlOptnInf")]
    public required IsoMax140Text AdditionalOptionInformation { get; init; } 

    /// <summary>
    /// Data.
    /// </summary>
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required DataType1Code Data { get; init; } 

    /// <summary>
    /// Derivative Option Identification.
    /// </summary>
    [DisplayName("Derivative Option Identification")]
    [IsoXmlTag("DerivOptnId")]
    public required IsoMax35Text DerivativeOptionIdentification { get; init; } 

    /// <summary>
    /// Exercise Status.
    /// </summary>
    [DisplayName("Exercise Status")]
    [IsoXmlTag("ExrcSts")]
    public required DerivativeExerciseStatus1Code ExerciseStatus { get; init; } 

    /// <summary>
    /// Exercise Style.
    /// </summary>
    [DisplayName("Exercise Style")]
    [IsoXmlTag("ExrcStyle")]
    public required OptionStyle2Code ExerciseStyle { get; init; } 

    /// <summary>
    /// Expiry Date And Time.
    /// </summary>
    [DisplayName("Expiry Date And Time")]
    [IsoXmlTag("XpryDtAndTm")]
    public required IsoISODateTime ExpiryDateAndTime { get; init; } 

    /// <summary>
    /// Expiry Location.
    /// </summary>
    [DisplayName("Expiry Location")]
    [IsoXmlTag("XpryLctn")]
    public required IsoMax4AlphaNumericText ExpiryLocation { get; init; } 

    /// <summary>
    /// Option Amounts.
    /// </summary>
    [DisplayName("Option Amounts")]
    [IsoXmlTag("OptnAmts")]
    public required AmountsAndValueDate4 OptionAmounts { get; init; } 

    /// <summary>
    /// Option Payout Type.
    /// </summary>
    [DisplayName("Option Payout Type")]
    [IsoXmlTag("OptnPyoutTp")]
    public required OptionPayoutType1Code OptionPayoutType { get; init; } 

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required OptionType1Code OptionType { get; init; } 

    /// <summary>
    /// Premium.
    /// </summary>
    [DisplayName("Premium")]
    [IsoXmlTag("Prm")]
    public required PremiumAmount3 Premium { get; init; } 

    /// <summary>
    /// Risk Amount.
    /// </summary>
    [DisplayName("Risk Amount")]
    [IsoXmlTag("RskAmt")]
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 

    /// <summary>
    /// Settlement Amount Type.
    /// </summary>
    [DisplayName("Settlement Amount Type")]
    [IsoXmlTag("SttlmAmtTp")]
    public required SettlementType1Code SettlementAmountType { get; init; } 

    /// <summary>
    /// Settlement Type.
    /// </summary>
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public required SettlementDate8Code SettlementType { get; init; } 

    /// <summary>
    /// Strike Price.
    /// </summary>
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public required AgreedRate3 StrikePrice { get; init; } 

    /// <summary>
    /// Valuation Rate.
    /// </summary>
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate3 ValuationRate { get; init; } 

    /// <summary>
    /// Volatility Margin.
    /// </summary>
    [DisplayName("Volatility Margin")]
    [IsoXmlTag("VoltlyMrgn")]
    public required IsoPercentageRate VolatilityMargin { get; init; } 

    
    #nullable disable
    
}
