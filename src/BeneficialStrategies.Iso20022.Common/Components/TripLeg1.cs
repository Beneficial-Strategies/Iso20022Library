// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
[IsoId("_Z20p3_PzEeihCvvpsmGI2w")]
[DisplayName("Trip Leg")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripLeg1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the specific occurrence of trip leg data. 
    /// </summary>
    [IsoId("_Z21Q6PPzEeihCvvpsmGI2w")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the ticket.
    /// </summary>
    [IsoId("_Z21Q6vPzEeihCvvpsmGI2w")]
    [DisplayName("Ticket")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tckt")]
    #endif
    [IsoXmlTag("Tckt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Ticket1? Ticket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Ticket1? Ticket { get; init; } 
    #else
    public Ticket1? Ticket { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the document type and reference information.
    /// </summary>
    [IsoId("_Z21Q7PPzEeihCvvpsmGI2w")]
    [DisplayName("Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Doc")]
    #endif
    [IsoXmlTag("Doc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentReference1? Document { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentReference1? Document { get; init; } 
    #else
    public DocumentReference1? Document { get; set; } 
    #endif
    
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which service was booked or cancellation was done.
    /// </summary>
    [IsoId("_Z21Q4_PzEeihCvvpsmGI2w")]
    [DisplayName("Procedure Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdrRef")]
    #endif
    [IsoXmlTag("PrcdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcedureReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcedureReference { get; init; } 
    #else
    public System.String? ProcedureReference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of transportation.
    /// </summary>
    [IsoId("_Z21Q4PPzEeihCvvpsmGI2w")]
    [DisplayName("Transport Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtTp")]
    #endif
    [IsoXmlTag("TrnsprtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransportType1Code? TransportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportType1Code? TransportType { get; init; } 
    #else
    public TransportType1Code? TransportType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of transportation.
    /// </summary>
    [IsoId("_Z21Q5_PzEeihCvvpsmGI2w")]
    [DisplayName("Other Transport Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTrnsprtTp")]
    #endif
    [IsoXmlTag("OthrTrnsprtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherTransportType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTransportType { get; init; } 
    #else
    public System.String? OtherTransportType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_Z21Q5vPzEeihCvvpsmGI2w")]
    [DisplayName("Commodity Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmmdtyCd")]
    #endif
    [IsoXmlTag("CmmdtyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? CommodityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommodityCode { get; init; } 
    #else
    public System.String? CommodityCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of transportation carrier.
    /// </summary>
    [IsoId("_Z21Q4vPzEeihCvvpsmGI2w")]
    [DisplayName("Carrier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crrier")]
    #endif
    [IsoXmlTag("Crrier")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CarrierIdentification1? Carrier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CarrierIdentification1? Carrier { get; init; } 
    #else
    public CarrierIdentification1? Carrier { get; set; } 
    #endif
    
    /// <summary>
    /// Route number as specified by the transportation carrier (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    [IsoId("_Z21Q5fPzEeihCvvpsmGI2w")]
    [DisplayName("Route Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RouteNb")]
    #endif
    [IsoXmlTag("RouteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RouteNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RouteNumber { get; init; } 
    #else
    public System.String? RouteNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the service class (for example, coach or first class).
    /// </summary>
    [IsoId("_Z21Q7fPzEeihCvvpsmGI2w")]
    [DisplayName("Service Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcClss")]
    #endif
    [IsoXmlTag("SvcClss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceClass { get; init; } 
    #else
    public System.String? ServiceClass { get; set; } 
    #endif
    
    /// <summary>
    /// Contains departure location, date and time. 
    /// </summary>
    [IsoId("_Z21Q6_PzEeihCvvpsmGI2w")]
    [DisplayName("Departure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dprture")]
    #endif
    [IsoXmlTag("Dprture")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepartureOrArrival1? Departure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepartureOrArrival1? Departure { get; init; } 
    #else
    public DepartureOrArrival1? Departure { get; set; } 
    #endif
    
    /// <summary>
    /// Contains arrival location, date and time. 
    /// </summary>
    [IsoId("_Zl7XAfQHEeihCvvpsmGI2w")]
    [DisplayName("Arrival")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Arrvl")]
    #endif
    [IsoXmlTag("Arrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DepartureOrArrival1? Arrival { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DepartureOrArrival1? Arrival { get; init; } 
    #else
    public DepartureOrArrival1? Arrival { get; set; } 
    #endif
    
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_07fyQfQNEeihCvvpsmGI2w")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4NumericText? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Duration { get; init; } 
    #else
    public System.String? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that specifies whether the mode of transportation was a direct or non-direct route on the same ticket number.
    /// </summary>
    [IsoId("_PGgGkPQOEeihCvvpsmGI2w")]
    [DisplayName("Stop Over Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StopOverInd")]
    #endif
    [IsoXmlTag("StopOverInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? StopOverIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StopOverIndicator { get; init; } 
    #else
    public System.String? StopOverIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a non-direct route between the origin and the destination. 
    /// </summary>
    [IsoId("_oYmc8PQOEeihCvvpsmGI2w")]
    [DisplayName("Non Direct Route Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonDrctRouteCd")]
    #endif
    [IsoXmlTag("NonDrctRouteCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NonDirectRouteCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonDirectRouteCode { get; init; } 
    #else
    public System.String? NonDirectRouteCode { get; set; } 
    #endif
    
    /// <summary>
    /// Code that transportation companies assign to a particular ticket type, such as business class or discounted or non-refundable tickets. 
    /// </summary>
    [IsoId("_-1sVEPQOEeihCvvpsmGI2w")]
    [DisplayName("Fair Basis Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FairBsisCd")]
    #endif
    [IsoXmlTag("FairBsisCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FairBasisCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FairBasisCode { get; init; } 
    #else
    public System.String? FairBasisCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_HddcIvQPEeihCvvpsmGI2w")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains trip leg amount information. 
    /// </summary>
    [IsoId("_HddcI_QPEeihCvvpsmGI2w")]
    [DisplayName("Trip Leg Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TripLegAmt")]
    #endif
    [IsoXmlTag("TripLegAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountDetails1? TripLegAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountDetails1? TripLegAmount { get; init; } 
    #else
    public AmountDetails1? TripLegAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    [IsoId("_hEmLUekYEemeDPHh-U9b6w")]
    [DisplayName("Credit Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtRsnCd")]
    #endif
    [IsoXmlTag("CdtRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditReasonCode { get; init; } 
    #else
    public System.String? CreditReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which the service was booked or a cancellation was completed. 
    /// </summary>
    [IsoId("_xTVG0PQPEeihCvvpsmGI2w")]
    [DisplayName("Procedure Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdrId")]
    #endif
    [IsoXmlTag("PrcdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProcedureIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcedureIdentification { get; init; } 
    #else
    public System.String? ProcedureIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    [IsoId("_Z21Q4fPzEeihCvvpsmGI2w")]
    [DisplayName("Loyalty Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyPrgrmm")]
    #endif
    [IsoXmlTag("LltyPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme2? LoyaltyProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_Z21Q5PPzEeihCvvpsmGI2w")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
