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
[IsoId("_i9OiMYYCEemxIqbaFEE8-w")]
[DisplayName("System Event Notification")]
public record SystemEventNotification2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_jHeqYYYCEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_jHeqY4YCEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Content of the EventNotification message.
    /// </summary>
    [IsoId("_jHeqZYYCEemxIqbaFEE8-w")]
    [DisplayName("Event Notification")]
    [IsoXmlTag("EvtNtfctn")]
    public required EventNotificationData1 EventNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_jHeqZ4YCEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
