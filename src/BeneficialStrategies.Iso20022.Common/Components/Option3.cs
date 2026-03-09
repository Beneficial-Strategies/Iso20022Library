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
[IsoId("_TLSOQNp-Ed-ak6NoX_4Aeg_-1226899977")]
[DisplayName("Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Option3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Option3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Option3( AmountsAndValueDate2 reqOptionAmounts,AgreedRate1 reqStrikePrice,OptionStyle2Code reqExerciseStyle,System.DateTime reqExpiryDateAndTime,System.String reqExpiryLocation,SettlementType1Code reqSettlementType,PremiumAmount2 reqPremium )
    {
        OptionAmounts = reqOptionAmounts;
        StrikePrice = reqStrikePrice;
        ExerciseStyle = reqExerciseStyle;
        ExpiryDateAndTime = reqExpiryDateAndTime;
        ExpiryLocation = reqExpiryLocation;
        SettlementType = reqSettlementType;
        Premium = reqPremium;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the call and the put amount of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_TLSOQdp-Ed-ak6NoX_4Aeg_-1226899590")]
    [DisplayName("Option Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAmts")]
    #endif
    [IsoXmlTag("OptnAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate2 OptionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountsAndValueDate2 OptionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate2 OptionAmounts { get; init; } 
    #else
    public AmountsAndValueDate2 OptionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rate of exchange at which the foreign exchange option has been struck.
    /// </summary>
    [IsoId("_TLSOQtp-Ed-ak6NoX_4Aeg_-1226899555")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate1 StrikePrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate1 StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1 StrikePrice { get; init; } 
    #else
    public AgreedRate1 StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how an option can be exercised.
    /// </summary>
    [IsoId("_TLSOQ9p-Ed-ak6NoX_4Aeg_-1226899975")]
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
    /// First date on which an american option can be exercised.
    /// </summary>
    [IsoId("_TLSORNp-Ed-ak6NoX_4Aeg_-1226899694")]
    [DisplayName("Earliest Exercise Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstExrcDt")]
    #endif
    [IsoXmlTag("EarlstExrcDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EarliestExerciseDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EarliestExerciseDate { get; init; } 
    #else
    public System.DateOnly? EarliestExerciseDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a privilege (eg, option, right, warrant.) expires. If it is an European option, the option holder can only exercise the right or let it lapse on expiry date. If it is an American option, the option holder can exercise the right up to the expiry date.
    /// </summary>
    [IsoId("_TLSORdp-Ed-ak6NoX_4Aeg_-1226899676")]
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
    [IsoId("_TLSORtp-Ed-ak6NoX_4Aeg_-1226899651")]
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
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_TLSOR9p-Ed-ak6NoX_4Aeg_-1226899634")]
    [DisplayName("Settlement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTp")]
    #endif
    [IsoXmlTag("SttlmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementType1Code SettlementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementType1Code SettlementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementType1Code SettlementType { get; init; } 
    #else
    public SettlementType1Code SettlementType { get; set; } 
    #endif
    
    /// <summary>
    /// Free format text that may contain information on the option.
    /// </summary>
    [IsoId("_TLSOSNp-Ed-ak6NoX_4Aeg_-1226899616")]
    [DisplayName("Additional Option Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlOptnInf")]
    #endif
    [IsoXmlTag("AddtlOptnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalOptionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalOptionInformation { get; init; } 
    #else
    public System.String? AdditionalOptionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of the premium of a foreign exchange option trade and its settlement place.
    /// </summary>
    [IsoId("_TLb_QNp-Ed-ak6NoX_4Aeg_-1197044330")]
    [DisplayName("Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prm")]
    #endif
    [IsoXmlTag("Prm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PremiumAmount2 Premium { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PremiumAmount2 Premium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PremiumAmount2 Premium { get; init; } 
    #else
    public PremiumAmount2 Premium { get; set; } 
    #endif
    
    
    #nullable disable
    
}
