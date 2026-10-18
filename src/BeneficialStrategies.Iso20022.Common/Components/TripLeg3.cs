// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trip Leg3.
/// </summary>
[IsoId("_stVioXQ9Ee6Y1uOeeiF_Eg")]
[DisplayName("Trip Leg3")]
public record TripLeg3
{
    /// <summary>
    /// Sequence Number.
    /// </summary>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public Max35NumericText? SequenceNumber { get; init; }

    /// <summary>
    /// Ticket Number.
    /// </summary>
    [DisplayName("Ticket Number")]
    [IsoXmlTag("TcktNb")]
    public Max35Text? TicketNumber { get; init; }

    /// <summary>
    /// Ticket Issuer.
    /// </summary>
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public Max35Text? TicketIssuer { get; init; }

    /// <summary>
    /// Ticket Issue Date.
    /// </summary>
    [DisplayName("Ticket Issue Date")]
    [IsoXmlTag("TcktIsseDt")]
    public ISODate? TicketIssueDate { get; init; }

    /// <summary>
    /// Ticket Issue Location.
    /// </summary>
    [DisplayName("Ticket Issue Location")]
    [IsoXmlTag("TcktIsseLctn")]
    public Max140Text? TicketIssueLocation { get; init; }

    /// <summary>
    /// Conjunction Ticket Number.
    /// </summary>
    [DisplayName("Conjunction Ticket Number")]
    [IsoXmlTag("CnjnctnTcktNb")]
    public Max35Text? ConjunctionTicketNumber { get; init; }

    /// <summary>
    /// Restricted Ticket.
    /// </summary>
    [DisplayName("Restricted Ticket")]
    [IsoXmlTag("RstrctdTckt")]
    public TrueFalseIndicator? RestrictedTicket { get; init; }

    /// <summary>
    /// Open Ticket.
    /// </summary>
    [DisplayName("Open Ticket")]
    [IsoXmlTag("OpnTckt")]
    public TrueFalseIndicator? OpenTicket { get; init; }

    /// <summary>
    /// Ticket Restrictions.
    /// </summary>
    [DisplayName("Ticket Restrictions")]
    [IsoXmlTag("TcktRstrctns")]
    public Max70Text? TicketRestrictions { get; init; }

    /// <summary>
    /// Exchanged Ticket.
    /// </summary>
    [DisplayName("Exchanged Ticket")]
    [IsoXmlTag("XchgdTckt")]
    public TrueFalseIndicator? ExchangedTicket { get; init; }

    /// <summary>
    /// Exchanged Ticket Number.
    /// </summary>
    [DisplayName("Exchanged Ticket Number")]
    [IsoXmlTag("XchgdTcktNb")]
    public Max35Text? ExchangedTicketNumber { get; init; }

    /// <summary>
    /// Record Locator Number.
    /// </summary>
    [DisplayName("Record Locator Number")]
    [IsoXmlTag("RcrdLctrNb")]
    public Max35Text? RecordLocatorNumber { get; init; }

    /// <summary>
    /// Reservation System.
    /// </summary>
    [DisplayName("Reservation System")]
    [IsoXmlTag("RsvatnSys")]
    public Max4Text? ReservationSystem { get; init; }

    /// <summary>
    /// Reservation Number.
    /// </summary>
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public Max35Text? ReservationNumber { get; init; }

    /// <summary>
    /// Original Reservation System.
    /// </summary>
    [DisplayName("Original Reservation System")]
    [IsoXmlTag("OrgnlRsvatnSys")]
    public Max4Text? OriginalReservationSystem { get; init; }

    /// <summary>
    /// Original Reservation Number.
    /// </summary>
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    public Max35Text? OriginalReservationNumber { get; init; }

    /// <summary>
    /// Document.
    /// </summary>
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public ValueList<DocumentReference1> Document { get; init; } = [];

    /// <summary>
    /// Transport Type.
    /// </summary>
    [DisplayName("Transport Type")]
    [IsoXmlTag("TrnsprtTp")]
    public TransportType1Code? TransportType { get; init; }

    /// <summary>
    /// Other Transport Type.
    /// </summary>
    [DisplayName("Other Transport Type")]
    [IsoXmlTag("OthrTrnsprtTp")]
    public Max35Text? OtherTransportType { get; init; }

    /// <summary>
    /// Commodity Code.
    /// </summary>
    [DisplayName("Commodity Code")]
    [IsoXmlTag("CmmdtyCd")]
    public Max4Text? CommodityCode { get; init; }

    /// <summary>
    /// Carrier Name.
    /// </summary>
    [DisplayName("Carrier Name")]
    [IsoXmlTag("CrrierNm")]
    public Max70Text? CarrierName { get; init; }

    /// <summary>
    /// Carrier Code.
    /// </summary>
    [DisplayName("Carrier Code")]
    [IsoXmlTag("CrrierCd")]
    public Max35Text? CarrierCode { get; init; }

    /// <summary>
    /// IATA Code.
    /// </summary>
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    public Max35Text? IATACode { get; init; }

    /// <summary>
    /// Route Number.
    /// </summary>
    [DisplayName("Route Number")]
    [IsoXmlTag("RouteNb")]
    public Max35Text? RouteNumber { get; init; }

    /// <summary>
    /// Service Class.
    /// </summary>
    [DisplayName("Service Class")]
    [IsoXmlTag("SvcClss")]
    public Max35Text? ServiceClass { get; init; }

    /// <summary>
    /// Departure.
    /// </summary>
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Arrival.
    /// </summary>
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival1? Arrival { get; init; }

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public Max4NumericText? Duration { get; init; }

    /// <summary>
    /// Stop Over.
    /// </summary>
    [DisplayName("Stop Over")]
    [IsoXmlTag("StopOver")]
    public TrueFalseIndicator? StopOver { get; init; }

    /// <summary>
    /// Non Direct Route Code.
    /// </summary>
    [DisplayName("Non Direct Route Code")]
    [IsoXmlTag("NonDrctRouteCd")]
    public Max35Text? NonDirectRouteCode { get; init; }

    /// <summary>
    /// Fair Basis Code.
    /// </summary>
    [DisplayName("Fair Basis Code")]
    [IsoXmlTag("FairBsisCd")]
    public Max35Text? FairBasisCode { get; init; }

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public TrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ValueList<AmountDetails3> Amount { get; init; } = [];

    /// <summary>
    /// Credit Reason Code.
    /// </summary>
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    public Max35Text? CreditReasonCode { get; init; }

    /// <summary>
    /// Procedure Identification.
    /// </summary>
    [DisplayName("Procedure Identification")]
    [IsoXmlTag("PrcdrId")]
    public Max35Text? ProcedureIdentification { get; init; }

    /// <summary>
    /// Loyalty Programme.
    /// </summary>
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
