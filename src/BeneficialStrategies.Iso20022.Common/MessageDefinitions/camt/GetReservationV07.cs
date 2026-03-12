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
/// This record is an implementation of the camt.046.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetReservation message is sent by a member to the transaction administrator.
/// It is used to request information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.
/// Usage
/// The member can request reservations information based on the following elements:
/// - identification of the system;
/// - identification of the account;
/// - status of the reservation (default and/or current);
/// - type of reservation.
/// This message will be replied to by a ReturnReservation message.
/// </summary>
[Description(@"Scope|The GetReservation message is sent by a member to the transaction administrator.|It is used to request information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.|Usage|The member can request reservations information based on the following elements:|- identification of the system;|- identification of the account;|- status of the reservation (default and/or current);|- type of reservation.|This message will be replied to by a ReturnReservation message.")]
[IsoId("_4DhGEQy9Ee2Wmf2RrXviyA")]
[DisplayName("Get Reservation V")]
public partial record GetReservationV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.046.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetRsvatn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.046.001.07";
    
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
    [IsoId("_4DhGFwy9Ee2Wmf2RrXviyA")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader9 MessageHeader { get; init; } 
    
    /// <summary>
    /// Definition of the reservation query.
    /// </summary>
    [IsoId("_4DhGGQy9Ee2Wmf2RrXviyA")]
    [DisplayName("Reservation Query Definition")]
    [IsoXmlTag("RsvatnQryDef")]
    public ReservationQuery5? ReservationQueryDefinition { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_4DhGGwy9Ee2Wmf2RrXviyA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since GetReservationV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to GetReservationV07.

