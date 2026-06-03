// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification item and to provide the status.
/// </summary>
[IsoId("25699087-895a-48af-a7d1-b1de9efec3dd")]
[DisplayName("Original Item And Status9")]
public record OriginalItemAndStatus9
{
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("3f07c9bb-27b8-4d65-9f04-0c9757741440")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    public required IsoMax35Text OriginalItemIdentification { get; init; }

    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("3088ff6f-540f-4637-a6c7-d98e15a4474c")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("06f1a2cf-b766-4b32-9fda-78cf54719f36")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("1e80809e-cf1e-4484-846e-f13a0304ddb1")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Value date on which the account was expected to be credited.
    /// </summary>
    [IsoId("09d5a351-0451-4cd3-bb3d-5c4abf456d3d")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Specifies the status of the notification item.
    /// </summary>
    [IsoId("33661cae-1431-4a67-ba94-5de15dbce066")]
    [DisplayName("Item Status")]
    [IsoXmlTag("ItmSts")]
    public required NotificationStatus3Code ItemStatus { get; init; }

    /// <summary>
    /// Further details of the item status.
    /// </summary>
    [IsoId("46c12b04-18a3-4cec-8524-b660333e694f")]
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    public IsoMax105Text? AdditionalStatusInformation { get; init; }

    /// <summary>
    /// Provides further information in order to identify a previous payment notification.
    /// </summary>
    [IsoId("4d234a65-dbab-4e6c-9d7b-4c06103c155b")]
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference8? OriginalItemReference { get; init; }
}
