// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each individual foreign exchange swap transaction.
/// </summary>
[IsoId("_qm-xVZ2WEeW_58xcYxhewg")]
[DisplayName("Foreign Exchange Swap Transaction")]
public record ForeignExchangeSwapTransaction2
{
    /// <summary>
    /// Defines the status of the reported transaction, that is details on whether the transaction is a new transaction, an amendment of a previously reported transaction, a cancellation of a previously reported transaction or a correction to a previously reported and rejected transaction.
    /// </summary>
    [IsoId("_qua2EZ2WEeW_58xcYxhewg")]
    [DisplayName("Reported Transaction Status")]
    [IsoXmlTag("RptdTxSts")]
    public required TransactionOperationType1Code ReportedTransactionStatus { get; init; }

    /// <summary>
    /// Unique and unambiguous legal entity identification of the branch of the reporting agent in which the transaction has been booked.
    /// Usage: This field must only be provided if the transaction has been conducted and booked by a branch of the reporting agent and only if this branch has its own LEI that the reporting agent can clearly identify.
    /// Where the transaction has been booked by the head office or the reporting agent cannot be identified by a unique branch-specific LEI, the reporting agent must provide the LEI of the head office.
    /// </summary>
    [IsoId("__L4YwZ2WEeW_58xcYxhewg")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? BranchIdentification { get; init; }

    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime.
    /// </summary>
    [IsoId("_qua2E52WEeW_58xcYxhewg")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Internal unique transaction identifier used by the reporting agent for each transaction.
    /// </summary>
    [IsoId("_qua2FZ2WEeW_58xcYxhewg")]
    [DisplayName("Proprietary Transaction Identification")]
    [IsoXmlTag("PrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public required IsoMax105Text ProprietaryTransactionIdentification { get; init; }

    /// <summary>
    /// Internal unique proprietary transaction identifier as assigned by the counterparty of the reporting agent for each transaction.
    /// </summary>
    [IsoId("_qua2F52WEeW_58xcYxhewg")]
    [DisplayName("Counterparty Proprietary Transaction Identification")]
    [IsoXmlTag("CtrPtyPrtryTxId")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? CounterpartyProprietaryTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_qua2GZ2WEeW_58xcYxhewg")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyIdentification2Choice_ CounterpartyIdentification { get; init; }

    /// <summary>
    /// Date and time on which the parties entered into the reported transaction.
    /// Usage: when time is available, it must be reported.
    /// It is to be reported with only the date when the time of the transaction is not available.
    /// The reported time is the execution time when available or otherwise the time at which the transaction entered the trading system of the reporting agent.
    /// </summary>
    [IsoId("_qua2G52WEeW_58xcYxhewg")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required DateAndDateTimeChoice_ TradeDate { get; init; }

    /// <summary>
    /// Date on which one party sells to the other a specified amount of a specified currency against payment of an agreed amount of a specified different currency based on an agreed foreign exchange rate known as foreign exchange spot rate.
    /// </summary>
    [IsoId("_qua2HZ2WEeW_58xcYxhewg")]
    [DisplayName("Spot Value Date")]
    [IsoXmlTag("SpotValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SpotValueDate { get; init; }

    /// <summary>
    /// Date on which the foreign exchange swap transaction expires and the currency sold on the value date is repurchased.
    /// </summary>
    [IsoId("_qua2H52WEeW_58xcYxhewg")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MaturityDate { get; init; }

    /// <summary>
    /// Defines whether the amount of money reported under the transaction nominal amount is bought or sold on the spot value date.
    /// </summary>
    [IsoId("_qua2IZ2WEeW_58xcYxhewg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required SecuritiesTransactionType15Code TransactionType { get; init; }

    /// <summary>
    /// Specifies the nominal amount of the foreign exchange swap, that is the amount bought/sold on the spot value date and reported as an absolute value.
    /// </summary>
    [IsoId("_qua2I52WEeW_58xcYxhewg")]
    [DisplayName("Transaction Nominal Amount")]
    [IsoXmlTag("TxNmnlAmt")]
    public required ActiveCurrencyAndAmount TransactionNominalAmount { get; init; }

    /// <summary>
    /// Provides the details of the foreign exchange transaction.
    /// </summary>
    [IsoId("_qua2JZ2WEeW_58xcYxhewg")]
    [DisplayName("Foreign Exchange")]
    [IsoXmlTag("FX")]
    public required ForeignExchange1 ForeignExchange { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_qua2J52WEeW_58xcYxhewg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
