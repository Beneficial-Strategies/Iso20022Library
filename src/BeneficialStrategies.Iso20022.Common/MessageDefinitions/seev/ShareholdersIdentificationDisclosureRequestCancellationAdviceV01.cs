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
/// This record is an implementation of the seev.046.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureCancellationAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer&apos;s agent) to the first intermediaries in a custody chain or is sent by any intermediaries in  a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to withdraw/cancel the disclosure request of shareholders identity previously sent.
/// </summary>
[Description(@"The ShareholdersIdentificationDisclosureCancellationAdvice message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in  a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to withdraw/cancel the disclosure request of shareholders identity previously sent.")]
[IsoId("_mKzuYDnYEemL_ewJY9QP1g")]
[DisplayName("Shareholders Identification Disclosure Request Cancellation Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShareholdersIdentificationDisclosureRequestCancellationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.046.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReqCxlAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.046.001.01";
    
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
    /// Constructs a ShareholdersIdentificationDisclosureRequestCancellationAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShareholdersIdentificationDisclosureRequestCancellationAdviceV01( DisclosureRequestIdentification1 reqIssuerDisclosureRequestReference )
    {
        IssuerDisclosureRequestReference = reqIssuerDisclosureRequestReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_Yk74gbRAEem2T48lBgJbww")]
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
    /// Provides the reason for cancelling the request for shareholders identification disclosure.
    /// </summary>
    [IsoId("_L7L5YDqUEemL_ewJY9QP1g")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisclosureRequestCancellationReason1Code? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisclosureRequestCancellationReason1Code? CancellationReason { get; init; } 
    #else
    public DisclosureRequestCancellationReason1Code? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_OBOqxzqSEemL_ewJY9QP1g")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification129Choice_? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_FGPFkT6LEemPvNTzinB5Vw")]
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


// Since ShareholdersIdentificationDisclosureRequestCancellationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholdersIdentificationDisclosureRequestCancellationAdviceV01.

