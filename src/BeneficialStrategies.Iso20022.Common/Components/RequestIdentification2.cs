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
[IsoId("_iqWVsVQVEfG3m41zXZkDsg")]
[DisplayName("Request Identification2")]
public record RequestIdentification2
{
    /// <summary>
    /// Unique identification for the order.
    /// </summary>
    [IsoId("_i028kVQVEfG3m41zXZkDsg")]
    [DisplayName("Original Order Reference")]
    [IsoXmlTag("OrgnlOrdrRef")]
    public required IsoUUIDv4Identifier OriginalOrderReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash receiver for the cash withdrawal.
    /// </summary>
    [IsoId("_i028k1QVEfG3m41zXZkDsg")]
    [DisplayName("Original Cash Receiver Reference")]
    [IsoXmlTag("OrgnlCshRcvrRef")]
    public IsoMax35Text? OriginalCashReceiverReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the cash sender for the cash deposit.
    /// </summary>
    [IsoId("_i028lVQVEfG3m41zXZkDsg")]
    [DisplayName("Original Cash Sender Reference")]
    [IsoXmlTag("OrgnlCshSndrRef")]
    public IsoMax35Text? OriginalCashSenderReference { get; init; }

    /// <summary>
    /// Total amount of all notes and coins in the original request.
    /// </summary>
    [IsoId("_lJSdUVQVEfG3m41zXZkDsg")]
    [DisplayName("Original Total Amount")]
    [IsoXmlTag("OrgnlTtlAmt")]
    public ActiveCurrencyAndAmount? OriginalTotalAmount { get; init; }
}
