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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.041.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// 
/// An account servicer, such as a custodian, central securities depository or international central securities depository, sends the SecuritiesBalanceTransparencyReport message to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.
/// 
/// The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.
/// 
/// USAGE
/// 
/// The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.
/// 
/// A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer. 
/// 
/// When the receiver of the SecuritiesBalanceTransparencyReport message is also an account servicer, it may, in turn, send a statement back to the sender of the first statement, enriched with data of its own.
/// Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account in the shareholder register.
/// </summary>
[Description(@"SCOPE||An account servicer, such as a custodian, central securities depository or international central securities depository, sends the SecuritiesBalanceTransparencyReport message to provide holdings information for the accounts that it services, to disclose underlying details of holdings on an omnibus account that the sender owns or operates at the receiver. The receiver may also be a custodian, central securities depository, international central securities depository, and the ultimate receiver may be a registrar, transfer agent, fund company, official agent of the reported instrument(s) and/or other parties.||The SecuritiesBalanceTransparencyReport message provides transparency of holdings through layers of custody chains in a consolidated statement, to allow for an efficient gathering of investor data, which, in turn, may be used to measure marketing effectiveness, validation of compliance with prospectuses and regulatory requirements, and the calculation of trailer fees and other retrocessions.||USAGE||The SecuritiesBalanceTransparencyReport message is used to provide aggregated holdings information and a breakdown of holdings information.||A sender of the SecuritiesBalanceTransparencyReport message will identify its own safekeeping account (for example, an omnibus account in the ledger of the receiver) and holdings information at the level of account(s) for which the sender is the account servicer (that is, in the ledger of the sender). When relevant, the sender will aggregate its holdings information with holdings information of one or more sub levels and sub-sub levels of accounts, that is, with holdings information the sender has received from the owner(s) of the account(s) for which the sender is the account servicer. ||When the receiver of the SecuritiesBalanceTransparencyReport message is also an account servicer, it may, in turn, send a statement back to the sender of the first statement, enriched with data of its own.|Ultimately, the statement reaches the relevant fund company, for example, the transfer agent, that may use it for obtaining information about the custodians, distributors and commercial agreement references associated with holdings on an omnibus account in the shareholder register.")]
[IsoId("_xPhF4Ig7EeO9_8n7Pjtlag")]
[DisplayName("Securities Balance Transparency Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesBalanceTransparencyReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.041.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalTrnsprncyRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.041.001.01";
    
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
    /// Constructs a SecuritiesBalanceTransparencyReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesBalanceTransparencyReportV01( MessageIdentification1 reqMessageIdentification,PartyIdentification100 reqSenderIdentification,Pagination reqPagination,Statement37 reqStatementGeneralDetails,SafekeepingAccount5 reqSafekeepingAccountAndHoldings )
    {
        MessageIdentification = reqMessageIdentification;
        SenderIdentification = reqSenderIdentification;
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        SafekeepingAccountAndHoldings = reqSafekeepingAccountAndHoldings;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the message. When the report has multiple pages, one message equals one page. Therefore, the MessageIdentification uniquely identifies the page.
    /// </summary>
    [IsoId("_tOXzJYjUEeONZKAAW4pOaQ")]
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
    /// Identification of the party that is the sender of the message.
    /// </summary>
    [IsoId("_tOXzJojUEeONZKAAW4pOaQ")]
    [DisplayName("Sender Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrId")]
    #endif
    [IsoXmlTag("SndrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 SenderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification100 SenderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 SenderIdentification { get; init; } 
    #else
    public PartyIdentification100 SenderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that is the receiver of the message.
    /// </summary>
    [IsoId("_tOXzJ4jUEeONZKAAW4pOaQ")]
    [DisplayName("Receiver Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrId")]
    #endif
    [IsoXmlTag("RcvrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? ReceiverIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? ReceiverIdentification { get; init; } 
    #else
    public PartyIdentification100? ReceiverIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_7HiiYIjUEeONZKAAW4pOaQ")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general information on the statement.
    /// </summary>
    [IsoId("_tOXzKIjUEeONZKAAW4pOaQ")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement37 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement37 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement37 StatementGeneralDetails { get; init; } 
    #else
    public Statement37 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the account, account sub-levels and the holdings.
    /// </summary>
    [IsoId("_tOXzKYjUEeONZKAAW4pOaQ")]
    [DisplayName("Safekeeping Account And Holdings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcctAndHldgs")]
    #endif
    [IsoXmlTag("SfkpgAcctAndHldgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount5 SafekeepingAccountAndHoldings { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount5 SafekeepingAccountAndHoldings { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount5 SafekeepingAccountAndHoldings { get; init; } 
    #else
    public SafekeepingAccount5 SafekeepingAccountAndHoldings { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JnQCkVLbEeSGm-QRrvBvYg")]
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


// Since SecuritiesBalanceTransparencyReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceTransparencyReportV01.

