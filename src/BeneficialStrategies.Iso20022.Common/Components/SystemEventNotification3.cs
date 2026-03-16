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
[IsoId("_7jfqcQ1TEeqjM-rxn3HuXQ")]
[DisplayName("System Event Notification")]
public record SystemEventNotification3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_7vISsQ1TEeqjM-rxn3HuXQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_7vISsw1TEeqjM-rxn3HuXQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Content of the EventNotification message.
    /// </summary>
    [IsoId("_7vIStQ1TEeqjM-rxn3HuXQ")]
    [DisplayName("Event Notification")]
    [IsoXmlTag("EvtNtfctn")]
    public required EventNotificationData2 EventNotification { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_7vIStw1TEeqjM-rxn3HuXQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
