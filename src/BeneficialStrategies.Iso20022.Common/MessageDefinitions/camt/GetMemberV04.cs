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
/// This record is an implementation of the camt.013.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetMember message is sent by a member to the transaction administrator.
/// It is used to request information on static data maintained by the transaction administrator and related to the participants in the system and their membership status vis-a-vis this system.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can refer to information about the membership of the system.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data related to the members of the system.
/// The member can request information based on the following elements:
/// - identification of the member within the system
/// - membership status
/// - type of member
/// - contact details for the member: name, address
/// - account number of the member
/// - identification of contact persons for the member
/// This message will be replied to by a ReturnMember message.
/// Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.
/// </summary>
[Description(@"Scope|The GetMember message is sent by a member to the transaction administrator.|It is used to request information on static data maintained by the transaction administrator and related to the participants in the system and their membership status vis-a-vis this system.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can refer to information about the membership of the system.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data related to the members of the system.|The member can request information based on the following elements:|- identification of the member within the system|- membership status|- type of member|- contact details for the member: name, address|- account number of the member|- identification of contact persons for the member|This message will be replied to by a ReturnMember message.|Additional information on the generic design of the Get/Return messages can be found in the MDR Part 1 section How to Use the Cash Management Messages.")]
[IsoId("_jwlbjxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Member V")]
public partial record GetMemberV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.013.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetMmb";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.013.001.04";
    
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
    [IsoId("_jwlbkRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader9 MessageHeader { get; init; } 
    
    /// <summary>
    /// Definition of the member query.
    /// </summary>
    [IsoId("_jwlbkxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Member Query Definition")]
    [IsoXmlTag("MmbQryDef")]
    public MemberQueryDefinition4? MemberQueryDefinition { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlblRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since GetMemberV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetMemberV04.

