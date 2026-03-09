// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TwoLegTransactionType1Choice
{
    /// <summary>
    /// Parameters for contracts which obligate the buyer to receive and the seller to deliver in the future the assets specified at an agreed price or contracts which grant to the holder either the privilege to purchase or the privilege to sell the assets specified at a predetermined price or formula at or within a time in the future.
    /// </summary>
    [IsoId("_AYOINtokEeC60axPepSq7g_921777527")]
    [DisplayName("Future Or Option Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FutureOrOptionDetails : TwoLegTransactionType1Choice_
    #else
    public partial class FutureOrOptionDetails : TwoLegTransactionType1Choice_
    #endif
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
        [IsoId("_AvBeodokEeC60axPepSq7g_2030935240")]
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
        [IsoId("_AvBeotokEeC60axPepSq7g_-376226312")]
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
        [IsoId("_AvBeo9okEeC60axPepSq7g_365772849")]
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
        [IsoId("_AvBepNokEeC60axPepSq7g_354674072")]
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
        [IsoId("_AvBepdokEeC60axPepSq7g_-1243311832")]
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
        [IsoId("_AvKokNokEeC60axPepSq7g_-1945802058")]
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
        [IsoId("_AvKokdokEeC60axPepSq7g_2021219608")]
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
        [IsoId("_AvKoktokEeC60axPepSq7g_-1763165363")]
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
        [IsoId("_AvKok9okEeC60axPepSq7g_839621736")]
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
        [IsoId("_AvKolNokEeC60axPepSq7g_521845075")]
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
        [IsoId("_AvKoldokEeC60axPepSq7g_1879656031")]
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
        [IsoId("_AvKoltokEeC60axPepSq7g_-988373229")]
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
        [IsoId("_AvUZkNokEeC60axPepSq7g_-1299764488")]
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
        [IsoId("_AvUZkdokEeC60axPepSq7g_-1495565773")]
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
        [IsoId("_AvUZktokEeC60axPepSq7g_1965979375")]
        [DisplayName("Ratio")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ratio")]
        #endif
        [IsoXmlTag("Ratio")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public UnderlyingRatio1? Ratio { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnderlyingRatio1? Ratio { get; init; } 
        #else
        public UnderlyingRatio1? Ratio { get; set; } 
        #endif
        
        /// <summary>
        /// Rating(s) of the security.
        /// </summary>
        [IsoId("_AvUZk9okEeC60axPepSq7g_-1389041298")]
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
        [IsoId("_AvUZlNokEeC60axPepSq7g_-1424901255")]
        [DisplayName("Issue Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IssePric")]
        #endif
        [IsoXmlTag("IssePric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Price4? IssuePrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Price4? IssuePrice { get; init; } 
        #else
        public Price4? IssuePrice { get; set; } 
        #endif
        
        /// <summary>
        /// Rights to exercise the privilege to purchase or to sell the assets specified at a predetermined price or formula at or within a time in the future.
        /// </summary>
        [IsoId("_AvUZldokEeC60axPepSq7g_-305341311")]
        [DisplayName("Option Rights")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OptnRghts")]
        #endif
        [IsoXmlTag("OptnRghts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OptionRight1Choice_? OptionRights { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OptionRight1Choice_? OptionRights { get; init; } 
        #else
        public OptionRight1Choice_? OptionRights { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether or not this is the last transaction.
        /// </summary>
        [IsoId("_AvUZltokEeC60axPepSq7g_-1808362353")]
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
        [IsoId("_AvdjgNokEeC60axPepSq7g_90977262")]
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
}
