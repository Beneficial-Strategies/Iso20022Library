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
/// This record is an implementation of the acmt.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountManagementStatusReport message to an account owner or its designated agent, eg, an investor to report on the receipt or the processing status of a previously received AccountOpeningInstruction or AccountModificationInstruction or GetAccountDetails message.
/// Usage
/// The AccountManagementStatusReport message is used to provide the processing status of a previously received AccountOpeningInstruction or of an AccountModificationInstruction message.
/// The AccountManagementStatusReport message is also used by an account servicer to reject an AccountOpeningInstruction or AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified.
/// The account owner may report that the status of the instruction is either rejected, accepted, that the instruction is being processed or that the instruction has been forwarded to the next intermediary party for further processing.
/// </summary>
[Description(@"Scope|An account servicer, eg, a registrar, transfer agent or custodian bank sends the AccountManagementStatusReport message to an account owner or its designated agent, eg, an investor to report on the receipt or the processing status of a previously received AccountOpeningInstruction or AccountModificationInstruction or GetAccountDetails message.|Usage|The AccountManagementStatusReport message is used to provide the processing status of a previously received AccountOpeningInstruction or of an AccountModificationInstruction message.|The AccountManagementStatusReport message is also used by an account servicer to reject an AccountOpeningInstruction or AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified.|The account owner may report that the status of the instruction is either rejected, accepted, that the instruction is being processed or that the instruction has been forwarded to the next intermediary party for further processing.")]
[IsoId("_qp9IqNE9Ed-BzquC8wXy7w_6558662")]
[DisplayName("Account Management Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMgmtStsRptV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02";
    
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
    /// Constructs a AccountManagementStatusReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementStatusReportV02( MessageIdentification1 reqMessageIdentification,AccountManagementStatusAndReason1 reqStatusReport )
    {
        MessageIdentification = reqMessageIdentification;
        StatusReport = reqStatusReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_qqG5oNE9Ed-BzquC8wXy7w_-1412150000")]
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_qqG5odE9Ed-BzquC8wXy7w_1684015362")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Status report details of an account opening instruction or account modification instruction that was previously received.
    /// </summary>
    [IsoId("_qqG5otE9Ed-BzquC8wXy7w_200483730")]
    [DisplayName("Status Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRpt")]
    #endif
    [IsoXmlTag("StsRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementStatusAndReason1 StatusReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementStatusAndReason1 StatusReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementStatusAndReason1 StatusReport { get; init; } 
    #else
    public AccountManagementStatusAndReason1 StatusReport { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountManagementStatusReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountManagementStatusReportV02.

