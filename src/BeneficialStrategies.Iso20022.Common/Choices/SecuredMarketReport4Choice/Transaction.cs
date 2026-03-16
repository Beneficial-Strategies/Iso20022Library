// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuredMarketReport4Choice
{
    /// <summary>
    /// Provides the details of the secured market transaction as reported by the reporting agent.
    /// </summary>
    [IsoId("_GZo0g8EREea7jLfvGi1PDw")]
    [DisplayName("Transaction")]
    public record Transaction : SecuredMarketReport4Choice_
    {
        /// <summary>
        /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
        /// </summary>
        [IsoId("_Gjde5cEREea7jLfvGi1PDw")]
        [DisplayName("Reported Transaction Status")]
        [IsoXmlTag("RptdTxSts")]
        public required TransactionOperationType1Code ReportedTransactionStatus { get; init; }

        /// <summary>
        /// Provides the novation status for the transaction.
        /// </summary>
        [IsoId("_e_Ex0cEUEea7jLfvGi1PDw")]
        [DisplayName("Novation Status")]
        [IsoXmlTag("NvtnSts")]
        public NovationStatus1Code? NovationStatus { get; init; }

        /// <summary>
        /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
        /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify.
        /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
        /// </summary>
        [IsoId("_Gjde58EREea7jLfvGi1PDw")]
        [DisplayName("Branch Identification")]
        [IsoXmlTag("BrnchId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? BranchIdentification { get; init; }

        /// <summary>
        /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
        /// </summary>
        [IsoId("_Gjde6cEREea7jLfvGi1PDw")]
        [DisplayName("Unique Transaction Identifier")]
        [IsoXmlTag("UnqTxIdr")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? UniqueTransactionIdentifier { get; init; }

        /// <summary>
        /// Internal unique transaction identifier used by the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Gjde68EREea7jLfvGi1PDw")]
        [DisplayName("Proprietary Transaction Identification")]
        [IsoXmlTag("PrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public required IsoMax105Text ProprietaryTransactionIdentification { get; init; }

        /// <summary>
        /// Original proprietary transaction identifier used by the reporting agent to indicate the proprietary transaction identification of the transaction which is novated.
        /// </summary>
        [IsoId("_HxN5McEWEea7jLfvGi1PDw")]
        [DisplayName("Related Proprietary Transaction Identification")]
        [IsoXmlTag("RltdPrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? RelatedProprietaryTransactionIdentification { get; init; }

        /// <summary>
        /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
        /// </summary>
        [IsoId("_Gjde7cEREea7jLfvGi1PDw")]
        [DisplayName("Counterparty Proprietary Transaction Identification")]
        [IsoXmlTag("CtrPtyPrtryTxId")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; }

        /// <summary>
        /// Identification of the counterparty of the reporting agent for the reported transaction.
        /// </summary>
        [IsoId("_Gjde78EREea7jLfvGi1PDw")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        public required CounterpartyIdentification3Choice_ CounterpartyIdentification { get; init; }

        /// <summary>
        /// Identification of the tri-party agent, when the transaction has been performed via tri-party agent.
        /// </summary>
        [IsoId("_Gjde8cEREea7jLfvGi1PDw")]
        [DisplayName("Triparty Agent Identification")]
        [IsoXmlTag("TrptyAgtId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? TripartyAgentIdentification { get; init; }

        /// <summary>
        /// Date and time on which the parties entered into the reported transaction.
        /// Usage: when time is available, it must be reported.
        /// It is to be reported with only the date when the time of the transaction is not available.
        /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
        /// </summary>
        [IsoId("_Gjde88EREea7jLfvGi1PDw")]
        [DisplayName("Trade Date")]
        [IsoXmlTag("TradDt")]
        public required DateAndDateTimeChoice_ TradeDate { get; init; }

        /// <summary>
        /// Date on which the amount of money is initially exchanged versus the asset as contractually agreed.
        /// Usage:
        /// In the case of open basis repurchase transactions, this is the date on which the rollover settles (even if no exchange of an amount of money takes place).
        /// In the case of a settlement failure in which settlement takes place on a date different than initially agreed, no transactional amendment needs to be reported.
        /// </summary>
        [IsoId("_Gjde9cEREea7jLfvGi1PDw")]
        [DisplayName("Settlement Date")]
        [IsoXmlTag("SttlmDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate SettlementDate { get; init; }

        /// <summary>
        /// Date on which the repurchase will be executed, that is the date on which the amount of money is due to be returned or received versus the asset pledged or received as collateral.
        /// </summary>
        [IsoId("_Gjde98EREea7jLfvGi1PDw")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Defines whether the transaction is a cash borrowing or cash lending transaction.
        /// </summary>
        [IsoId("_Gjde-cEREea7jLfvGi1PDw")]
        [DisplayName("Transaction Type")]
        [IsoXmlTag("TxTp")]
        public required MoneyMarketTransactionType1Code TransactionType { get; init; }

        /// <summary>
        /// Amount of money initially borrowed or lent to be reported as an absolute value.
        /// </summary>
        [IsoId("_Gjde_cEREea7jLfvGi1PDw")]
        [DisplayName("Transaction Nominal Amount")]
        [IsoXmlTag("TxNmnlAmt")]
        public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; }

        /// <summary>
        /// Specifies whether the transaction interest rate of the repurchase agreements is either fixed or floating (variable rate).
        /// </summary>
        [IsoId("_Gjde_8EREea7jLfvGi1PDw")]
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
        [IsoId("_GjdfAcEREea7jLfvGi1PDw")]
        [DisplayName("Deal Rate")]
        [IsoXmlTag("DealRate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? DealRate { get; init; }

        /// <summary>
        /// Repurchase agreement in which the periodic interest payments are calculated on the basis of the value (that is, fixing of an underlying reference rate such as Euribor) on predefined dates (that is, fixing dates) and which has a maturity of no more than one year.
        /// </summary>
        [IsoId("_GjdfA8EREea7jLfvGi1PDw")]
        [DisplayName("Floating Rate Repurchase Agreement")]
        [IsoXmlTag("FltgRateRpAgrmt")]
        public FloatingRateNote2? FloatingRateRepurchaseAgreement { get; init; }

        /// <summary>
        /// Specifies whether the transaction is arranged via a third party broker or not.
        /// </summary>
        [IsoId("_GjdfBcEREea7jLfvGi1PDw")]
        [DisplayName("Brokered Deal")]
        [IsoXmlTag("BrkrdDeal")]
        public BrokeredDeal1Code? BrokeredDeal { get; init; }

        /// <summary>
        /// Identifies the asset class pledged as collateral.
        /// </summary>
        [IsoId("_GjdfB8EREea7jLfvGi1PDw")]
        [DisplayName("Collateral")]
        [IsoXmlTag("Coll")]
        public required Collateral18 Collateral { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_GjdfCcEREea7jLfvGi1PDw")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
