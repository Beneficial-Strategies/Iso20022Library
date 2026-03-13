// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnsecuredMarketReport3Choice
{
    /// <summary>
    /// Provides the details of the unsecured market transaction as reported by the reporting agent.
    /// </summary>
    [IsoId("_HJT6I6ifEeWHO_l3hf2rlA")]
    [DisplayName("Transaction")]
    public partial record Transaction : UnsecuredMarketReport3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
        /// </summary>
        [IsoId("_Hm7DNaifEeWHO_l3hf2rlA")]
        [DisplayName("Reported Transaction Status")]
        [IsoXmlTag("RptdTxSts")]
        public required TransactionOperationType1Code ReportedTransactionStatus { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
        /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify. 
        /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
        /// </summary>
        [IsoId("_Hm7DN6ifEeWHO_l3hf2rlA")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? BranchIdentification { get; init; } 
        
        /// <summary>
        /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
        /// </summary>
        [IsoId("_Hm7DOaifEeWHO_l3hf2rlA")]
        [DisplayName("Unique Transaction Identifier")]
        [IsoXmlTag("UnqTxIdr")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        public IsoMax105Text? UniqueTransactionIdentifier { get; init; } 
        
        /// <summary>
        /// Internal unique transaction identifier used by the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Hm7DO6ifEeWHO_l3hf2rlA")]
        [DisplayName("Proprietary Transaction Identification")]
        [IsoXmlTag("PrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        public required IsoMax105Text ProprietaryTransactionIdentification { get; init; } 
        
        /// <summary>
        /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Hm7DPaifEeWHO_l3hf2rlA")]
        [DisplayName("Counterparty Proprietary Transaction Identification")]
        [IsoXmlTag("CtrPtyPrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; } 
        
        /// <summary>
        /// Identification of the counterparty of the reporting agent for the reported transaction.
        /// </summary>
        [IsoId("_Hm7DP6ifEeWHO_l3hf2rlA")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; } 
        
        /// <summary>
        /// Date and time on which the parties entered into the reported transaction.
        /// Usage: when time is available, it must be reported.
        /// It is to be reported with only the date when the time of the transaction is not available. 
        /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
        /// </summary>
        [IsoId("_Hm7DQaifEeWHO_l3hf2rlA")]
        [DisplayName("Trade Date")]
        [IsoXmlTag("TradDt")]
        public required DateAndDateTimeChoice_ TradeDate { get; init; } 
        
        /// <summary>
        /// Date on which the amount of money is exchanged by counterparties or on which the purchase or sale of a debt instrument settles. 
        /// With regard to call accounts and other unsecured borrowing/lending redeemable at notice, it is the date on which the deposit is rolled over, that is on which it would have been paid back if it had been called/not rolled over. In the case of a settlement failure in which settlement takes place on a different date than initially agreed, no transactional amendment needs to be reported.
        /// </summary>
        [IsoId("_Hm7DQ6ifEeWHO_l3hf2rlA")]
        [DisplayName("Settlement Date")]
        [IsoXmlTag("SttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate SettlementDate { get; init; } 
        
        /// <summary>
        /// Date on which the amount of money is due to be repaid by the borrower to the lender or on which a debt instrument matures and is due to be paid back. In regards to callable and puttable instruments, the final maturity date must be provided. For call accounts and other unsecured borrowing/lending redeemable upon notice, the first date on which the instrument may be redeemed must be provided.
        /// </summary>
        [IsoId("_Hm7DRaifEeWHO_l3hf2rlA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; } 
        
        /// <summary>
        /// Defines whether the transaction is a cash borrowing or cash lending transaction.
        /// </summary>
        [IsoId("_Hm7DR6ifEeWHO_l3hf2rlA")]
        [DisplayName("Transaction Type")]
        [IsoXmlTag("TxTp")]
        public required MoneyMarketTransactionType1Code TransactionType { get; init; } 
        
        /// <summary>
        /// Defines the instrument via which the borrowing or lending transaction takes place.
        /// </summary>
        [IsoId("_Hm7DS6ifEeWHO_l3hf2rlA")]
        [DisplayName("Instrument Type")]
        [IsoXmlTag("InstrmTp")]
        public required FinancialInstrumentProductType1Code InstrumentType { get; init; } 
        
        /// <summary>
        /// Amount of money initially borrowed or lent on deposits. In the case of debt securities, it is the nominal amount of the security issued or purchased.
        /// </summary>
        [IsoId("_Hm7DTaifEeWHO_l3hf2rlA")]
        [DisplayName("Transaction Nominal Amount")]
        [IsoXmlTag("TxNmnlAmt")]
        public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; } 
        
        /// <summary>
        /// Dirty price at which the security is issued or traded in percentage points, and which is to be reported as 100 for unsecured deposits.
        /// </summary>
        [IsoId("_Hm7DT6ifEeWHO_l3hf2rlA")]
        [DisplayName("Deal Price")]
        [IsoXmlTag("DealPric")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate DealPrice { get; init; } 
        
        /// <summary>
        /// Fixed rate for deposits and debt instruments with fixed coupons or variable rate for debt instruments for which the pay out at maturity or period depends on observed value of some underlying reference rate as well as for unsecured deposits paying interest at regular intervals. 
        /// </summary>
        [IsoId("_Hm7DUaifEeWHO_l3hf2rlA")]
        [DisplayName("Rate Type")]
        [IsoXmlTag("RateTp")]
        public required InterestRateType1Code RateType { get; init; } 
        
        /// <summary>
        /// Interest rate expressed in accordance with the local money market convention at which the repurchase agreement has been concluded and at which the cash lent is remunerated.
        /// Usage:
        /// When the remuneration for securities lending transactions is represented by a fee amount, the fee amount will be translated into a deal rate per annum based on the ratio between the fee amount and the transaction nominal amount times number of days based on relevant money market convention divided by the number of days between the settlement date and the maturity of the transaction. 
        /// Only actual values, as opposed to estimated or default values, will be reported for this variable.
        /// This value can be either positive or negative irrespective of whether the cash is borrowed or lent. It represents the contractually agreed remuneration rate on the transaction nominal amount regardless of the transaction sign (that whether the transaction type is reported as borrowed or lent).
        /// </summary>
        [IsoId("_Hm7DU6ifEeWHO_l3hf2rlA")]
        [DisplayName("Deal Rate")]
        [IsoXmlTag("DealRate")]
        public Rate2? DealRate { get; init; } 
        
        /// <summary>
        /// Debt instrument in which the periodic interest payments are calculated on the basis of the value (that is fixing of an underlying reference rate such as EURIBOR) on predefined dates (that is fixing) dates and which has a maturity of no more than one year.
        /// </summary>
        [IsoId("_Hm7DVaifEeWHO_l3hf2rlA")]
        [DisplayName("Floating Rate Note")]
        [IsoXmlTag("FltgRateNote")]
        public FloatingRateNote2? FloatingRateNote { get; init; } 
        
        /// <summary>
        /// Specifies whether the transaction is arranged via a third party broker or not.
        /// </summary>
        [IsoId("_Hm7DV6ifEeWHO_l3hf2rlA")]
        [DisplayName("Brokered Deal")]
        [IsoXmlTag("BrkrdDeal")]
        public BrokeredDeal1Code? BrokeredDeal { get; init; } 
        
        /// <summary>
        /// Provides the option details, when the transaction reported is a call/put option.
        /// </summary>
        [IsoId("_Hm7DWaifEeWHO_l3hf2rlA")]
        [DisplayName("Call Put Option")]
        [IsoXmlTag("CallPutOptn")]
        [MinLength(0)]
        [MaxLength(2)]
        public ValueList<Option12> CallPutOption { get; init; } = [];
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_Hm7DW6ifEeWHO_l3hf2rlA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
