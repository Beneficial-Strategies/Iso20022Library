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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.
/// Usage
/// The RequestForTransferStatusReport is used to request either:
/// - the status of one or several transfer instructions or,
/// - the status of one or several transfer cancellation instructions.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RequestForTransferStatusReport to the executing party, for example, a transfer agent to request the status of a previously instructed transfer.|Usage|The RequestForTransferStatusReport is used to request either:|- the status of one or several transfer instructions or,|- the status of one or several transfer cancellation instructions.")]
[IsoId("__iaEofpbEeCPwaG9zjUPNQ")]
[DisplayName("Request For Transfer Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForTransferStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.009.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForTrfStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.009.001.03";
    
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
    /// Constructs a RequestForTransferStatusReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForTransferStatusReportV03( MessageIdentification1 reqMessageIdentification,MessageAndBusinessReference6 reqRequestDetails )
    {
        MessageIdentification = reqMessageIdentification;
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("__iaEpfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information to identify the transfer for which the status is requested.|.
    /// </summary>
    [IsoId("__iaEqfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageAndBusinessReference6 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageAndBusinessReference6 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageAndBusinessReference6 RequestDetails { get; init; } 
    #else
    public MessageAndBusinessReference6 RequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("__iaErfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RequestForTransferStatusReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForTransferStatusReportV03.

