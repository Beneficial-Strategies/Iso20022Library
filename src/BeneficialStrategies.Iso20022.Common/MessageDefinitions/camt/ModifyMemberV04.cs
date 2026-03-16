// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.015.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ModifyMember message is sent by a member to the transaction administrator.
/// It is used to request modifications to the static data related to the profile of a member that the transaction administrator maintains.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can, refer to information about the membership of the system.
/// At any time during the operating hours of the system, the member can request the transaction administrator to modify the information it maintains about the member.
/// The member will submit a message requesting modifications in one or more of the following criteria:
/// - identification of the member
/// - contact information for the member organization: postal address, e-mail address, telephone or fax number
/// - identification of contact persons for the member, their role and/or details (postal address, e-mail address, telephone or fax number)
/// Based on the criteria received within the Modify Member message, the transaction administrator will execute or reject the requested modifications.
/// In principle, the transaction administrator may send a Receipt message as a reply to the ModifyMember request. To verify the outcome of the request, the member may submit a GetMember message with the appropriate search criteria.
/// </summary>
[Description(
    @"Scope|The ModifyMember message is sent by a member to the transaction administrator.|It is used to request modifications to the static data related to the profile of a member that the transaction administrator maintains.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can, refer to information about the membership of the system.|At any time during the operating hours of the system, the member can request the transaction administrator to modify the information it maintains about the member.|The member will submit a message requesting modifications in one or more of the following criteria:|- identification of the member|- contact information for the member organization: postal address, e-mail address, telephone or fax number|- identification of contact persons for the member, their role and/or details (postal address, e-mail address, telephone or fax number)|Based on the criteria received within the Modify Member message, the transaction administrator will execute or reject the requested modifications.|In principle, the transaction administrator may send a Receipt message as a reply to the ModifyMember request. To verify the outcome of the request, the member may submit a GetMember message with the appropriate search criteria."
)]
[IsoId("_jwlbxxbvEeiyVv5j1vf1VQ")]
[DisplayName("Modify Member V")]
public record ModifyMemberV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.015.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyMmb";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.015.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbyxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a system member, as assigned by the system, or the system administrator.
    /// </summary>
    [IsoId("_jwlbzRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public required MemberIdentification3Choice_ MemberIdentification { get; init; }

    /// <summary>
    /// New member values.
    /// </summary>
    [IsoId("_jwlbzxbvEeiyVv5j1vf1VQ")]
    [DisplayName("New Member Value Set")]
    [IsoXmlTag("NewMmbValSet")]
    public required Member6 NewMemberValueSet { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb0RbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ModifyMemberV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyMemberV04.
