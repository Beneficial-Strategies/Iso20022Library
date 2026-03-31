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
[IsoId("_fsCM4E3zEeiQHa-q1Uephw")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument14
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_oUR1EE3zEeiQHa-q1Uephw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_rXUvUE3zEeiQHa-q1Uephw")]
    [DisplayName("Credit Transfer Details")]
    [IsoXmlTag("CdtTrfDtls")]
    public CreditTransfer9? CreditTransferDetails { get; init; }
}
