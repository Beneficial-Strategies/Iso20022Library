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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of a proposed amendment to the undertaking (issued electronically or on paper). The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to providing the proposed terms of the amendment and details on proposed changes to the undertaking, the message may provide other supporting information from the sender. It may also be used to notify the proposed termination or cancellation of the undertaking.
/// </summary>
[Description(@"The UndertakingAmendmentNotification message is sent by the party that issued the undertaking to the applicant to notify it of the contents of a proposed amendment to the undertaking (issued electronically or on paper). The undertaking could be a demand guarantee, standby letter of credit, counter-undertaking (counter-guarantee or counter-standby), or suretyship undertaking. In addition to providing the proposed terms of the amendment and details on proposed changes to the undertaking, the message may provide other supporting information from the sender. It may also be used to notify the proposed termination or cancellation of the undertaking.")]
[IsoId("_9g6LUnltEeG7BsjMvd1mEw_1297611038")]
[DisplayName("Undertaking Amendment Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmendmentNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmendmentNotificationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmendmentNotificationV01( Amendment6 reqUndertakingAmendmentNotificationDetails )
    {
        UndertakingAmendmentNotificationDetails = reqUndertakingAmendmentNotificationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the notification of the proposed amended undertaking.
    /// </summary>
    [IsoId("_9g6LU3ltEeG7BsjMvd1mEw_1612122638")]
    [DisplayName("Undertaking Amendment Notification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmdmntNtfctnDtls")]
    #endif
    [IsoXmlTag("UdrtkgAmdmntNtfctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amendment6 UndertakingAmendmentNotificationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amendment6 UndertakingAmendmentNotificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amendment6 UndertakingAmendmentNotificationDetails { get; init; } 
    #else
    public Amendment6 UndertakingAmendmentNotificationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9g6LVHltEeG7BsjMvd1mEw_1241284917")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since UndertakingAmendmentNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentNotificationV01.

