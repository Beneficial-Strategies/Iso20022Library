// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual overnight index swap transaction.
/// </summary>
[IsoId("_zLz71aicEeWHO_l3hf2rlA")]
[DisplayName("Overnight Index Swap Transaction")]
public record OvernightIndexSwapTransaction3
{
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    [IsoId("_znSW4aicEeWHO_l3hf2rlA")]
    [DisplayName("Reported Transaction Status")]
    [IsoXmlTag("RptdTxSts")]
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; }

    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify.
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    [IsoId("_1UopgaicEeWHO_l3hf2rlA")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? BranchIdentification { get; init; }

    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    [IsoId("_znSW46icEeWHO_l3hf2rlA")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    [IsoId("_znSW5aicEeWHO_l3hf2rlA")]
    [DisplayName("Proprietary Transaction Identification")]
    [IsoXmlTag("PrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; }

    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    [IsoId("_znSW56icEeWHO_l3hf2rlA")]
    [DisplayName("Counterparty Proprietary Transaction Identification")]
    [IsoXmlTag("CtrPtyPrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_znSW6aicEeWHO_l3hf2rlA")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; }

    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available.
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    [IsoId("_znSW66icEeWHO_l3hf2rlA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTimeChoice_ TradeDate { get; init; }

    /// <summary>
    /// Represents the date as of which the overnight rate of the floating leg is computed.
    /// </summary>
    [IsoId("_znSW7aicEeWHO_l3hf2rlA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; }

    /// <summary>
    /// Last date of the term over which the compounded overnight rate is calculated.
    /// </summary>
    [IsoId("_znSW76icEeWHO_l3hf2rlA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MaturityDate { get; init; }

    /// <summary>
    /// Fixed rate used for the calculation of the overnight index swap pay out.
    /// </summary>
    [IsoId("_znSW8aicEeWHO_l3hf2rlA")]
    [DisplayName("Fixed Interest Rate")]
    [IsoXmlTag("FxdIntrstRate")]
    public required Rate2 FixedInterestRate { get; init; }

    /// <summary>
    /// Defines whether the fixed interest rate is paid or received by the reporting agent.
    /// </summary>
    [IsoId("_znSW86icEeWHO_l3hf2rlA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required OvernightIndexSwapType1Code TransactionType { get; init; }

    /// <summary>
    /// Notional amount of the overnight index swap.
    /// </summary>
    [IsoId("_znSW9aicEeWHO_l3hf2rlA")]
    [DisplayName("Transaction Nominal Amount")]
    [IsoXmlTag("TxNmnlAmt")]
    public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_znSW96icEeWHO_l3hf2rlA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
