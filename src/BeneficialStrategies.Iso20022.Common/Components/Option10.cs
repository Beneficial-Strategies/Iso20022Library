// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of elements which provide the parameters of an option trade.
/// </summary>
[IsoId("_XCwBUQ8iEeSFHsNYty4C9Q")]
[DisplayName("Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Option10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Option10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Option10( DataType1Code reqData,DerivativeExerciseStatus1Code reqExerciseStatus,OptionStyle2Code reqExerciseStyle,OptionType1Code reqOptionType,System.String reqDerivativeOptionIdentification,OptionPayoutType1Code reqOptionPayoutType,AgreedRate3 reqValuationRate,AgreedRate3 reqStrikePrice,System.Decimal reqVolatilityMargin,ActiveCurrencyAndAmount reqRiskAmount,System.DateTime reqExpiryDateAndTime,System.String reqExpiryLocation,SettlementDateCode reqSettlementType,AmountsAndValueDate4 reqOptionAmounts,PremiumAmount3 reqPremium,SettlementType1Code reqSettlementAmountType,System.String reqAdditionalOptionInformation )
    {
        Data = reqData;
        ExerciseStatus = reqExerciseStatus;
        ExerciseStyle = reqExerciseStyle;
        OptionType = reqOptionType;
        DerivativeOptionIdentification = reqDerivativeOptionIdentification;
        OptionPayoutType = reqOptionPayoutType;
        ValuationRate = reqValuationRate;
        StrikePrice = reqStrikePrice;
        VolatilityMargin = reqVolatilityMargin;
        RiskAmount = reqRiskAmount;
        ExpiryDateAndTime = reqExpiryDateAndTime;
        ExpiryLocation = reqExpiryLocation;
        SettlementType = reqSettlementType;
        OptionAmounts = reqOptionAmounts;
        Premium = reqPremium;
        SettlementAmountType = reqSettlementAmountType;
        AdditionalOptionInformation = reqAdditionalOptionInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of data to indicate whether a trade is an option or resulted by an option exercise.
    /// </summary>
    [IsoId("_wjtYoEeBEeSzluxs8tdrVw")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataType1Code Data { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataType1Code Data { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataType1Code Data { get; init; } 
    #else
    public DataType1Code Data { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the exercise status of the option.
    /// </summary>
    [IsoId("_RGnuACKSEeSFts-9wCD3iw")]
    [DisplayName("Exercise Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcSts")]
    #endif
    [IsoXmlTag("ExrcSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeExerciseStatus1Code ExerciseStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeExerciseStatus1Code ExerciseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeExerciseStatus1Code ExerciseStatus { get; init; } 
    #else
    public DerivativeExerciseStatus1Code ExerciseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how an option can be exercised.
    /// </summary>
    [IsoId("_XdRaKQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Exercise Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExrcStyle")]
    #endif
    [IsoXmlTag("ExrcStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionStyle2Code ExerciseStyle { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionStyle2Code ExerciseStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle2Code ExerciseStyle { get; init; } 
    #else
    public OptionStyle2Code ExerciseStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of format for option type.
    /// </summary>
    [IsoId("_7uMrYEUhEeSGWeX3z5zSZQ")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionType1Code OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionType1Code OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType1Code OptionType { get; init; } 
    #else
    public OptionType1Code OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the derivative option.
    /// </summary>
    [IsoId("_lmNm8KbREeSnSIf9q_Ahng")]
    [DisplayName("Derivative Option Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivOptnId")]
    #endif
    [IsoXmlTag("DerivOptnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DerivativeOptionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DerivativeOptionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DerivativeOptionIdentification { get; init; } 
    #else
    public System.String DerivativeOptionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of payout that will result from an in-the-money option.
    /// </summary>
    [IsoId("_LQBMwKbFEeSxuMLA5o46jQ")]
    [DisplayName("Option Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPyoutTp")]
    #endif
    [IsoXmlTag("OptnPyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionPayoutType1Code OptionPayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionPayoutType1Code OptionPayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionPayoutType1Code OptionPayoutType { get; init; } 
    #else
    public OptionPayoutType1Code OptionPayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation rate used for the trade.
    /// </summary>
    [IsoId("_atfU4IabEeS6OMe6QA9z_g")]
    [DisplayName("Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRate")]
    #endif
    [IsoXmlTag("ValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate3 ValuationRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate3 ValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3 ValuationRate { get; init; } 
    #else
    public AgreedRate3 ValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rate of exchange at which the foreign exchange option has been struck.
    /// </summary>
    [IsoId("_XdRaJw8iEeSFHsNYty4C9Q")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate3 StrikePrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate3 StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3 StrikePrice { get; init; } 
    #else
    public AgreedRate3 StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Annualized volatility for option model calculations.
    /// </summary>
    [IsoId("_cp_Z0A8mEeSFHsNYty4C9Q")]
    [DisplayName("Volatility Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoltlyMrgn")]
    #endif
    [IsoXmlTag("VoltlyMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate VolatilityMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal VolatilityMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal VolatilityMargin { get; init; } 
    #else
    public System.Decimal VolatilityMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Measurement of the amount of the trade values converted in the US dollars.
    /// </summary>
    [IsoId("_OITiUIclEeSSpbtwQkzChA")]
    [DisplayName("Risk Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskAmt")]
    #endif
    [IsoXmlTag("RskAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RiskAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RiskAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a privilege (for example, option, right, warrant.) expires. If it is an European option, the option holder can only exercise the right or let it lapse on expiry date. If it is an American option, the option holder can exercise the right up to the expiry date.
    /// </summary>
    [IsoId("_XdRaLQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Expiry Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtAndTm")]
    #endif
    [IsoXmlTag("XpryDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ExpiryDateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ExpiryDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ExpiryDateAndTime { get; init; } 
    #else
    public System.DateTime ExpiryDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Financial center where option expires.
    /// </summary>
    [IsoId("_XdRaLw8iEeSFHsNYty4C9Q")]
    [DisplayName("Expiry Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryLctn")]
    #endif
    [IsoXmlTag("XpryLctn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ExpiryLocation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExpiryLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExpiryLocation { get; init; } 
    #else
    public System.String ExpiryLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlment period of the option trade.
    /// </summary>
    [IsoId("_2-7xQIabEeS6OMe6QA9z_g")]
    [DisplayName("Settlement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTp")]
    #endif
    [IsoXmlTag("SttlmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDateCode SettlementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDateCode SettlementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDateCode SettlementType { get; init; } 
    #else
    public SettlementDateCode SettlementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the call and the put amount of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_XdRaJQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Option Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAmts")]
    #endif
    [IsoXmlTag("OptnAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate4 OptionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountsAndValueDate4 OptionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate4 OptionAmounts { get; init; } 
    #else
    public AmountsAndValueDate4 OptionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of the premium of a foreign exchange option trade and its settlement place.
    /// </summary>
    [IsoId("_XdRaNQ8iEeSFHsNYty4C9Q")]
    [DisplayName("Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prm")]
    #endif
    [IsoXmlTag("Prm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PremiumAmount3 Premium { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PremiumAmount3 Premium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PremiumAmount3 Premium { get; init; } 
    #else
    public PremiumAmount3 Premium { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_HLBdkEefEeSC05fFWs3C4A")]
    [DisplayName("Settlement Amount Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmtTp")]
    #endif
    [IsoXmlTag("SttlmAmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementType1Code SettlementAmountType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementType1Code SettlementAmountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementType1Code SettlementAmountType { get; init; } 
    #else
    public SettlementType1Code SettlementAmountType { get; set; } 
    #endif
    
    /// <summary>
    /// Free format text that may contain information on the option.
    /// </summary>
    [IsoId("_XdRaMw8iEeSFHsNYty4C9Q")]
    [DisplayName("Additional Option Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlOptnInf")]
    #endif
    [IsoXmlTag("AddtlOptnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text AdditionalOptionInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AdditionalOptionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AdditionalOptionInformation { get; init; } 
    #else
    public System.String AdditionalOptionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
