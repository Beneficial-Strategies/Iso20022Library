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
/// This record is an implementation of the camt.048.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.
/// </summary>
[Description(@"Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.")]
[IsoId("_ThUsgdb6Eeq_l4BJLVUF2Q")]
[DisplayName("Modify Reservation V")]
public partial record ModifyReservationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.048.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyRsvatn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.048.001.06";
    
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
    [IsoId("_ThUsh9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; } 
    
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_ThUsidb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required CurrentOrDefaultReservation3Choice_ ReservationIdentification { get; init; } 
    
    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_ThUsi9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("New Reservation Value Set")]
    [IsoXmlTag("NewRsvatnValSet")]
    public required Reservation4 NewReservationValueSet { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThUsjdb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ModifyReservationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyReservationV06.

