// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the requested modifications.
/// </summary>
[IsoId("_VShXY5lQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Modification")]
public record TransactionModification4
{
    /// <summary>
    /// Reference to the instruction related to the payment for which a modification is requested.
    /// </summary>
    [IsoId("_Vblzo5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification5Choice_ PaymentIdentification { get; init; }

    /// <summary>
    /// New payment values.
    /// </summary>
    [IsoId("_VblzpZlQEee-Zps0fZQaFQ")]
    [DisplayName("New Payment Value Set")]
    [IsoXmlTag("NewPmtValSet")]
    public required PaymentInstruction27 NewPaymentValueSet { get; init; }
}
