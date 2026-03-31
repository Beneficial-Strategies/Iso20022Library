// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a party that notifies a financial document, the party to be notified, and whether notified party must send an acknowledgement and to whom.
/// </summary>
[IsoId("_OTgzMzMw-AOSNFX-8224500")]
[DisplayName("Financing Notification Parties")]
public record FinancingNotificationParties1
{
    /// <summary>
    /// Party that notifies a third party.
    /// </summary>
    [IsoId("_OTMxOTcy-AOSNFX-0262747")]
    [DisplayName("Notifying Party")]
    [IsoXmlTag("NtifngPty")]
    public required QualifiedPartyIdentification1 NotifyingParty { get; init; }

    /// <summary>
    /// Party (to be) notified.
    /// </summary>
    [IsoId("_OTMxOTcz-AOSNFX-0262747")]
    [DisplayName("Notification Receiver")]
    [IsoXmlTag("NtfctnRcvr")]
    public required QualifiedPartyIdentification1 NotificationReceiver { get; init; }

    /// <summary>
    /// Party to whom a notification acknowledgement has to be sent by the notification receiver.
    /// </summary>
    [IsoId("_OTMxOTc0-AOSNFX-0262747")]
    [DisplayName("Acknowledgement Receiver")]
    [IsoXmlTag("AckRcvr")]
    public ValueList<QualifiedPartyIdentification1> AcknowledgementReceiver { get; init; } = [];
}
