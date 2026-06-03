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
[IsoId("28583aa3-73e6-4572-8fa0-c4c0341848f9")]
[DisplayName("Payment Instrument21")]
public record PaymentInstrument21
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer was intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("de5c9b6b-935d-48af-8b56-e684dd626f27")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("a02a599d-4309-4c37-bd8c-535cf85316a4")]
    [DisplayName("Credit Transfer Details")]
    [IsoXmlTag("CdtTrfDtls")]
    public CreditTransfer13? CreditTransferDetails { get; init; }
}
