// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a party that notifies a financial document, the party to be notified, and whether notified party must send an acknowledgement and to whom.
/// </summary>
[IsoId("_OTgzMzMw-AOSNFX-8224500")]
[DisplayName("Financing Notification Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingNotificationParties1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingNotificationParties1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingNotificationParties1( QualifiedPartyIdentification1 reqNotifyingParty,QualifiedPartyIdentification1 reqNotificationReceiver )
    {
        NotifyingParty = reqNotifyingParty;
        NotificationReceiver = reqNotificationReceiver;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that notifies a third party.
    /// </summary>
    [IsoId("_OTMxOTcy-AOSNFX-0262747")]
    [DisplayName("Notifying Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtifngPty")]
    #endif
    [IsoXmlTag("NtifngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 NotifyingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 NotifyingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 NotifyingParty { get; init; } 
    #else
    public QualifiedPartyIdentification1 NotifyingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party (to be) notified.
    /// </summary>
    [IsoId("_OTMxOTcz-AOSNFX-0262747")]
    [DisplayName("Notification Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnRcvr")]
    #endif
    [IsoXmlTag("NtfctnRcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QualifiedPartyIdentification1 NotificationReceiver { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QualifiedPartyIdentification1 NotificationReceiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1 NotificationReceiver { get; init; } 
    #else
    public QualifiedPartyIdentification1 NotificationReceiver { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom a notification acknowledgement has to be sent by the notification receiver.
    /// </summary>
    [IsoId("_OTMxOTc0-AOSNFX-0262747")]
    [DisplayName("Acknowledgement Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckRcvr")]
    #endif
    [IsoXmlTag("AckRcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? AcknowledgementReceiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? AcknowledgementReceiver { get; init; } 
    #else
    public QualifiedPartyIdentification1? AcknowledgementReceiver { get; set; } 
    #endif
    
    
    #nullable disable
    
}
