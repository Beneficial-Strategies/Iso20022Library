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
/// This record is an implementation of the camt.003.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetAccount message is sent by a member to the transaction administrator.
/// It is used to request information on the details of one or more accounts held at the transaction administrator, including information on the balances.
/// Usage
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the account(s) that the transaction administrator maintains for the member.
/// For example, this may be necessary in order to perform the appropriate liquidity management and the funds transfers between accounts.
/// The member can request information about accounts through a series of criteria, corresponding to the known information stored at the transaction administrator.
/// The query can concern one or more specific accounts, accounts of a particular identification, or a particular type. The purpose of the query may be to obtain one or more types of balance.
/// The member can request information based on the following elements:
/// - account identification
/// - account type (this element can be used to refine the query when the account identification represents, for example, a group of accounts)
/// - balance type (if not present, all balances are requested)
/// - type of counterparty: bilateral or multilateral (note that, by default, a balance is multilateral unless a particular counterparty is specified)
/// - identification of the counterparty when a bilateral balance is requested
/// - balance value date (if not present in the GetAccount message, the ReturnAccount message will contain the latest available balance)
/// This message will be answered by a ReturnAccount message.
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The GetAccount message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more accounts held at the transaction administrator, including information on the balances.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the account(s) that the transaction administrator maintains for the member.|For example, this may be necessary in order to perform the appropriate liquidity management and the funds transfers between accounts.|The member can request information about accounts through a series of criteria, corresponding to the known information stored at the transaction administrator.|The query can concern one or more specific accounts, accounts of a particular identification, or a particular type. The purpose of the query may be to obtain one or more types of balance.|The member can request information based on the following elements:|- account identification|- account type (this element can be used to refine the query when the account identification represents, for example, a group of accounts)|- balance type (if not present, all balances are requested)|- type of counterparty: bilateral or multilateral (note that, by default, a balance is multilateral unless a particular counterparty is specified)|- identification of the counterparty when a bilateral balance is requested|- balance value date (if not present in the GetAccount message, the ReturnAccount message will contain the latest available balance)|This message will be answered by a ReturnAccount message.|Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
[IsoId("_jwlbZxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Account V")]
public partial record GetAccountV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.003.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetAcct";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.003.001.07";
    
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
    [IsoId("_jwlbaRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader9 MessageHeader { get; init; } 
    
    /// <summary>
    /// Defines the account query criteria.
    /// </summary>
    [IsoId("_jwlbaxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Account Query Definition")]
    [IsoXmlTag("AcctQryDef")]
    public AccountQuery3? AccountQueryDefinition { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbbRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since GetAccountV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetAccountV07.

