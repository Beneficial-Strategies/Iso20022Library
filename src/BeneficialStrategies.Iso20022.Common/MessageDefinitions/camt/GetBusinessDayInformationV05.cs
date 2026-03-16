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
/// This record is an implementation of the camt.018.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetBusinessDayInformation message is sent by a member to the transaction administrator.
/// It is used to request information on different types of administrative data linked to the system.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.
/// The member can request information based on the following elements:
/// - identification of the system
/// - currency within the system concerned
/// - status of the system
/// - period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)
/// - closure information (dates when the system will be inactive and reasons for this inactivity)
/// - event indicator (types of event and precise timing of their occurrence within the system concerned)
/// This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Description(
    @"Scope|The GetBusinessDayInformation message is sent by a member to the transaction administrator.|It is used to request information on different types of administrative data linked to the system.|Usage|The transaction administrator is in charge of providing the members with business information. The term business day information covers all information related to the management of the system, not related to the transactions created in the system. The type of business day information available can vary depending on the system.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the static data of the system.|The member can request information based on the following elements:|- identification of the system|- currency within the system concerned|- status of the system|- period of availability of a given currency linked to the system concerned (in case the system handles more than one currency)|- closure information (dates when the system will be inactive and reasons for this inactivity)|- event indicator (types of event and precise timing of their occurrence within the system concerned)|This message will be replied to by a ReturnBusinessDayInformation message. Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages."
)]
[IsoId("_jwlbbxbvEeiyVv5j1vf1VQ")]
[DisplayName("Get Business Day Information V")]
public record GetBusinessDayInformationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.018.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetBizDayInf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.018.001.05";

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
    [IsoId("_jwlbcRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader9 MessageHeader { get; init; }

    /// <summary>
    /// Defines the business day information query criteria.
    /// </summary>
    [IsoId("_jwlbcxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Business Day Information Query Definition")]
    [IsoXmlTag("BizDayInfQryDef")]
    public BusinessDayQuery2? BusinessDayInformationQueryDefinition { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlbdRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since GetBusinessDayInformationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetBusinessDayInformationV05.
