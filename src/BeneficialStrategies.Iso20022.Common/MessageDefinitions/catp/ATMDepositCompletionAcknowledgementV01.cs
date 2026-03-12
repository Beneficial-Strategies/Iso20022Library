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


namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDepositCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMDepositCompletionAdvice message.
/// </summary>
[Description(@"The ATMDepositCompletionAcknowledgement message is sent by an acquirer or its agent to an ATM to acknowledge the receipt of an ATMDepositCompletionAdvice message.")]
[IsoId("_YEXqoK4REeWZgJQOa6iKCQ")]
[DisplayName("ATM Deposit Completion Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDepositCompletionAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDpstCmpltnAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.015.001.01";
    
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
    /// Constructs a ATMDepositCompletionAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDepositCompletionAcknowledgementV01( Header32 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_ho578K4REeWZgJQOa6iKCQ")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header32 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header32 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header32 Header { get; init; } 
    #else
    public Header32 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_mHoKAK4REeWZgJQOa6iKCQ")]
    [DisplayName("Protected ATM Deposit Completion Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMDpstCmpltnAck")]
    #endif
    [IsoXmlTag("PrtctdATMDpstCmpltnAck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMDepositCompletionAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMDepositCompletionAcknowledgement { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMDepositCompletionAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the acknowledgement of an ATM deposit transaction from the ATM manager.
    /// </summary>
    [IsoId("_qZQXQK4REeWZgJQOa6iKCQ")]
    [DisplayName("ATM Deposit Completion Acknowledgement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMDpstCmpltnAck")]
    #endif
    [IsoXmlTag("ATMDpstCmpltnAck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDepositCompletionAcknowledgement1? ATMDepositCompletionAcknowledgement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDepositCompletionAcknowledgement1? ATMDepositCompletionAcknowledgement { get; init; } 
    #else
    public ATMDepositCompletionAcknowledgement1? ATMDepositCompletionAcknowledgement { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_DgzqgK4SEeWZgJQOa6iKCQ")]
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


// Since ATMDepositCompletionAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDepositCompletionAcknowledgementV01.

