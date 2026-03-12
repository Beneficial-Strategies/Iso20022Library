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
/// This record is an implementation of the semt.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent sends the AccountStatementOfHoldings message to the account owner, for example, a fund manager or an account owner&apos;s designated agent to provide detailed holdings of the portfolio at a specified moment in time.
/// The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// The message can be sent either audited or un-audited and may be provided on a trade date or settlement date basis.
/// Usage
/// The AccountingStatementOfHoldings message is used to provide valuation detail for each financial instrument held in a portfolio. The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.
/// This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at
/// - the main account level, or,
/// - the sub-account level.
/// This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// The AccountingStatementOfHoldings message should not be used for trading purposes.
/// </summary>
[Description(@"Scope|An account servicer, for example, a transfer agent sends the AccountStatementOfHoldings message to the account owner, for example, a fund manager or an account owner's designated agent to provide detailed holdings of the portfolio at a specified moment in time.|The message provides, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.|The message can be sent either audited or un-audited and may be provided on a trade date or settlement date basis.|Usage|The AccountingStatementOfHoldings message is used to provide valuation detail for each financial instrument held in a portfolio. The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.|This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at|- the main account level, or,|- the sub-account level.|This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|The AccountingStatementOfHoldings message should not be used for trading purposes.")]
[IsoId("_MbQI2NFSEd-BzquC8wXy7w_1168130771")]
[DisplayName("Accounting Statement Of Holdings V")]
public partial record AccountingStatementOfHoldingsV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.003.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctgStmtOfHldgsV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02";
    
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
    [IsoId("_MbQI2dFSEd-BzquC8wXy7w_2056557880")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MbQI2tFSEd-BzquC8wXy7w_1168130789")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MbQI29FSEd-BzquC8wXy7w_1168130832")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; } 
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MbQI3NFSEd-BzquC8wXy7w_1168131281")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// General information related to the accounting statement of holdings.
    /// </summary>
    [IsoId("_MbZSwNFSEd-BzquC8wXy7w_1168131221")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement6 StatementGeneralDetails { get; init; } 
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MbZSwdFSEd-BzquC8wXy7w_1168130866")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required SafekeepingAccount2 AccountDetails { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MbZSwtFSEd-BzquC8wXy7w_1168131109")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation3? BalanceForAccount { get; init; } 
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MbZSw9FSEd-BzquC8wXy7w_1168131144")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification3? SubAccountDetails { get; init; } 
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MbZSxNFSEd-BzquC8wXy7w_1168131179")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MbZSxdFSEd-BzquC8wXy7w_1168131264")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountingStatementOfHoldingsV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountingStatementOfHoldingsV02.

