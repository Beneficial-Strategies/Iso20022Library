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
/// This record is an implementation of the caaa.007.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer.
/// </summary>
[Description(@"The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer.")]
[IsoId("_P6yMIap_EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Cancellation Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCancellationAdviceV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.007.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.007.001.06";
    
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
    /// Constructs a AcceptorCancellationAdviceV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCancellationAdviceV06( Header24 reqHeader,AcceptorCancellationAdvice6 reqCancellationAdvice )
    {
        Header = reqHeader;
        CancellationAdvice = reqCancellationAdvice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Cancellation advice message management information.
    /// </summary>
    [IsoId("_P6yMJap_EeanIZ10Ka8PnA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header24 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header24 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header24 Header { get; init; } 
    #else
    public Header24 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the cancellation advice.
    /// </summary>
    [IsoId("_P6yMJ6p_EeanIZ10Ka8PnA")]
    [DisplayName("Cancellation Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlAdvc")]
    #endif
    [IsoXmlTag("CxlAdvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCancellationAdvice6 CancellationAdvice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCancellationAdvice6 CancellationAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCancellationAdvice6 CancellationAdvice { get; init; } 
    #else
    public AcceptorCancellationAdvice6 CancellationAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_P6yMKap_EeanIZ10Ka8PnA")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcceptorCancellationAdviceV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceV06.

