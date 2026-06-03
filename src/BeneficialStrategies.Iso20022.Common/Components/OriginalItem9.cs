// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification item, to which the cancellation advice refers.
/// </summary>
[IsoId("fa81c95b-1ac3-44ea-931a-84329c5bda0f")]
[DisplayName("Original Item9")]
public record OriginalItem9
{
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("6d8dc810-0b20-4d8c-ba79-cb1e67a33b43")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("d1d765e5-1fa3-4662-9a10-0cfcd028e9d1")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("1c451b9c-b037-4daa-a731-69d14581b071")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("87f43964-2dbb-4fad-ae09-8d68f61d5dd2")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("966a876b-db51-4270-a5db-abf7605d79b9")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("59d234ee-b0df-40b0-9bea-8612af0fed4a")]
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference8? OriginalItemReference { get; init; }
}
