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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.085.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This IntraBalanceMovementPendingReport message is sent from a settlement infrastructure to an account owner/request to report the intra-balance movement instructions, previously sent by the account owner, that have a pending status.
/// 
/// The message may also be used to: 
/// -	re-send a message sent by the account owner to the account servicer (the sub-function of the message is &quot;Duplicate&quot;) 
/// -	provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy&quot;) 
/// -	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is &quot;Copy Duplicate&quot;).
/// </summary>
[Description(@"This IntraBalanceMovementPendingReport message is sent from a settlement infrastructure to an account owner/request to report the intra-balance movement instructions, previously sent by the account owner, that have a pending status.||The message may also be used to: |-	re-send a message sent by the account owner to the account servicer (the sub-function of the message is ""Duplicate"") |-	provide a third party with a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy"") |-	- re-send to a third party a copy of a message being sent by the account owner for information (the sub-function of the message is ""Copy Duplicate"").")]
[IsoId("_DLtLGzncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Pending Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalanceMovementPendingReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.085.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntPdgRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.085.001.01";
    
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
    /// Constructs a IntraBalanceMovementPendingReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraBalanceMovementPendingReportV01( Pagination1 reqPagination,IntraBalanceReport6 reqReportGeneralDetails,CashAccount38 reqCashAccount )
    {
        Pagination = reqPagination;
        ReportGeneralDetails = reqReportGeneralDetails;
        CashAccount = reqCashAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtLJzncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification51? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification51? Identification { get; init; } 
    #else
    public DocumentIdentification51? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DLtLKTncEem7JZMuWtwtsg")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 Pagination { get; init; } 
    #else
    public Pagination1 Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General characteristics related to the report information.
    /// </summary>
    [IsoId("_DLtLKzncEem7JZMuWtwtsg")]
    [DisplayName("Report General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptGnlDtls")]
    #endif
    [IsoXmlTag("RptGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraBalanceReport6 ReportGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraBalanceReport6 ReportGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalanceReport6 ReportGeneralDetails { get; init; } 
    #else
    public IntraBalanceReport6 ReportGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_DLtLLzncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount38 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38 CashAccount { get; init; } 
    #else
    public CashAccount38 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_DLtLLTncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctOwnr")]
    #endif
    [IsoXmlTag("CshAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    #else
    public SystemPartyIdentification8? CashAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_T4ON8Tp_EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctSvcr")]
    #endif
    [IsoXmlTag("CshAcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the intrabalance movement transactions.
    /// </summary>
    [IsoId("_DLtLMTncEem7JZMuWtwtsg")]
    [DisplayName("Movements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mvmnts")]
    #endif
    [IsoXmlTag("Mvmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntraBalancePending5? Movements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraBalancePending5? Movements { get; init; } 
    #else
    public IntraBalancePending5? Movements { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since IntraBalanceMovementPendingReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementPendingReportV01.

