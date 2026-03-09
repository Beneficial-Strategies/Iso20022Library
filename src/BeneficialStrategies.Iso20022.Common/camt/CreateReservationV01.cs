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
/// This record is an implementation of the camt.103.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(@"Scope|The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.|Usage|Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.")]
[IsoId("_P8tokckHEem3UrxZgQhVAw")]
[DisplayName("Create Reservation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreateReservationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.103.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretRsvatn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.103.001.01";
    
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
    /// Constructs a CreateReservationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreateReservationV01( MessageHeader1 reqMessageHeader,ReservationIdentification2 reqReservationIdentification,Reservation4 reqValueSet )
    {
        MessageHeader = reqMessageHeader;
        ReservationIdentification = reqReservationIdentification;
        ValueSet = reqValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8tol8kHEem3UrxZgQhVAw")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1 MessageHeader { get; init; } 
    #else
    public MessageHeader1 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_P8tomckHEem3UrxZgQhVAw")]
    [DisplayName("Reservation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnId")]
    #endif
    [IsoXmlTag("RsvatnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationIdentification2 ReservationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReservationIdentification2 ReservationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationIdentification2 ReservationIdentification { get; init; } 
    #else
    public ReservationIdentification2 ReservationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_P8tom8kHEem3UrxZgQhVAw")]
    [DisplayName("Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSet")]
    #endif
    [IsoXmlTag("ValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Reservation4 ValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Reservation4 ValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reservation4 ValueSet { get; init; } 
    #else
    public Reservation4 ValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8tonckHEem3UrxZgQhVAw")]
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


// Since CreateReservationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateReservationV01.

