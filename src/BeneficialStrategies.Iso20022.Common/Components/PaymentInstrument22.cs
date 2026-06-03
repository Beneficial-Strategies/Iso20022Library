// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment parties for the transfer of cash from the debtor to the creditor.
/// </summary>
[IsoId("f90cf436-8a1f-43d7-9f4d-64c45f52f61c")]
[DisplayName("Payment Instrument22")]
public record PaymentInstrument22
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("18694072-a3d4-4fbc-bc37-9b3444db9e95")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("57830f8d-54f0-4f9e-9d91-2ddfb2dc0ffd")]
    [DisplayName("Credit Transfer Details")]
    [IsoXmlTag("CdtTrfDtls")]
    public CreditTransfer13? CreditTransferDetails { get; init; }
}
