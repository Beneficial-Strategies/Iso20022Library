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


namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MessageReject message is sent by a central system to notify the rejection of a previously received message.
/// Usage
/// The message provides specific information about the rejection reason.
/// </summary>
[Description(@"Scope|The MessageReject message is sent by a central system to notify the rejection of a previously received message.|Usage|The message provides specific information about the rejection reason.")]
[IsoId("_8LH5WNE9Ed-BzquC8wXy7w_-1942533103")]
[DisplayName("Message Reject V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageRejectV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "admi.002.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01";
    
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
    /// Constructs a MessageRejectV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageRejectV01( MessageReference reqRelatedReference,RejectionReason2 reqReason )
    {
        RelatedReference = reqRelatedReference;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the identification of the message previously received and for which the rejection is notified.
    /// </summary>
    [IsoId("_8LH5WdE9Ed-BzquC8wXy7w_-1383804009")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageReference RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageReference RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageReference RelatedReference { get; init; } 
    #else
    public MessageReference RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the reason of the message rejection.
    /// </summary>
    [IsoId("_8LH5WtE9Ed-BzquC8wXy7w_-223860119")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason2 Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReason2 Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason2 Reason { get; init; } 
    #else
    public RejectionReason2 Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MessageRejectV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MessageRejectV01.

