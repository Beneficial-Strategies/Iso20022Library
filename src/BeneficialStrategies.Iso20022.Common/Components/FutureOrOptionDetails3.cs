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
/// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price or contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
/// </summary>
[IsoId("_TKaGYQeFEe2fOITqoTnSLQ")]
[DisplayName("Future Or Option Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FutureOrOptionDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the contract for futures and options.
    /// </summary>
    [IsoId("_TdVCYQeFEe2fOITqoTnSLQ")]
    [DisplayName("Future And Option Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FutrAndOptnCtrctTp")]
    #endif
    [IsoXmlTag("FutrAndOptnCtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FutureAndOptionContractType1Code? FutureAndOptionContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FutureAndOptionContractType1Code? FutureAndOptionContractType { get; init; } 
    #else
    public FutureAndOptionContractType1Code? FutureAndOptionContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time by which the option for physical delivery may still be exercised.
    /// </summary>
    [IsoId("_TdVCYweFEe2fOITqoTnSLQ")]
    [DisplayName("Last Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastDlvryDt")]
    #endif
    [IsoXmlTag("LastDlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? LastDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? LastDeliveryDate { get; init; } 
    #else
    public System.DateTime? LastDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Used to indicate the size of the underlying commodity on which the contract is based (e.g., 2500 lbs of lean cattle, 1000 barrels of crude oil, 1000 bushels of corn, etc.).
    /// </summary>
    [IsoId("_TdVCZQeFEe2fOITqoTnSLQ")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which future contracts settle.
    /// </summary>
    [IsoId("_TdVCZweFEe2fOITqoTnSLQ")]
    [DisplayName("Future Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FutrDt")]
    #endif
    [IsoXmlTag("FutrDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FutureDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FutureDate { get; init; } 
    #else
    public System.DateTime? FutureDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the minimum ratio or multiply factor used to convert from contracts to shares.
    /// </summary>
    [IsoId("_TdVCaQeFEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSz")]
    #endif
    [IsoXmlTag("MinSz")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumSize { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumSize { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time, as announced by the issuer, at which the securities will be issued.
    /// </summary>
    [IsoId("_TdVCaweFEe2fOITqoTnSLQ")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AnnouncementDate { get; init; } 
    #else
    public System.DateTime? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the deliverability of a security.
    /// </summary>
    [IsoId("_TdVCbQeFEe2fOITqoTnSLQ")]
    [DisplayName("Appearance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Apprnc")]
    #endif
    [IsoXmlTag("Apprnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Appearance1Code? Appearance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Appearance1Code? Appearance { get; init; } 
    #else
    public Appearance1Code? Appearance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest is separable from the principal.
    /// </summary>
    [IsoId("_TdVCbweFEe2fOITqoTnSLQ")]
    [DisplayName("Strippable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrpblInd")]
    #endif
    [IsoXmlTag("StrpblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StrippableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StrippableIndicator { get; init; } 
    #else
    public System.String? StrippableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the maximum number of listed option contracts on a single security which can be held by an investor or group of investors acting jointly.
    /// </summary>
    [IsoId("_TdVCcQeFEe2fOITqoTnSLQ")]
    [DisplayName("Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosLmt")]
    #endif
    [IsoXmlTag("PosLmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PositionLimit { get; init; } 
    #else
    public System.UInt64? PositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Position limit in the near-term contract for a given exchange-traded product.
    /// </summary>
    [IsoId("_TdVCcweFEe2fOITqoTnSLQ")]
    [DisplayName("Near Term Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NearTermPosLmt")]
    #endif
    [IsoXmlTag("NearTermPosLmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NearTermPositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NearTermPositionLimit { get; init; } 
    #else
    public System.UInt64? NearTermPositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum price increase for a given exchange-traded Instrument.
    /// </summary>
    [IsoId("_TdVCdQeFEe2fOITqoTnSLQ")]
    [DisplayName("Minimum Trading Pricing Increment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTradgPricgIncrmt")]
    #endif
    [IsoXmlTag("MinTradgPricgIncrmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumTradingPricingIncrement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumTradingPricingIncrement { get; init; } 
    #else
    public System.UInt64? MinimumTradingPricingIncrement { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_TdVCdweFEe2fOITqoTnSLQ")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies when the contract (i.e. MBS/TBA) will settle.
    /// </summary>
    [IsoId("_TdVCeQeFEe2fOITqoTnSLQ")]
    [DisplayName("Contract Settlement Month")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctSttlmMnth")]
    #endif
    [IsoXmlTag("CtrctSttlmMnth")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? ContractSettlementMonth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? ContractSettlementMonth { get; init; } 
    #else
    public System.UInt16? ContractSettlementMonth { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which new securities begin trading.
    /// </summary>
    [IsoId("_TdVCeweFEe2fOITqoTnSLQ")]
    [DisplayName("First Dealing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstDealgDt")]
    #endif
    [IsoXmlTag("FrstDealgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? FirstDealingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? FirstDealingDate { get; init; } 
    #else
    public DateAndDateTime1Choice_? FirstDealingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio applied to convert the related security.
    /// </summary>
    [IsoId("_TdVCfQeFEe2fOITqoTnSLQ")]
    [DisplayName("Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratio")]
    #endif
    [IsoXmlTag("Ratio")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingRatio2? Ratio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingRatio2? Ratio { get; init; } 
    #else
    public UnderlyingRatio2? Ratio { get; set; } 
    #endif
    
    /// <summary>
    /// Rating(s) of the security.
    /// </summary>
    [IsoId("_TdVCfweFEe2fOITqoTnSLQ")]
    [DisplayName("Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratg")]
    #endif
    [IsoXmlTag("Ratg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rating1? Rating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rating1? Rating { get; init; } 
    #else
    public Rating1? Rating { get; set; } 
    #endif
    
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_TdVCgQeFEe2fOITqoTnSLQ")]
    [DisplayName("Issue Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssePric")]
    #endif
    [IsoXmlTag("IssePric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price14? IssuePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price14? IssuePrice { get; init; } 
    #else
    public Price14? IssuePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Rights to exercise the privilege to purchase or to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_TdVCgweFEe2fOITqoTnSLQ")]
    [DisplayName("Option Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnRghts")]
    #endif
    [IsoXmlTag("OptnRghts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionRight2Choice_? OptionRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionRight2Choice_? OptionRights { get; init; } 
    #else
    public OptionRight2Choice_? OptionRights { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not this is the last transaction.
    /// </summary>
    [IsoId("_TdVChQeFEe2fOITqoTnSLQ")]
    [DisplayName("Last Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastTx")]
    #endif
    [IsoXmlTag("LastTx")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LastTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastTransaction { get; init; } 
    #else
    public System.String? LastTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that there will be one price and one transaction when two contracts are carried out simultaneously, one to buy and the other one to sell with two different expiration dates.
    /// </summary>
    [IsoId("_TdVChweFEe2fOITqoTnSLQ")]
    [DisplayName("Spread Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SprdTx")]
    #endif
    [IsoXmlTag("SprdTx")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SpreadTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SpreadTransaction { get; init; } 
    #else
    public System.String? SpreadTransaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
