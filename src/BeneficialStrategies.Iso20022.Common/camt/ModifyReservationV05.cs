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
/// This record is an implementation of the camt.048.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.
/// </summary>
[Description(@"Scope|The ModifyReservation message is used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator.|Usage|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.|If there is enough liquidity available, the requested amount will be reserved. In case the requested amount exceeds the available liquidity, only the available liquidity will be reserved. The difference will not be blocked at a later point, even if the account balance of the member reaches the level of the initial reservation request.|The reservation can be effected directly by the member, who has the possibility to: |- reset the reserved liquidity to zero|- change the reservation amount during the day with immediate effect|- input a default reservation amount for the following day(s); valid until a new reservation amount is requested|After the receipt of a ModifyReservation message the transaction administrator checks whether the amount of liquidity on the member account is sufficient to set the reservation.")]
[IsoId("_jwlb0xbvEeiyVv5j1vf1VQ")]
[DisplayName("Modify Reservation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModifyReservationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.048.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyRsvatn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.048.001.05";
    
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
    /// Constructs a ModifyReservationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModifyReservationV05( MessageHeader1 reqMessageHeader,CurrentOrDefaultReservation2Choice_ reqReservationIdentification,Reservation4 reqNewReservationValueSet )
    {
        MessageHeader = reqMessageHeader;
        ReservationIdentification = reqReservationIdentification;
        NewReservationValueSet = reqNewReservationValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlb1RbvEeiyVv5j1vf1VQ")]
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
    [IsoId("_jwlb1xbvEeiyVv5j1vf1VQ")]
    [DisplayName("Reservation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnId")]
    #endif
    [IsoXmlTag("RsvatnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrentOrDefaultReservation2Choice_ ReservationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrentOrDefaultReservation2Choice_ ReservationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrentOrDefaultReservation2Choice_ ReservationIdentification { get; init; } 
    #else
    public CurrentOrDefaultReservation2Choice_ ReservationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_jwlb2RbvEeiyVv5j1vf1VQ")]
    [DisplayName("New Reservation Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewRsvatnValSet")]
    #endif
    [IsoXmlTag("NewRsvatnValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Reservation4 NewReservationValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Reservation4 NewReservationValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reservation4 NewReservationValueSet { get; init; } 
    #else
    public Reservation4 NewReservationValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb2xbvEeiyVv5j1vf1VQ")]
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


// Since ModifyReservationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyReservationV05.

