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
[IsoId("_2Y3yETq4EeWZFYSPlduMhw")]
[DisplayName("Original Item")]
public record OriginalItem5
{
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("_2fvO4zq4EeWZFYSPlduMhw")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("_2fvO5Tq4EeWZFYSPlduMhw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("_2fvO5zq4EeWZFYSPlduMhw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("_2fvO6Tq4EeWZFYSPlduMhw")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("_2fvO6zq4EeWZFYSPlduMhw")]
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference4? OriginalItemReference { get; init; }
}
