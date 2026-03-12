// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
[IsoId("_Z20p3_PzEeihCvvpsmGI2w")]
[DisplayName("Trip Leg")]
public partial record TripLeg1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the specific occurrence of trip leg data. 
    /// </summary>
    [IsoId("_Z21Q6PPzEeihCvvpsmGI2w")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Details of the ticket.
    /// </summary>
    [IsoId("_Z21Q6vPzEeihCvvpsmGI2w")]
    [DisplayName("Ticket")]
    [IsoXmlTag("Tckt")]
    public Ticket1? Ticket { get; init; } 
    
    /// <summary>
    /// Provides the document type and reference information.
    /// </summary>
    [IsoId("_Z21Q7PPzEeihCvvpsmGI2w")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public DocumentReference1? Document { get; init; } 
    
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which service was booked or cancellation was done.
    /// </summary>
    [IsoId("_Z21Q4_PzEeihCvvpsmGI2w")]
    [DisplayName("Procedure Reference")]
    [IsoXmlTag("PrcdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcedureReference { get; init; } 
    
    /// <summary>
    /// Type of transportation.
    /// </summary>
    [IsoId("_Z21Q4PPzEeihCvvpsmGI2w")]
    [DisplayName("Transport Type")]
    [IsoXmlTag("TrnsprtTp")]
    public TransportType1Code? TransportType { get; init; } 
    
    /// <summary>
    /// Other type of transportation.
    /// </summary>
    [IsoId("_Z21Q5_PzEeihCvvpsmGI2w")]
    [DisplayName("Other Transport Type")]
    [IsoXmlTag("OthrTrnsprtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherTransportType { get; init; } 
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_Z21Q5vPzEeihCvvpsmGI2w")]
    [DisplayName("Commodity Code")]
    [IsoXmlTag("CmmdtyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? CommodityCode { get; init; } 
    
    /// <summary>
    /// Identification of transportation carrier.
    /// </summary>
    [IsoId("_Z21Q4vPzEeihCvvpsmGI2w")]
    [DisplayName("Carrier")]
    [IsoXmlTag("Crrier")]
    public CarrierIdentification1? Carrier { get; init; } 
    
    /// <summary>
    /// Route number as specified by the transportation carrier (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    [IsoId("_Z21Q5fPzEeihCvvpsmGI2w")]
    [DisplayName("Route Number")]
    [IsoXmlTag("RouteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RouteNumber { get; init; } 
    
    /// <summary>
    /// Indicates the service class (for example, coach or first class).
    /// </summary>
    [IsoId("_Z21Q7fPzEeihCvvpsmGI2w")]
    [DisplayName("Service Class")]
    [IsoXmlTag("SvcClss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceClass { get; init; } 
    
    /// <summary>
    /// Contains departure location, date and time. 
    /// </summary>
    [IsoId("_Z21Q6_PzEeihCvvpsmGI2w")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; } 
    
    /// <summary>
    /// Contains arrival location, date and time. 
    /// </summary>
    [IsoId("_Zl7XAfQHEeihCvvpsmGI2w")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival1? Arrival { get; init; } 
    
    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_07fyQfQNEeihCvvpsmGI2w")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Indicator that specifies whether the mode of transportation was a direct or non-direct route on the same ticket number.
    /// </summary>
    [IsoId("_PGgGkPQOEeihCvvpsmGI2w")]
    [DisplayName("Stop Over Indicator")]
    [IsoXmlTag("StopOverInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? StopOverIndicator { get; init; } 
    
    /// <summary>
    /// Indicates a non-direct route between the origin and the destination. 
    /// </summary>
    [IsoId("_oYmc8PQOEeihCvvpsmGI2w")]
    [DisplayName("Non Direct Route Code")]
    [IsoXmlTag("NonDrctRouteCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NonDirectRouteCode { get; init; } 
    
    /// <summary>
    /// Code that transportation companies assign to a particular ticket type, such as business class or discounted or non-refundable tickets. 
    /// </summary>
    [IsoId("_-1sVEPQOEeihCvvpsmGI2w")]
    [DisplayName("Fair Basis Code")]
    [IsoXmlTag("FairBsisCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FairBasisCode { get; init; } 
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_HddcIvQPEeihCvvpsmGI2w")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    
    /// <summary>
    /// Contains trip leg amount information. 
    /// </summary>
    [IsoId("_HddcI_QPEeihCvvpsmGI2w")]
    [DisplayName("Trip Leg Amount")]
    [IsoXmlTag("TripLegAmt")]
    public AmountDetails1? TripLegAmount { get; init; } 
    
    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    [IsoId("_hEmLUekYEemeDPHh-U9b6w")]
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CreditReasonCode { get; init; } 
    
    /// <summary>
    /// Contains identification of the rail server procedure or the order in which the service was booked or a cancellation was completed. 
    /// </summary>
    [IsoId("_xTVG0PQPEeihCvvpsmGI2w")]
    [DisplayName("Procedure Identification")]
    [IsoXmlTag("PrcdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcedureIdentification { get; init; } 
    
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    [IsoId("_Z21Q4fPzEeihCvvpsmGI2w")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    
    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_Z21Q5PPzEeihCvvpsmGI2w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
