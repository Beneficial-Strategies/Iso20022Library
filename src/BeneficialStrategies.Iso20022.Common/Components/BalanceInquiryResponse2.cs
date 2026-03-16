// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Response message.
/// </summary>
[IsoId("_FM7pwQxrEeqdx6buGpCCQw")]
[DisplayName("Balance Inquiry Response")]
public record BalanceInquiryResponse2
{
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_FYARUQxrEeqdx6buGpCCQw")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_FYARUwxrEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount2? LoyaltyAccount { get; init; }

    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_FYARVQxrEeqdx6buGpCCQw")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_FYARVwxrEeqdx6buGpCCQw")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt2> Receipt { get; init; } = [];
}
