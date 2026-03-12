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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.047.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureResponse message is sent in response to a shareholder identification disclosure request message by any intermediaries to the recipient designated by the issuer (such as an issuer&apos;s agent) in the disclosure request message in order to provide the requested information on the identity of the shareholders and their accounts holdings serviced by the intermediary for the requested financial instrument.
/// </summary>
[Description(@"The ShareholdersIdentificationDisclosureResponse message is sent in response to a shareholder identification disclosure request message by any intermediaries to the recipient designated by the issuer (such as an issuer's agent) in the disclosure request message in order to provide the requested information on the identity of the shareholders and their accounts holdings serviced by the intermediary for the requested financial instrument.")]
[IsoId("_9U3hhfEkEeqRfth943bvEA")]
[DisplayName("Shareholders Identification Disclosure Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShareholdersIdentificationDisclosureResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.047.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.047.001.02";
    
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
    /// Constructs a ShareholdersIdentificationDisclosureResponseV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShareholdersIdentificationDisclosureResponseV02( DisclosureRequestIdentification1 reqIssuerDisclosureRequestReference,System.String reqDisclosureResponseIdentification,PartyIdentification219 reqRespondingIntermediary,Disclosure2Choice_ reqDisclosureInformation )
    {
        IssuerDisclosureRequestReference = reqIssuerDisclosureRequestReference;
        DisclosureResponseIdentification = reqDisclosureResponseIdentification;
        RespondingIntermediary = reqRespondingIntermediary;
        DisclosureInformation = reqDisclosureInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the identification disclosure response, when split in several parts (messages), is to continue or that the message is the last page of the multi-part identification disclosure response.
    /// </summary>
    [IsoId("_9U3hjfEkEeqRfth943bvEA")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_9U3hj_EkEeqRfth943bvEA")]
    [DisplayName("Issuer Disclosure Request Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDsclsrReqRef")]
    #endif
    [IsoXmlTag("IssrDsclsrReqRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; } 
    #else
    public DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the disclosure response. The same disclosure response identification number is to be used when the response is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_9U3hkfEkEeqRfth943bvEA")]
    [DisplayName("Disclosure Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsclsrRspnId")]
    #endif
    [IsoXmlTag("DsclsrRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DisclosureResponseIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DisclosureResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DisclosureResponseIdentification { get; init; } 
    #else
    public System.String DisclosureResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_9U3hk_EkEeqRfth943bvEA")]
    [DisplayName("Responding Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspndgIntrmy")]
    #endif
    [IsoXmlTag("RspndgIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification219 RespondingIntermediary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification219 RespondingIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification219 RespondingIntermediary { get; init; } 
    #else
    public PartyIdentification219 RespondingIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed shareholding disclosure information or specifies that disclosure information is not provided.
    /// </summary>
    [IsoId("_9U3hlfEkEeqRfth943bvEA")]
    [DisplayName("Disclosure Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsclsrInf")]
    #endif
    [IsoXmlTag("DsclsrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Disclosure2Choice_ DisclosureInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Disclosure2Choice_ DisclosureInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Disclosure2Choice_ DisclosureInformation { get; init; } 
    #else
    public Disclosure2Choice_ DisclosureInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9U3hl_EkEeqRfth943bvEA")]
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


// Since ShareholdersIdentificationDisclosureResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholdersIdentificationDisclosureResponseV02.

