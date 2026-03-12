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
/// This record is an implementation of the camt.004.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The ReturnAccount message is sent by the transaction administrator to a member.|It is used to provide information on the details of one or more accounts held at the transaction administrator, including information on the balances.|The Return Account message can be sent as a response to a related GetAccount message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the account(s) that the transaction administrator maintains for the member.|For example, this may be necessary in order to perform the appropriate liquidity management and the necessary funds transfers between accounts.|The member can request information about accounts through a series of criteria, corresponding to the known information stored at the transaction administrator.|The query can concern one or more specific accounts, accounts of a particular identification, or a particular type. The purpose of the query may be to obtain one or more types of balance.|The transaction administrator may also send a ReturnAccount message with pre-defined information, at times previously agreed with the member, or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information based on the following elements: |- account identification|- account name|- account type (this is used when the account identification represents, for example, a group of accounts)|- currency of the account (this is used for example when the account identification represents a group of account in various currencies, or when it is a multi-currency account with one single identifier)|- type of balance (if not present in the GetAccount message, all balances will be reported)|- bilateral or multilateral limits|- related counterparty (when the limit or balance is bilateral)|- balance value date (if not present in the GetAccount message, the ReturnAccount message will contain the latest available balance)|- number of payments to the additional account information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The ReturnAccount message is sent by the transaction administrator to a member.|It is used to provide information on the details of one or more accounts held at the transaction administrator, including information on the balances.|The Return Account message can be sent as a response to a related GetAccount message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the account(s) that the transaction administrator maintains for the member.|For example, this may be necessary in order to perform the appropriate liquidity management and the necessary funds transfers between accounts.|The member can request information about accounts through a series of criteria, corresponding to the known information stored at the transaction administrator.|The query can concern one or more specific accounts, accounts of a particular identification, or a particular type. The purpose of the query may be to obtain one or more types of balance.|The transaction administrator may also send a ReturnAccount message with pre-defined information, at times previously agreed with the member, or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information based on the following elements: |- account identification|- account name|- account type (this is used when the account identification represents, for example, a group of accounts)|- currency of the account (this is used for example when the account identification represents a group of account in various currencies, or when it is a multi-currency account with one single identifier)|- type of balance (if not present in the GetAccount message, all balances will be reported)|- bilateral or multilateral limits|- related counterparty (when the limit or balance is bilateral)|- balance value date (if not present in the GetAccount message, the ReturnAccount message will contain the latest available balance)|- number of payments to the additional account information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
[IsoId("_jwlb-RbvEeiyVv5j1vf1VQ")]
[DisplayName("Return Account V")]
public partial record ReturnAccountV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.004.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrAcct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.004.001.08";
    
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
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb-xbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader7 MessageHeader { get; init; } 
    
    /// <summary>
    /// Reports on accounts.
    /// </summary>
    [IsoId("_jwlb_RbvEeiyVv5j1vf1VQ")]
    [DisplayName("Report Or Error")]
    [IsoXmlTag("RptOrErr")]
    public required AccountOrOperationalError4Choice_ ReportOrError { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb_xbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ReturnAccountV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReturnAccountV08.

