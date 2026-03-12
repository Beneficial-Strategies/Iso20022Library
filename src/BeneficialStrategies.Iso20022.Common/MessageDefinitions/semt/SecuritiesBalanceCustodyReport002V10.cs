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
/// This record is an implementation of the semt.002.002.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.
/// 
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants, or
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer, or
/// - a transfer agent acting on behalf of a fund manager or an account owner&apos;s designated agent.
/// 
/// Usage
/// The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. 
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. 
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
/// 
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. |The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. |There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
[IsoId("_uLWKQ_fVEeiNZp_PtLohLw")]
[DisplayName("Securities Balance Custody Report 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesBalanceCustodyReport002V10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.002.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalCtdyRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.002.10";
    
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
    /// Constructs a SecuritiesBalanceCustodyReport002V10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesBalanceCustodyReport002V10( Pagination1 reqPagination,Statement77 reqStatementGeneralDetails,SecuritiesAccount33 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_uLWKTffVEeiNZp_PtLohLw")]
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
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_uLWKT_fVEeiNZp_PtLohLw")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement77 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement77 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement77 StatementGeneralDetails { get; init; } 
    #else
    public Statement77 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_uLWKUffVEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification156? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification156? AccountOwner { get; init; } 
    #else
    public PartyIdentification156? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_uLWKU_fVEeiNZp_PtLohLw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification157? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification157? AccountServicer { get; init; } 
    #else
    public PartyIdentification157? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_uLWKVffVEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount33 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount33 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount33 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount33 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_uLWKV_fVEeiNZp_PtLohLw")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary45> IntermediaryInformation { get; init; } = new ValueList<Intermediary45>(){};
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_uLWKWffVEeiNZp_PtLohLw")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateBalanceInformation39? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateBalanceInformation39? BalanceForAccount { get; init; } 
    #else
    public AggregateBalanceInformation39? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_uLWKW_fVEeiNZp_PtLohLw")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccountIdentification58? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccountIdentification58? SubAccountDetails { get; init; } 
    #else
    public SubAccountIdentification58? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_uLWKXffVEeiNZp_PtLohLw")]
    [DisplayName("Account Base Currency Total Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBaseCcyTtlAmts")]
    #endif
    [IsoXmlTag("AcctBaseCcyTtlAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalValueInPageAndStatement3? AccountBaseCurrencyTotalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalValueInPageAndStatement3? AccountBaseCurrencyTotalAmounts { get; init; } 
    #else
    public TotalValueInPageAndStatement3? AccountBaseCurrencyTotalAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SecuritiesBalanceCustodyReport002V10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceCustodyReport002V10.

