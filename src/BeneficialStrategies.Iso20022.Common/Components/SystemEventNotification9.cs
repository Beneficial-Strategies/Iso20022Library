// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data elements of a system event notification message.
/// </summary>
[IsoId("_MUIhYbYDEfCUZfsQO4rYeA")]
[DisplayName("System Event Notification9")]
public record SystemEventNotification9
{
    [IsoId("_MUIhYbYDEfCUZfsQO4rYeA-env")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    [IsoId("_MUIhYbYDEfCUZfsQO4rYeA-ctx")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    [IsoId("_MUIhYbYDEfCUZfsQO4rYeA-ntf")]
    [DisplayName("Event Notification")]
    [IsoXmlTag("EvtNtfctn")]
    public required EventNotificationData8 EventNotification { get; init; }

    [IsoId("_MUIhYbYDEfCUZfsQO4rYeA-sup")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
