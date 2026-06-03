// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle.
/// </summary>
[IsoId("7967c9b0-ad21-45bd-ac67-2629422408f5")]
[DisplayName("Remittance Information27")]
public record RemittanceInformation27
{
    /// <summary>
    /// Unique identification, assigned by the originator, to unambiguously identify the remittance information within the message.
    /// </summary>
    [IsoId("305bf794-13c0-4e1b-9a65-52fd60523a8a")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry, in an unstructured form.
    /// </summary>
    [IsoId("1a43acbe-d278-4a26-96fb-0cb5ba5a64fe")]
    [DisplayName("Unstructured")]
    [IsoXmlTag("Ustrd")]
    public SimpleValueList<IsoMax140Text> Unstructured { get; init; } = [];

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry, in a structured form.
    /// </summary>
    [IsoId("03ea57df-269f-4102-bf4e-0dcc1629f4c0")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public ValueList<StructuredRemittanceInformation22> Structured { get; init; } = [];

    /// <summary>
    /// Set of elements used to provide information on the original transactions, to which the remittance message refers.
    /// </summary>
    [IsoId("8eeb427d-dab9-4f0f-a578-8d240fe702a1")]
    [DisplayName("Original Payment Information")]
    [IsoXmlTag("OrgnlPmtInf")]
    public required OriginalPaymentInformation10 OriginalPaymentInformation { get; init; }
}
