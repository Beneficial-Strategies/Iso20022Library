// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of elements which provide the parameters of an option trade.
/// </summary>
[IsoId("_XCwBUQ8iEeSFHsNYty4C9Q")]
[DisplayName("Option")]
public record Option10
{
    /// <summary>
    /// Type of data to indicate whether a trade is an option or resulted by an option exercise.
    /// </summary>
    [IsoId("_wjtYoEeBEeSzluxs8tdrVw")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required DataType1Code Data { get; init; }

    /// <summary>
    /// Specifies the exercise status of the option.
    /// </summary>
    [IsoId("_RGnuACKSEeSFts-9wCD3iw")]
    [DisplayName("Exercise Status")]
    [IsoXmlTag("ExrcSts")]
    public required DerivativeExerciseStatus1Code ExerciseStatus { get; init; }

    /// <summary>
    /// Defines how an option can be exercised.
    /// </summary>
    [IsoId("_XdRaKQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Exercise Style")]
    [IsoXmlTag("ExrcStyle")]
    public required OptionStyle2Code ExerciseStyle { get; init; }

    /// <summary>
    /// Choice of format for option type.
    /// </summary>
    [IsoId("_7uMrYEUhEeSGWeX3z5zSZQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required OptionType1Code OptionType { get; init; }

    /// <summary>
    /// Identifies the derivative option.
    /// </summary>
    [IsoId("_lmNm8KbREeSnSIf9q_Ahng")]
    [DisplayName("Derivative Option Identification")]
    [IsoXmlTag("DerivOptnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DerivativeOptionIdentification { get; init; }

    /// <summary>
    /// Indicates the type of payout that will result from an in-the-money option.
    /// </summary>
    [IsoId("_LQBMwKbFEeSxuMLA5o46jQ")]
    [DisplayName("Option Payout Type")]
    [IsoXmlTag("OptnPyoutTp")]
    public required OptionPayoutType1Code OptionPayoutType { get; init; }

    /// <summary>
    /// Specifies the valuation rate used for the trade.
    /// </summary>
    [IsoId("_atfU4IabEeS6OMe6QA9z_g")]
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate3 ValuationRate { get; init; }

    /// <summary>
    /// Specifies the rate of exchange at which the foreign exchange option has been struck.
    /// </summary>
    [IsoId("_XdRaJw8iEeSFHsNYty4C9Q")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public required AgreedRate3 StrikePrice { get; init; }

    /// <summary>
    /// Annualized volatility for option model calculations.
    /// </summary>
    [IsoId("_cp_Z0A8mEeSFHsNYty4C9Q")]
    [DisplayName("Volatility Margin")]
    [IsoXmlTag("VoltlyMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate VolatilityMargin { get; init; }

    /// <summary>
    /// Measurement of the amount of the trade values converted in the US dollars.
    /// </summary>
    [IsoId("_OITiUIclEeSSpbtwQkzChA")]
    [DisplayName("Risk Amount")]
    [IsoXmlTag("RskAmt")]
    public required ActiveCurrencyAndAmount RiskAmount { get; init; }

    /// <summary>
    /// Date on which a privilege (for example, option, right, warrant.) expires. If it is an European option, the option holder can only exercise the right or let it lapse on expiry date. If it is an American option, the option holder can exercise the right up to the expiry date.
    /// </summary>
    [IsoId("_XdRaLQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Expiry Date And Time")]
    [IsoXmlTag("XpryDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExpiryDateAndTime { get; init; }

    /// <summary>
    /// Financial center where option expires.
    /// </summary>
    [IsoId("_XdRaLw8iEeSFHsNYty4C9Q")]
    [DisplayName("Expiry Location")]
    [IsoXmlTag("XpryLctn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ExpiryLocation { get; init; }

    /// <summary>
    /// Specifies the settlment period of the option trade.
    /// </summary>
    [IsoId("_2-7xQIabEeS6OMe6QA9z_g")]
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public required SettlementDateCode SettlementType { get; init; }

    /// <summary>
    /// Specifies the call and the put amount of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_XdRaJQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Option Amounts")]
    [IsoXmlTag("OptnAmts")]
    public required AmountsAndValueDate4 OptionAmounts { get; init; }

    /// <summary>
    /// Specifies the amount of the premium of a foreign exchange option trade and its settlement place.
    /// </summary>
    [IsoId("_XdRaNQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Premium")]
    [IsoXmlTag("Prm")]
    public required PremiumAmount3 Premium { get; init; }

    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_HLBdkEefEeSC05fFWs3C4A")]
    [DisplayName("Settlement Amount Type")]
    [IsoXmlTag("SttlmAmtTp")]
    public required SettlementType1Code SettlementAmountType { get; init; }

    /// <summary>
    /// Free format text that may contain information on the option.
    /// </summary>
    [IsoId("_XdRaMw8iEeSFHsNYty4C9Q")]
    [DisplayName("Additional Option Information")]
    [IsoXmlTag("AddtlOptnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text AdditionalOptionInformation { get; init; }
}
