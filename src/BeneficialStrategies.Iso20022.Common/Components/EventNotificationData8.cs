// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies all information around an event notification.
/// </summary>
[IsoId("_I8-wAbZeEfCUZfsQO4rYeA")]
[DisplayName("Event Notification Data8")]
public record EventNotificationData8
{
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    [IsoId("_I94u9bZeEfCUZfsQO4rYeA")]
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent8 RetailerEvent { get; init; }

    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [IsoId("_I94u-7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; }

    /// <summary>
    /// Language of the Customer.
    /// </summary>
    [IsoId("_I94vAbZeEfCUZfsQO4rYeA")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// To display an event message.
    /// </summary>
    [IsoId("_I94vB7ZeEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }
}
