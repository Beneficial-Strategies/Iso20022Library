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
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData30Choice
{
    /// <summary>
    /// Details of the margin lending transaction.
    /// </summary>
    [IsoId("_gHkCd8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Margin Lending")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginLending : TransactionLoanData30Choice_
    #else
    public partial class MarginLending : TransactionLoanData30Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginLending instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginLending( System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,System.DateTime reqExecutionDateTime )
        {
            UniqueTradeIdentifier = reqUniqueTradeIdentifier;
            EventDate = reqEventDate;
            ExecutionDateTime = reqExecutionDateTime;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_oLE7Acg6Eeu4ecZgAYuz5w")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String UniqueTradeIdentifier { get; init; } 
        #else
        public System.String UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_oLE7A8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDate { get; init; } 
        #else
        public System.DateOnly EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_oLE7Bcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Execution Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctnDtTm")]
        #endif
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ExecutionDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ExecutionDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ExecutionDateTime { get; init; } 
        #else
        public System.DateTime ExecutionDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_oLE7B8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Trading Venue")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradgVn")]
        #endif
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMICIdentifier? TradingVenue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TradingVenue { get; init; } 
        #else
        public System.String? TradingVenue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
        /// </summary>
        [IsoId("_oLE7Ccg6Eeu4ecZgAYuz5w")]
        [DisplayName("Collateral Delivery Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollDlvryMtd")]
        #endif
        [IsoXmlTag("CollDlvryMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        #else
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Total amount of margin loans in base currency.
        /// </summary>
        [IsoId("_oLE7C8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Outstanding Margin Loan Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OutsdngMrgnLnAmt")]
        #endif
        [IsoXmlTag("OutsdngMrgnLnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Market value of short position in base currency.
        /// </summary>
        [IsoId("_oLE7Dcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Short Market Value Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtMktValAmt")]
        #endif
        [IsoXmlTag("ShrtMktValAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Data on amount and interest rates of the transaction.
        /// </summary>
        [IsoId("_oLE7D8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Margin Loan Attribute")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MrgnLnAttr")]
        #endif
        [IsoXmlTag("MrgnLnAttr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRate6? MarginLoanAttribute { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRate6? MarginLoanAttribute { get; init; } 
        #else
        public InterestRate6? MarginLoanAttribute { get; set; } 
        #endif
        
        /// <summary>
        /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
        /// </summary>
        [IsoId("_oLE7Ecg6Eeu4ecZgAYuz5w")]
        [DisplayName("Termination Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TermntnDt")]
        #endif
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? TerminationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? TerminationDate { get; init; } 
        #else
        public System.DateOnly? TerminationDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
