// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall process covering the trade and settlement transactions of financial instruments.
/// </summary>
[IsoId("_cfvuM5KQEeWHWpTQn1FFVg")]
[DisplayName("Settlement Type And Identification")]
public record SettlementTypeAndIdentification21
{
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_cfvuNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Reference of the transaction.
    /// </summary>
    [IsoId("_cfvuPZKQEeWHWpTQn1FFVg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; }

    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    [IsoId("_cfvuP5KQEeWHWpTQn1FFVg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateAndDateTimeChoice_? SettlementDate { get; init; }
}
