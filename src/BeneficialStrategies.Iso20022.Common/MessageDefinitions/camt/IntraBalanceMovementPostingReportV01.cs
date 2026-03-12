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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.084.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This IntraBalanceMovementPostingReport message is sent from a settlement infrastructure to an account owner/requestor to report the intra-balance movement instructions, previously sent by the account owner, that have a settled status.
/// 
/// The message may also be used to: 
/// -	- re-send a message sent by the account owner to the account servicer (the sub-function of the message is &quot;Duplicate&quot;) 
/// -	- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy&quot;) 
/// -	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy Duplicate&quot;).
/// 
/// </summary>
[Description(@"This IntraBalanceMovementPostingReport message is sent from a settlement infrastructure to an account owner/requestor to report the intra-balance movement instructions, previously sent by the account owner, that have a settled status.||The message may also be used to: |-	- re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |-	- provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |-	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").|")]
[IsoId("_DLtLMzncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Posting Report V")]
public partial record IntraBalanceMovementPostingReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.084.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntPstngRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.084.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtLPzncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DLtLQTncEem7JZMuWtwtsg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// General characteristics related to the report information.
    /// </summary>
    [IsoId("_DLtLQzncEem7JZMuWtwtsg")]
    [DisplayName("Report General Details")]
    [IsoXmlTag("RptGnlDtls")]
    public required IntraBalanceReport6 ReportGeneralDetails { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_DLtLRzncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount38 CashAccount { get; init; } 
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_DLtLRTncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_xVL3sTp-EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    
    /// <summary>
    /// Identifies the transactions.
    /// </summary>
    [IsoId("_DLtLSTncEem7JZMuWtwtsg")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public IntraBalancePosting5? SubBalance { get; init; } 
    
    
    #nullable disable
    
}


// Since IntraBalanceMovementPostingReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementPostingReportV01.

