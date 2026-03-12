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
/// This record is an implementation of the catp.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMWithdrawalResponse message is sent by an acquirer or its agent to an ATM in response to the ATMWithdrawalRequest to inform the ATM of the approval or decline of the withdrawal transaction.
/// </summary>
[Description(@"The ATMWithdrawalResponse message is sent by an acquirer or its agent to an ATM in response to the ATMWithdrawalRequest to inform the ATM of the approval or decline of the withdrawal transaction.")]
[IsoId("_q6Vxsa16EeWMg5rOByfExw")]
[DisplayName("ATM Withdrawal Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMWithdrawalResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMWdrwlRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.002.001.02";
    
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
    /// Constructs a ATMWithdrawalResponseV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMWithdrawalResponseV02( Header31 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_q6Vxs616EeWMg5rOByfExw")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header31 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header31 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header31 Header { get; init; } 
    #else
    public Header31 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_q6Vxta16EeWMg5rOByfExw")]
    [DisplayName("Protected ATM Withdrawal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMWdrwlRspn")]
    #endif
    [IsoXmlTag("PrtctdATMWdrwlRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMWithdrawalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMWithdrawalResponse { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMWithdrawalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of an ATM withdrawal transaction from an ATM manager.
    /// </summary>
    [IsoId("_q6Vxt616EeWMg5rOByfExw")]
    [DisplayName("ATM Withdrawal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMWdrwlRspn")]
    #endif
    [IsoXmlTag("ATMWdrwlRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMWithdrawalResponse2? ATMWithdrawalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMWithdrawalResponse2? ATMWithdrawalResponse { get; init; } 
    #else
    public ATMWithdrawalResponse2? ATMWithdrawalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_q6Vxua16EeWMg5rOByfExw")]
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


// Since ATMWithdrawalResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMWithdrawalResponseV02.

