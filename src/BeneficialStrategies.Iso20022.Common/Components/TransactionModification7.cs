// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Modification7.
/// </summary>
[IsoId("_6V6WATEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Modification7")]
public record TransactionModification7
{
    /// <summary>
    /// New Payment Value Set.
    /// </summary>
    [DisplayName("New Payment Value Set")]
    [IsoXmlTag("NewPmtValSet")]
    public required PaymentInstruction33 NewPaymentValueSet { get; init; }

    /// <summary>
    /// Payment Identification.
    /// </summary>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification8Choice_ PaymentIdentification { get; init; }
}
