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


namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorReconciliationRequest message is sent by the card acceptor to the acquirer or an agent to communicate the totals of the card payment transaction for a reconciliation period. An agent never forwards the message.
/// Usage
/// The AcceptorReconciliationRequest message is used to ensure that the debits and credits correspond to the balances computed by the acquirer or its agent for the same reconciliation period.
/// The AcceptorReconciliationRequest message is also used to close a reconciliation period.
/// </summary>
[Description(@"Scope|The AcceptorReconciliationRequest message is sent by the card acceptor to the acquirer or an agent to communicate the totals of the card payment transaction for a reconciliation period. An agent never forwards the message.|Usage|The AcceptorReconciliationRequest message is used to ensure that the debits and credits correspond to the balances computed by the acquirer or its agent for the same reconciliation period.|The AcceptorReconciliationRequest message is also used to close a reconciliation period.")]
[IsoId("_PNo5FaMVEeCJ6YNENx4h-w_-594784238")]
[DisplayName("Acceptor Reconciliation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorReconciliationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.009.001.01";
    
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
    /// Constructs a AcceptorReconciliationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorReconciliationRequestV01( Header1 reqHeader,AcceptorReconciliationRequest1 reqReconciliationRequest,ContentInformationType3 reqSecurityTrailer )
    {
        Header = reqHeader;
        ReconciliationRequest = reqReconciliationRequest;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reconciliation request message management information.
    /// </summary>
    [IsoId("_PNo5FqMVEeCJ6YNENx4h-w_734688010")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header1 Header { get; init; } 
    #else
    public Header1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the reconcilliation request.
    /// </summary>
    [IsoId("_PNo5F6MVEeCJ6YNENx4h-w_-572887118")]
    [DisplayName("Reconciliation Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnReq")]
    #endif
    [IsoXmlTag("RcncltnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorReconciliationRequest1 ReconciliationRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorReconciliationRequest1 ReconciliationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorReconciliationRequest1 ReconciliationRequest { get; init; } 
    #else
    public AcceptorReconciliationRequest1 ReconciliationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_PNyDAKMVEeCJ6YNENx4h-w_654221226")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType3 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType3 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcceptorReconciliationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorReconciliationRequestV01.

