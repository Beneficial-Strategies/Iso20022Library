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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.005.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForAccountManagementStatusReport message is sent by an account owner, for example, an investor or its designated agent, to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to request the status of an AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction.
/// Usage
/// The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction message for which an AccountDetailsConfirmation message has not yet been received.
/// </summary>
[Description(@"Scope|The RequestForAccountManagementStatusReport message is sent by an account owner, for example, an investor or its designated agent, to the account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to request the status of an AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction.|Usage|The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction, GetAccountDetails or an AccountModificationInstruction message for which an AccountDetailsConfirmation message has not yet been received.")]
[IsoId("_rpQ9MZDiEem7fvtoGpNpow")]
[DisplayName("Request For Account Management Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestForAccountManagementStatusReportV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.005.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForAcctMgmtStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.005.001.06";
    
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
    /// Constructs a RequestForAccountManagementStatusReportV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestForAccountManagementStatusReportV06( MessageIdentification1 reqMessageIdentification,AccountManagementMessageReference5 reqRequestDetails )
    {
        MessageIdentification = reqMessageIdentification;
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_rpQ9M5DiEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account for which the status of the account management instruction is requested.
    /// </summary>
    [IsoId("_rpQ9NZDiEem7fvtoGpNpow")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementMessageReference5 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementMessageReference5 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementMessageReference5 RequestDetails { get; init; } 
    #else
    public AccountManagementMessageReference5 RequestDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RequestForAccountManagementStatusReportV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForAccountManagementStatusReportV06.

