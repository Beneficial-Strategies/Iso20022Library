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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.060.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant&apos;s netting cut off held at the central system.
/// </summary>
[Description(@"The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant's netting cut off held at the central system.")]
[IsoId("_CYWUEJVFEeaYkf5FCqYMeA")]
[DisplayName("Netting Cut Off Reference Data Update Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NettingCutOffReferenceDataUpdateRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.060.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataUpdReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.060.001.01";
    
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
    /// Constructs a NettingCutOffReferenceDataUpdateRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NettingCutOffReferenceDataUpdateRequestV01( RequestData1 reqRequestData,NettingCutOff1 reqNettingCutOffRequest )
    {
        RequestData = reqRequestData;
        NettingCutOffRequest = reqNettingCutOffRequest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the meta data for the netting cut off update request.
    /// </summary>
    [IsoId("_5WY5cJVGEeaYkf5FCqYMeA")]
    [DisplayName("Request Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqData")]
    #endif
    [IsoXmlTag("ReqData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestData1 RequestData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestData1 RequestData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestData1 RequestData { get; init; } 
    #else
    public RequestData1 RequestData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information regarding the changes to the netting cut off.
    /// </summary>
    [IsoId("_-cihoJVLEeaYkf5FCqYMeA")]
    [DisplayName("Netting Cut Off Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgCutOffReq")]
    #endif
    [IsoXmlTag("NetgCutOffReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingCutOff1 NettingCutOffRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingCutOff1 NettingCutOffRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingCutOff1 NettingCutOffRequest { get; init; } 
    #else
    public NettingCutOff1 NettingCutOffRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Yna6IJVMEeaYkf5FCqYMeA")]
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


// Since NettingCutOffReferenceDataUpdateRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NettingCutOffReferenceDataUpdateRequestV01.

