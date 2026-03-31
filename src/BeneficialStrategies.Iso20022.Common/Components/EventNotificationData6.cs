// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event Notification Data6.
/// </summary>
[IsoId("_8bxcwZN-Ee6im_tx3Nh8SA")]
[DisplayName("Event Notification Data6")]
public record EventNotificationData6
{
    /// <summary>
    /// Customer Language.
    /// </summary>
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; }

    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; }

    /// <summary>
    /// Maintenance Required Flag.
    /// </summary>
    [DisplayName("Maintenance Required Flag")]
    [IsoXmlTag("MntncReqrdFlg")]
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; }

    /// <summary>
    /// Retailer Event.
    /// </summary>
    [DisplayName("Retailer Event")]
    [IsoXmlTag("RtlrEvt")]
    public required RetailerEvent6 RetailerEvent { get; init; }
}
