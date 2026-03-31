// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_d5u5sdcZEeqRFcf2R4bPBw")]
[DisplayName("Remittance Information")]
public record RemittanceInformation20
{
    /// <summary>
    /// Unique identification, assigned by the originator, to unambiguously identify the remittance information within the message.
    /// </summary>
    [IsoId("_d7M5UdcZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_d7M5U9cZEeqRFcf2R4bPBw")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_d7M5VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation17> Structured { get; init; } = [];

    /// <summary>
    /// Set of elements used to provide information on the original transactions, to which the remittance message refers.
    /// </summary>
    [IsoId("_d7M5V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Payment Information")]
    [IsoXmlTag("OrgnlPmtInf")]
    public required OriginalPaymentInformation9 OriginalPaymentInformation { get; init; }
}
