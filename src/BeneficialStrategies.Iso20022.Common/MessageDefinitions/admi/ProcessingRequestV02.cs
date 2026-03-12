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
/// This record is an implementation of the admi.017.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Processing Request message is sent by a participant to a central system to request the initiation of a system process supported by a central system.
/// </summary>
[Description(@"The Processing Request message is sent by a participant to a central system to request the initiation of a system process supported by a central system.")]
[IsoId("_1MsY4QR4Ee29PP19jELcvQ")]
[DisplayName("Processing Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.017.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrcgReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.017.001.02";
    
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
    /// Constructs a ProcessingRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingRequestV02( System.String reqMessageIdentification,RequestDetails30 reqRequest )
    {
        MessageIdentification = reqMessageIdentification;
        Request = reqRequest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_1Ms_8QR4Ee29PP19jELcvQ")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_1Ms_8wR4Ee29PP19jELcvQ")]
    [DisplayName("Settlement Session Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSsnIdr")]
    #endif
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementSessionIdentifier { get; init; } 
    #else
    public System.String? SettlementSessionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the processing request.
    /// </summary>
    [IsoId("_1Ms_9QR4Ee29PP19jELcvQ")]
    [DisplayName("Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Req")]
    #endif
    [IsoXmlTag("Req")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestDetails30 Request { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestDetails30 Request { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestDetails30 Request { get; init; } 
    #else
    public RequestDetails30 Request { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_36KEsQR4Ee29PP19jELcvQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ProcessingRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ProcessingRequestV02.

