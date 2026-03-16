// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Correspondence Notification1.
/// </summary>
[IsoId("_s8JQ4LksEe68nbz8Nl_hLQ")]
[DisplayName("Correspondence Notification1")]
public partial record CorrespondenceNotification1
{
    #nullable enable

    /// <summary>
    /// Enclosed File.
    /// </summary>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Notification Narrative.
    /// </summary>
    [DisplayName("Notification Narrative")]
    [IsoXmlTag("NtfctnNrrtv")]
    public ValueList<IsoMax2000Text> NotificationNarrative { get; init; } = [];

    /// <summary>
    /// Notification Sub Type.
    /// </summary>
    [DisplayName("Notification Sub Type")]
    [IsoXmlTag("NtfctnSubTp")]
    public NotificationSubType1Choice_? NotificationSubType { get; init; } 

    /// <summary>
    /// Notification Type.
    /// </summary>
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType1Choice_ NotificationType { get; init; } 

    /// <summary>
    /// Related Notification Data.
    /// </summary>
    [DisplayName("Related Notification Data")]
    [IsoXmlTag("RltdNtfctnData")]
    public ValueList<RelatedNotificationData1> RelatedNotificationData { get; init; } = [];

    /// <summary>
    /// Sender Notification Identification.
    /// </summary>
    [DisplayName("Sender Notification Identification")]
    [IsoXmlTag("SndrNtfctnId")]
    public required IsoMax35Text SenderNotificationIdentification { get; init; } 

    
    #nullable disable
    
}
