// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original withdrawal or deposit request.
/// </summary>
[IsoId("_ErmlMFGnEfC_v5ez7RpMHw")]
[DisplayName("Request Identification1")]
public record RequestIdentification1
{
    /// <summary>
    /// Unique identification for the order.
    /// </summary>
    [IsoId("_XEQ-klGnEfC_v5ez7RpMHw")]
    [DisplayName("Original Order Reference")]
    [IsoXmlTag("OrgnlOrdrRef")]
    public required IsoUUIDv4Identifier OriginalOrderReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash receiver for the cash withdrawal.
    /// </summary>
    [IsoId("_XEQ-k1GnEfC_v5ez7RpMHw")]
    [DisplayName("Original Cash Receiver Reference")]
    [IsoXmlTag("OrgnlCshRcvrRef")]
    public IsoMax35Text? OriginalCashReceiverReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash sender for the cash deposit.
    /// </summary>
    [IsoId("_Z2K6EWiTEfC7No_UZmyDXw")]
    [DisplayName("Original Cash Sender Reference")]
    [IsoXmlTag("OrgnlCshSndrRef")]
    public IsoMax35Text? OriginalCashSenderReference { get; init; }
}
