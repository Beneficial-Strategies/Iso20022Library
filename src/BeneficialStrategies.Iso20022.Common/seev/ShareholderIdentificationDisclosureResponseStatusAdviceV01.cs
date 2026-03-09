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
/// This record is an implementation of the seev.049.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer&apos;s agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.
/// Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report.
/// </summary>
[Description(@"The ShareholdersIdentificationDisclosureResponseStatusAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the intermediary in a custody chain in response to a ShareholderIdentificationDisclosureResponse message or in response to a multipart response report (sent with pagination in multiple messages) in order to report about the acceptance status of the received ShareholderIdentificationDisclosureResponse message/report.|Usage: when the shareholder identification disclosure response is sent in a multipart response report (with several messages), a single response status advice only may be sent for the acceptance status of the whole report.")]
[IsoId("_NCNMYHC5EemNhNOCZKENuw")]
[DisplayName("Shareholder Identification Disclosure Response Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShareholderIdentificationDisclosureResponseStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.049.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrIdDsclsrRspnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.049.001.01";
    
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
    /// Constructs a ShareholderIdentificationDisclosureResponseStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShareholderIdentificationDisclosureResponseStatusAdviceV01( System.String reqDisclosureResponseIdentification,DisclosureRequestIdentification1 reqIssuerDisclosureRequestReference,PartyIdentification215 reqRespondingIntermediary,ResponseProcessingStatus1Choice_ reqResponseReceptionStatus )
    {
        DisclosureResponseIdentification = reqDisclosureResponseIdentification;
        IssuerDisclosureRequestReference = reqIssuerDisclosureRequestReference;
        RespondingIntermediary = reqRespondingIntermediary;
        ResponseReceptionStatus = reqResponseReceptionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the disclosure response for which the status advice is sent.
    /// </summary>
    [IsoId("_9xsWBYd9EemJ1cSJJmVYRQ")]
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
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_Eq5WgbRBEem2T48lBgJbww")]
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
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_9xsWB4d9EemJ1cSJJmVYRQ")]
    [DisplayName("Responding Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspndgIntrmy")]
    #endif
    [IsoXmlTag("RspndgIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification215 RespondingIntermediary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification215 RespondingIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification215 RespondingIntermediary { get; init; } 
    #else
    public PartyIdentification215 RespondingIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptance status of the shareholder disclosure Identification Response message/report.
    /// </summary>
    [IsoId("_lGAS0IeSEemJ1cSJJmVYRQ")]
    [DisplayName("Response Reception Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRcptnSts")]
    #endif
    [IsoXmlTag("RspnRcptnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseProcessingStatus1Choice_ ResponseReceptionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseProcessingStatus1Choice_ ResponseReceptionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseProcessingStatus1Choice_ ResponseReceptionStatus { get; init; } 
    #else
    public ResponseProcessingStatus1Choice_ ResponseReceptionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-bsZoYebEemJ1cSJJmVYRQ")]
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


// Since ShareholderIdentificationDisclosureResponseStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholderIdentificationDisclosureResponseStatusAdviceV01.

