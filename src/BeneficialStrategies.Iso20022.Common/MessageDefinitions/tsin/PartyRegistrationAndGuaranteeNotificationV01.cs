// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.tsin;

/// <summary>
/// This record is an implementation of the tsin.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PartyRegistrationAndGuaranteeNotification message is sent by a factoring client or a financial service to a trade partner and, optionally, to an interested party in order to notify the status of a requested financial service agreement. The trade partner is given information to explain the consequences of a financial service agreement, for instance, the trade partner must pay the financial institution and must use the electronic address to inform it and pay it using the bank account given.
/// The message may reference related messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Description(@"The PartyRegistrationAndGuaranteeNotification message is sent by a factoring client or a financial service to a trade partner and, optionally, to an interested party in order to notify the status of a requested financial service agreement. The trade partner is given information to explain the consequences of a financial service agreement, for instance, the trade partner must pay the financial institution and must use the electronic address to inform it and pay it using the bank account given.|The message may reference related messages and may include referenced data.|The message can carry digital signatures if required by context.")]
[IsoId("_OTgzNDg0-AOSNFX-8224506")]
[DisplayName("Party Registration And Guarantee Notification V")]
public partial record PartyRegistrationAndGuaranteeNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Set of characteristics that unambiguously identify the notification, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDg1-AOSNFX-8224506")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required BusinessLetter1 Header { get; init; } 
    
    /// <summary>
    /// List of otifications.
    /// </summary>
    [IsoId("_OTgzNDg2-AOSNFX-8224506")]
    [DisplayName("Notification List")]
    [IsoXmlTag("NtfctnList")]
    public required FinancingAgreementList1 NotificationList { get; init; } 
    
    /// <summary>
    /// Number of notification lists as control value.
    /// </summary>
    [IsoId("_OTgzNDg3-AOSNFX-8224506")]
    [DisplayName("Notification Count")]
    [IsoXmlTag("NtfctnCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NotificationCount { get; init; } 
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDg4-AOSNFX-8224506")]
    [DisplayName("Item Count")]
    [IsoXmlTag("ItmCnt")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? ItemCount { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDg5-AOSNFX-8224506")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; } 
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDkw-AOSNFX-8224506")]
    [DisplayName("Attached Message")]
    [IsoXmlTag("AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; } 
    
    
    #nullable disable
    
}


// Since PartyRegistrationAndGuaranteeNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyRegistrationAndGuaranteeNotificationV01.

