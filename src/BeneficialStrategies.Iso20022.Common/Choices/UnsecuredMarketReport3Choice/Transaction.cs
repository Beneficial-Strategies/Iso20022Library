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
namespace BeneficialStrategies.Iso20022.Choices.UnsecuredMarketReport3Choice
{
    /// <summary>
    /// Provides the details of the unsecured market transaction as reported by the reporting agent.
    /// </summary>
    [IsoId("_HJT6I6ifEeWHO_l3hf2rlA")]
    [DisplayName("Transaction")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Transaction : UnsecuredMarketReport3Choice_
    #else
    public partial class Transaction : UnsecuredMarketReport3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Transaction instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Transaction( TransactionOperationType1Code reqReportedTransactionStatus,System.String reqProprietaryTransactionIdentification,CounterpartyIdentification2Choice_ reqCounterpartyIdentification,DateAndDateTimeChoice_ reqTradeDate,System.DateOnly reqSettlementDate,System.DateOnly reqMaturityDate,MoneyMarketTransactionType1Code reqTransactionType,FinancialInstrumentProductType1Code reqInstrumentType,ActiveCurrencyAndAmount reqTransactionNominalAmount,System.Decimal reqDealPrice,InterestRateType1Code reqRateType )
        {
            ReportedTransactionStatus = reqReportedTransactionStatus;
            ProprietaryTransactionIdentification = reqProprietaryTransactionIdentification;
            CounterpartyIdentification = reqCounterpartyIdentification;
            TradeDate = reqTradeDate;
            SettlementDate = reqSettlementDate;
            MaturityDate = reqMaturityDate;
            TransactionType = reqTransactionType;
            InstrumentType = reqInstrumentType;
            TransactionNominalAmount = reqTransactionNominalAmount;
            DealPrice = reqDealPrice;
            RateType = reqRateType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
        /// </summary>
        [IsoId("_Hm7DNaifEeWHO_l3hf2rlA")]
        [DisplayName("Reported Transaction Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptdTxSts")]
        #endif
        [IsoXmlTag("RptdTxSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        #else
        public TransactionOperationType1Code ReportedTransactionStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
        /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
        /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
        /// </summary>
        [IsoId("_Hm7DN6ifEeWHO_l3hf2rlA")]
        [DisplayName("Branch Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BrnchId")]
        #endif
        [IsoXmlTag("BrnchId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? BranchIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BranchIdentification { get; init; } 
        #else
        public System.String? BranchIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
        /// </summary>
        [IsoId("_Hm7DOaifEeWHO_l3hf2rlA")]
        [DisplayName("Unique Transaction Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTxIdr")]
        #endif
        [IsoXmlTag("UnqTxIdr")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UniqueTransactionIdentifier { get; init; } 
        #else
        public System.String? UniqueTransactionIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Internal unique transaction identifier used by the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Hm7DO6ifEeWHO_l3hf2rlA")]
        [DisplayName("Proprietary Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtryTxId")]
        #endif
        [IsoXmlTag("PrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ProprietaryTransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ProprietaryTransactionIdentification { get; init; } 
        #else
        public System.String ProprietaryTransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Hm7DPaifEeWHO_l3hf2rlA")]
        [DisplayName("Counterparty Proprietary Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyPrtryTxId")]
        #endif
        [IsoXmlTag("CtrPtyPrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CounterpartyProprietaryTransactionIdentification { get; init; } 
        #else
        public System.String? CounterpartyProprietaryTransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the counterparty of the reporting agent for the reported transaction.
        /// </summary>
        [IsoId("_Hm7DP6ifEeWHO_l3hf2rlA")]
        [DisplayName("Counterparty Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyId")]
        #endif
        [IsoXmlTag("CtrPtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        #else
        public CounterpartyIdentification2Choice_ CounterpartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time on which the parties entered into the reported transaction.
        /// Usage: when time is available, it must be reported.
        /// It is to be reported with only the date when the time of the transaction is not available. 
        /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
        /// </summary>
        [IsoId("_Hm7DQaifEeWHO_l3hf2rlA")]
        [DisplayName("Trade Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradDt")]
        #endif
        [IsoXmlTag("TradDt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DateAndDateTimeChoice_ TradeDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DateAndDateTimeChoice_ TradeDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTimeChoice_ TradeDate { get; init; } 
        #else
        public DateAndDateTimeChoice_ TradeDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money is exchanged by counterparties or on which the purchase or sale of a debt instrument settles. 
        /// With regard to call accounts and other unsecured borrowing/lending redeemable at notice, it is the date on which the deposit is rolled over, that is on which it would have been paid back if it had been called/not rolled over. In the case of a settlement failure in which settlement takes place on a different date than initially agreed, no transactional amendment needs to be reported.
        /// </summary>
        [IsoId("_Hm7DQ6ifEeWHO_l3hf2rlA")]
        [DisplayName("Settlement Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmDt")]
        #endif
        [IsoXmlTag("SttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate SettlementDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly SettlementDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly SettlementDate { get; init; } 
        #else
        public System.DateOnly SettlementDate { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the amount of money is due to be repaid by the borrower to the lender or on which a debt instrument matures and is due to be paid back. In regards to callable and puttable instruments, the final maturity date must be provided. For call accounts and other unsecured borrowing/lending redeemable upon notice, the first date on which the instrument may be redeemed must be provided.
        /// </summary>
        [IsoId("_Hm7DRaifEeWHO_l3hf2rlA")]
        [DisplayName("Maturity Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MtrtyDt")]
        #endif
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate MaturityDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly MaturityDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly MaturityDate { get; init; } 
        #else
        public System.DateOnly MaturityDate { get; set; } 
        #endif
        
        /// <summary>
        /// Defines whether the transaction is a cash borrowing or cash lending transaction.
        /// </summary>
        [IsoId("_Hm7DR6ifEeWHO_l3hf2rlA")]
        [DisplayName("Transaction Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxTp")]
        #endif
        [IsoXmlTag("TxTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MoneyMarketTransactionType1Code TransactionType { get; init; } 
        #else
        public MoneyMarketTransactionType1Code TransactionType { get; set; } 
        #endif
        
        /// <summary>
        /// Defines the instrument via which the borrowing or lending transaction takes place.
        /// </summary>
        [IsoId("_Hm7DS6ifEeWHO_l3hf2rlA")]
        [DisplayName("Instrument Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InstrmTp")]
        #endif
        [IsoXmlTag("InstrmTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentProductType1Code InstrumentType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentProductType1Code InstrumentType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentProductType1Code InstrumentType { get; init; } 
        #else
        public FinancialInstrumentProductType1Code InstrumentType { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money initially borrowed or lent on deposits. In the case of debt securities, it is the nominal amount of the security issued or purchased.
        /// </summary>
        [IsoId("_Hm7DTaifEeWHO_l3hf2rlA")]
        [DisplayName("Transaction Nominal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxNmnlAmt")]
        #endif
        [IsoXmlTag("TxNmnlAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount TransactionNominalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Dirty price at which the security is issued or traded in percentage points, and which is to be reported as 100 for unsecured deposits.
        /// </summary>
        [IsoId("_Hm7DT6ifEeWHO_l3hf2rlA")]
        [DisplayName("Deal Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DealPric")]
        #endif
        [IsoXmlTag("DealPric")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoPercentageRate DealPrice { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal DealPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal DealPrice { get; init; } 
        #else
        public System.Decimal DealPrice { get; set; } 
        #endif
        
        /// <summary>
        /// Fixed rate for deposits and debt instruments with fixed coupons or variable rate for debt instruments for which the pay out at maturity or period depends on observed value of some underlying reference rate as well as for unsecured deposits paying interest at regular intervals. 
        /// </summary>
        [IsoId("_Hm7DUaifEeWHO_l3hf2rlA")]
        [DisplayName("Rate Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateTp")]
        #endif
        [IsoXmlTag("RateTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InterestRateType1Code RateType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InterestRateType1Code RateType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateType1Code RateType { get; init; } 
        #else
        public InterestRateType1Code RateType { get; set; } 
        #endif
        
        /// <summary>
        /// Interest rate expressed in accordance with the local money market convention at which the repurchase agreement has been concluded and at which the cash lent is remunerated.
        /// Usage:
        /// When the remuneration for securities lending transactions is represented by a fee amount, the fee amount will be translated into a deal rate per annum based on the ratio between the fee amount and the transaction nominal amount times number of days based on relevant money market convention divided by the number of days between the settlement date and the maturity of the transaction. 
        /// Only actual values, as opposed to estimated or default values, will be reported for this variable.
        /// This value can be either positive or negative irrespective of whether the cash is borrowed or lent. It represents the contractually agreed remuneration rate on the transaction nominal amount regardless of the transaction sign (that whether the transaction type is reported as borrowed or lent).
        /// </summary>
        [IsoId("_Hm7DU6ifEeWHO_l3hf2rlA")]
        [DisplayName("Deal Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DealRate")]
        #endif
        [IsoXmlTag("DealRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Rate2? DealRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Rate2? DealRate { get; init; } 
        #else
        public Rate2? DealRate { get; set; } 
        #endif
        
        /// <summary>
        /// Debt instrument in which the periodic interest payments are calculated on the basis of the value (that is fixing of an underlying reference rate such as EURIBOR) on predefined dates (that is fixing) dates and which has a maturity of no more than one year.
        /// </summary>
        [IsoId("_Hm7DVaifEeWHO_l3hf2rlA")]
        [DisplayName("Floating Rate Note")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FltgRateNote")]
        #endif
        [IsoXmlTag("FltgRateNote")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FloatingRateNote2? FloatingRateNote { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FloatingRateNote2? FloatingRateNote { get; init; } 
        #else
        public FloatingRateNote2? FloatingRateNote { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the transaction is arranged via a third party broker or not.
        /// </summary>
        [IsoId("_Hm7DV6ifEeWHO_l3hf2rlA")]
        [DisplayName("Brokered Deal")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BrkrdDeal")]
        #endif
        [IsoXmlTag("BrkrdDeal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BrokeredDeal1Code? BrokeredDeal { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BrokeredDeal1Code? BrokeredDeal { get; init; } 
        #else
        public BrokeredDeal1Code? BrokeredDeal { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the option details, when the transaction reported is a call/put option.
        /// </summary>
        [IsoId("_Hm7DWaifEeWHO_l3hf2rlA")]
        [DisplayName("Call Put Option")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CallPutOptn")]
        #endif
        [IsoXmlTag("CallPutOptn")]
        [MinLength(0)]
        [MaxLength(2)]
        public ValueList<Option12> CallPutOption { get; init; } = new ValueList<Option12>(){};
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_Hm7DW6ifEeWHO_l3hf2rlA")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
