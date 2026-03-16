// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identify the original notification item, to which the cancellation advice refers.
/// </summary>
[IsoId("_-Ui7MCYbEd-VE9TPs3u0nQ")]
[DisplayName("Original Item")]
public record OriginalItem2
{
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("_-UssMSYbEd-VE9TPs3u0nQ")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("_-U2dMSYbEd-VE9TPs3u0nQ")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("_-U_nJCYbEd-VE9TPs3u0nQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("_-VSiESYbEd-VE9TPs3u0nQ")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("_VyZCYCegEd-TZN8k_VGT2w")]
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference1? OriginalItemReference { get; init; }
}
