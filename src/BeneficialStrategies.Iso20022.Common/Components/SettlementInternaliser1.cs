// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the submitting entity and Settlement Internaliser of the report.
/// </summary>
[IsoId("_x6_YcO3mEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser")]
public record SettlementInternaliser1
{
    /// <summary>
    /// Identifies the submitting entity and settlement Internaliser of the report.
    /// </summary>
    [IsoId("_29gQEO3mEeaWjpoyrnG6Rw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SettlementInternaliserIdentification1 Identification { get; init; }

    /// <summary>
    /// Overall aggregated total value and volume of
    /// - settled and failed and total of internalised settlement instructions, and
    /// - failed rate of internalised settlement instructions
    /// performed during the period covered by the report, for all financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_7EFD4O3mEeaWjpoyrnG6Rw")]
    [DisplayName("Overall Total")]
    [IsoXmlTag("OvrllTtl")]
    public required InternalisationData1 OverallTotal { get; init; }

    /// <summary>
    /// Classification of a financial instrument according to the categories defined in the relevant legislation.
    /// </summary>
    [IsoId("_99b2oO3mEeaWjpoyrnG6Rw")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; init; }

    /// <summary>
    /// Classification of securities movements according to the categories defined in the relevant legislation.
    /// </summary>
    [IsoId("_ErEMQO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required SettlementInternaliserTransactionType1 TransactionType { get; init; }

    /// <summary>
    /// Classification of a settlement internaliser&apos;s clients as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_FjS0wO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Client Type")]
    [IsoXmlTag("ClntTp")]
    public required SettlementInternaliserClientType1 ClientType { get; init; }

    /// <summary>
    /// Covers cash payments related to securities transactions.
    /// </summary>
    [IsoId("_H-wKkO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Total Cash Transfer")]
    [IsoXmlTag("TtlCshTrf")]
    public required InternalisationData1 TotalCashTransfer { get; init; }
}
