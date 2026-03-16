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
[IsoId("_UzRxG7QYEeeKRKrD60ELBQ")]
[DisplayName("Settlement Type And Identification")]
public record SettlementTypeAndIdentification25
{
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_VCdckbQYEeeKRKrD60ELBQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Reference of the transaction.
    /// </summary>
    [IsoId("_VCdcmbQYEeeKRKrD60ELBQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    [IsoId("_VCdcm7QYEeeKRKrD60ELBQ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateAndDateTime2Choice_? SettlementDate { get; init; }
}
