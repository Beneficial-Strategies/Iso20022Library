// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction totals during the reconciliation period, for a certain type of transaction.
/// </summary>
[IsoId("_TGSgYwEcEeCQm6a_G2yO_w_12313043")]
[DisplayName("Transaction Totals")]
public record TransactionTotals1
{
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_TGcRUAEcEeCQm6a_G2yO_w_-1831555946")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; }

    /// <summary>
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_TGcRUQEcEeCQm6a_G2yO_w_-1096609716")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? CardProductProfile { get; init; }

    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [IsoId("_TGcRUgEcEeCQm6a_G2yO_w_-1699958713")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Identification of the type of transaction.
    /// </summary>
    [IsoId("_TGcRUwEcEeCQm6a_G2yO_w_1606471381")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeTransactionTotals1Code Type { get; init; }

    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [IsoId("_TGcRVAEcEeCQm6a_G2yO_w_24821323")]
    [DisplayName("Total Number")]
    [IsoXmlTag("TtlNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText TotalNumber { get; init; }

    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    [IsoId("_TGcRVQEcEeCQm6a_G2yO_w_213589768")]
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public required ImpliedCurrencyAndAmount CumulativeAmount { get; init; }
}
