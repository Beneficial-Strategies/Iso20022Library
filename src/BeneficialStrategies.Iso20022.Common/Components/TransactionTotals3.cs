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
[IsoId("_B-9vYWmAEeSxgrJ0GX4SQQ")]
[DisplayName("Transaction Totals")]
public record TransactionTotals3
{
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_CMRyoWmAEeSxgrJ0GX4SQQ")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; }

    /// <summary>
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_CMRyo2mAEeSxgrJ0GX4SQQ")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductProfile { get; init; }

    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [IsoId("_CMRypWmAEeSxgrJ0GX4SQQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Identification of the type of transaction.
    /// </summary>
    [IsoId("_CMRyp2mAEeSxgrJ0GX4SQQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeTransactionTotals2Code Type { get; init; }

    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [IsoId("_CMRyqWmAEeSxgrJ0GX4SQQ")]
    [DisplayName("Total Number")]
    [IsoXmlTag("TtlNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumber { get; init; }

    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    [IsoId("_CMRyq2mAEeSxgrJ0GX4SQQ")]
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public required ImpliedCurrencyAndAmount CumulativeAmount { get; init; }
}
