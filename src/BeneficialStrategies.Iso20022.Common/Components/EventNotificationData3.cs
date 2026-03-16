// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the EventNotification message.
/// </summary>
[IsoId("_HxXH0S8SEeu125Ip9zFcsQ")]
[DisplayName("Event Notification Data")]
public record EventNotificationData3
{
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_H8uDQS8SEeu125Ip9zFcsQ")]
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent3 RetailerEvent { get; init; }

    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_H8uDQy8SEeu125Ip9zFcsQ")]
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; }

    /// <summary>
    /// Language of the Customer
    /// </summary>
    [IsoId("_H8uDRS8SEeu125Ip9zFcsQ")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// To display an event message
    /// </summary>
    [IsoId("_H8uDRy8SEeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage8? DisplayOutput { get; init; }
}
