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
[IsoId("_vNo2IN6ZEeiwsev40qZGEQ")]
[DisplayName("Event Notification Data")]
public record EventNotificationData1
{
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_RT-CQN6aEeiwsev40qZGEQ")]
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent1 RetailerEvent { get; init; }

    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_OJ_usN6cEeiwsev40qZGEQ")]
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; }

    /// <summary>
    /// Language of the Customer
    /// </summary>
    [IsoId("_QdmJAN6cEeiwsev40qZGEQ")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// To display an event message
    /// </summary>
    [IsoId("_TLkyMN6cEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage6? DisplayOutput { get; init; }
}
