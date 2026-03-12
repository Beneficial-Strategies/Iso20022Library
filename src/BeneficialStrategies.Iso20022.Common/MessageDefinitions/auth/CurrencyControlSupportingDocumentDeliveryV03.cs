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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.025.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) in response to the supporting document request.
/// </summary>
[Description(@"The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) in response to the supporting document request.")]
[IsoId("_Nz8ayR3pEeuiRvbpCaJe6A")]
[DisplayName("Currency Control Supporting Document Delivery V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlSupportingDocumentDeliveryV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.025.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlSpprtgDocDlvry";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.025.001.03";
    
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
    /// Constructs a CurrencyControlSupportingDocumentDeliveryV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlSupportingDocumentDeliveryV03( CurrencyControlHeader5 reqGroupHeader,SupportingDocument3 reqSupportingDocument )
    {
        GroupHeader = reqGroupHeader;
        SupportingDocument = reqSupportingDocument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8ayx3pEeuiRvbpCaJe6A")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlHeader5 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyControlHeader5 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlHeader5 GroupHeader { get; init; } 
    #else
    public CurrencyControlHeader5 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the supporting document provided for the registered contract.
    /// </summary>
    [IsoId("_Nz8azR3pEeuiRvbpCaJe6A")]
    [DisplayName("Supporting Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtgDoc")]
    #endif
    [IsoXmlTag("SpprtgDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SupportingDocument3 SupportingDocument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SupportingDocument3 SupportingDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportingDocument3 SupportingDocument { get; init; } 
    #else
    public SupportingDocument3 SupportingDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8azx3pEeuiRvbpCaJe6A")]
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


// Since CurrencyControlSupportingDocumentDeliveryV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CurrencyControlSupportingDocumentDeliveryV03.

