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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.047.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReturnReservation message is sent by the transaction administrator to a member.
/// It is used to provide information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.
/// The ReturnReservation message can be sent as a response to a related Get Reservation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about the reservations facilities that the transaction administrator manages for the member.
/// The transaction administrator will send reservations information to the member based on the following elements:
/// - identification of the system
/// - identification of the account
/// - status of the reservation (default and/or current )
/// - type of reservation.
/// </summary>
[Description(@"Scope|The ReturnReservation message is sent by the transaction administrator to a member.|It is used to provide information on the details of one or more reservation facilities set by the member and managed by the transaction administrator.|The ReturnReservation message can be sent as a response to a related Get Reservation message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|At any time during the operating hours of the system, the member can query the transaction administrator to get information about the reservations facilities that the transaction administrator manages for the member.|The transaction administrator will send reservations information to the member based on the following elements:|- identification of the system|- identification of the account|- status of the reservation (default and/or current )|- type of reservation.")]
[IsoId("_ThV639b6Eeq_l4BJLVUF2Q")]
[DisplayName("Return Reservation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnReservationV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.047.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrRsvatn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.047.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReturnReservationV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnReservationV07( MessageHeader7 reqMessageHeader,ReservationOrError10Choice_ reqReportOrError )
    {
        MessageHeader = reqMessageHeader;
        ReportOrError = reqReportOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThWht9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader7 MessageHeader { get; init; } 
    #else
    public MessageHeader7 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on reservations.
    /// </summary>
    [IsoId("_ThWhudb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Report Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptOrErr")]
    #endif
    [IsoXmlTag("RptOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationOrError10Choice_ ReportOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReservationOrError10Choice_ ReportOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationOrError10Choice_ ReportOrError { get; init; } 
    #else
    public ReservationOrError10Choice_ ReportOrError { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThWhu9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ReturnReservationV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReturnReservationV07.

