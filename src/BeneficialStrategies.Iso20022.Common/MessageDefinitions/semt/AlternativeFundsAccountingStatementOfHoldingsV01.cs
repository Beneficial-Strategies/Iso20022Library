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



namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent or administrator, sends the AlternativeFundsAccountingStatementOfHoldings message to the account owner, for example, an investment manager, custodian, fund manager or an account owner&apos;s designated agent, to provide detailed holdings of the portfolio at a specified moment in time.
/// There may be one or more parties between the account servicer and the account owner.
/// The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// Usage
/// The AlternativeFundsAccountingStatementOfHoldings message is sent by the account servicer to the account owner:
/// - at a frequency agreed bilaterally between the account servicer and the account owner,
/// - as a response to a request for statement sent by the account owner.
/// </summary>
[Description(@"Scope|An account servicer, for example, a transfer agent or administrator, sends the AlternativeFundsAccountingStatementOfHoldings message to the account owner, for example, an investment manager, custodian, fund manager or an account owner's designated agent, to provide detailed holdings of the portfolio at a specified moment in time.|There may be one or more parties between the account servicer and the account owner.|The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.|Usage|The AlternativeFundsAccountingStatementOfHoldings message is sent by the account servicer to the account owner:|- at a frequency agreed bilaterally between the account servicer and the account owner,|- as a response to a request for statement sent by the account owner.")]
[IsoId("_MeFaZtFSEd-BzquC8wXy7w_-255037867")]
[DisplayName("Alternative Funds Accounting Statement Of Holdings V")]
public partial record AlternativeFundsAccountingStatementOfHoldingsV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AltrntvFndsAcctgStmtOfHldgs";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.012.001.01";
    
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
    /// Reference that uniquely identifies a message from a technical application standpoint.
    /// </summary>
    [IsoId("_MeFaZ9FSEd-BzquC8wXy7w_-1816902269")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MeFaaNFSEd-BzquC8wXy7w_-1627236244")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference4? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MeFaadFSEd-BzquC8wXy7w_1666808091")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference4> RelatedReference { get; init; } = [];
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MeFaatFSEd-BzquC8wXy7w_1676967953")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MeFaa9FSEd-BzquC8wXy7w_792258549")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount30 InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// General information related to the hedge fund accounting statement of holdings.|.
    /// </summary>
    [IsoId("_MeOkUNFSEd-BzquC8wXy7w_-1677323565")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement10 StatementGeneralDetails { get; init; } 
    
    /// <summary>
    /// Party that provides services to investors relating to financial products.
    /// </summary>
    [IsoId("_MeOkUdFSEd-BzquC8wXy7w_2081162206")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary17> RelatedPartyDetails { get; init; } = [];
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MeOkUtFSEd-BzquC8wXy7w_433316011")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation5? BalanceForAccount { get; init; } 
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MeOkU9FSEd-BzquC8wXy7w_46360620")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MeOkVNFSEd-BzquC8wXy7w_-108817498")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AlternativeFundsAccountingStatementOfHoldingsV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AlternativeFundsAccountingStatementOfHoldingsV01.

