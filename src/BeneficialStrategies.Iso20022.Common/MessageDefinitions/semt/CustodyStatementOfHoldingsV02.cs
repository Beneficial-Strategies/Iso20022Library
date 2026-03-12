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
/// This record is an implementation of the semt.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent sends the CustodyStatementOfHoldings message to the account owner, for example, a fund manager or an account owner&apos;s designated agent to provide detailed holdings of the portfolio at a specified moment in time.
/// The message provides, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner. The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues.
/// The message reports all information per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided.
/// Usage
/// The CustodyStatementOfHoldings message is used to provide detailed quantity and availability information for financial instrument holdings of a portfolio. The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.
/// This message can be also be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.
/// The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at
/// - the main account level, or,
/// - the sub-account level.
/// </summary>
[Description(@"Scope|An account servicer, for example, a transfer agent sends the CustodyStatementOfHoldings message to the account owner, for example, a fund manager or an account owner's designated agent to provide detailed holdings of the portfolio at a specified moment in time.|The message provides, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner. The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues.|The message reports all information per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided.|Usage|The CustodyStatementOfHoldings message is used to provide detailed quantity and availability information for financial instrument holdings of a portfolio. The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.|This message can be also be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.|The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at|- the main account level, or,|- the sub-account level.")]
[IsoId("_Magh_dFSEd-BzquC8wXy7w_1153922186")]
[DisplayName("Custody Statement Of Holdings V")]
public partial record CustodyStatementOfHoldingsV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtdyStmtOfHldgsV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.02";
    
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
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Magh_tFSEd-BzquC8wXy7w_-51538454")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Magh_9FSEd-BzquC8wXy7w_1153922222")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Mapr4NFSEd-BzquC8wXy7w_1153922204")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_Mapr4dFSEd-BzquC8wXy7w_1153922479")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// General information related to the custody statement of holdings.
    /// </summary>
    [IsoId("_Mapr4tFSEd-BzquC8wXy7w_1153922264")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement7 StatementGeneralDetails { get; init; } 
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_Mapr49FSEd-BzquC8wXy7w_1153922307")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount2 AccountDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_Mapr5NFSEd-BzquC8wXy7w_1153922402")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation4? BalanceForAccount { get; init; } 
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_Mapr5dFSEd-BzquC8wXy7w_1153922324")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification5? SubAccountDetails { get; init; } 
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_Mapr5tFSEd-BzquC8wXy7w_1153922359")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Mapr59FSEd-BzquC8wXy7w_1153922437")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since CustodyStatementOfHoldingsV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustodyStatementOfHoldingsV02.

