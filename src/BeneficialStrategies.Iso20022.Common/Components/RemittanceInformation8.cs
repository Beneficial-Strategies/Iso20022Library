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
[IsoId("_XijF0aFnEeKHbozT2UhHKA")]
[DisplayName("Remittance Information")]
public record RemittanceInformation8
{
    /// <summary>
    /// Unique identification, assigned by the originator, to unambiguously identify the remittance information within the message.
    /// </summary>
    [IsoId("_WZG0Z6LOEeKkeNjCPqn3xA")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_XtkqFaFnEeKHbozT2UhHKA")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Unstructured { get; init; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_XtkqGaFnEeKHbozT2UhHKA")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public StructuredRemittanceInformation10? Structured { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the original transactions, to which the remittance message refers.
    /// </summary>
    [IsoId("_F_dZ8KJhEeKmspP9k_hIRQ")]
    [DisplayName("Original Payment Information")]
    [IsoXmlTag("OrgnlPmtInf")]
    public required OriginalPaymentInformation6 OriginalPaymentInformation { get; init; }
}
