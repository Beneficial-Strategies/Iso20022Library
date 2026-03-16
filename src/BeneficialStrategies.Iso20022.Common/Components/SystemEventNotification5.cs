// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of system service to be used with this message.
/// </summary>
[IsoId("_vx7ZAU7AEeyGi9JAv6wq7Q")]
[DisplayName("System Event Notification")]
public record SystemEventNotification5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_v4CoEU7AEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_v4CoE07AEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Content of the EventNotification message.
    /// </summary>
    [IsoId("_v4CoFU7AEeyGi9JAv6wq7Q")]
    [DisplayName("Event Notification")]
    [IsoXmlTag("EvtNtfctn")]
    public required EventNotificationData4 EventNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_v4CoF07AEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
