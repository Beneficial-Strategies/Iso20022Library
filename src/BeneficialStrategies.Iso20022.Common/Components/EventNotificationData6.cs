// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event Notification Data6.
/// </summary>
[IsoId("_8bxcwZN-Ee6im_tx3Nh8SA")]
[DisplayName("Event Notification Data6")]
public partial record EventNotificationData6
{
    #nullable enable

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

    
    #nullable disable
    
}
