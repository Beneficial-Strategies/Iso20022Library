// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
[IsoId("_2gCMMUiDEfCMZJtj4J7UGQ")]
[DisplayName("Trip Leg4")]
public record TripLeg4
{
    [IsoId("_2id1IUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoMax35NumericText? SequenceNumber { get; init; }

    [IsoId("_2id1I0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Number")]
    [IsoXmlTag("TcktNb")]
    public IsoMax35Text? TicketNumber { get; init; }

    [IsoId("_2id1JUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public IsoMax35Text? TicketIssuer { get; init; }

    [IsoId("_2id1J0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issue Date")]
    [IsoXmlTag("TcktIsseDt")]
    public IsoISODate? TicketIssueDate { get; init; }

    [IsoId("_2id1KUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issue Location")]
    [IsoXmlTag("TcktIsseLctn")]
    public IsoMax140Text? TicketIssueLocation { get; init; }

    [IsoId("_2id1K0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Conjunction Ticket Number")]
    [IsoXmlTag("CnjnctnTcktNb")]
    public IsoMax35Text? ConjunctionTicketNumber { get; init; }

    [IsoId("_2id1LUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Restricted Ticket")]
    [IsoXmlTag("RstrctdTckt")]
    public IsoTrueFalseIndicator? RestrictedTicket { get; init; }

    [IsoId("_2id1L0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Open Ticket")]
    [IsoXmlTag("OpnTckt")]
    public IsoTrueFalseIndicator? OpenTicket { get; init; }

    [IsoId("_2id1MUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Restrictions")]
    [IsoXmlTag("TcktRstrctns")]
    public IsoMax70Text? TicketRestrictions { get; init; }

    [IsoId("_2id1M0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Exchanged Ticket")]
    [IsoXmlTag("XchgdTckt")]
    public IsoTrueFalseIndicator? ExchangedTicket { get; init; }

    [IsoId("_2id1NUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Exchanged Ticket Number")]
    [IsoXmlTag("XchgdTcktNb")]
    public IsoMax35Text? ExchangedTicketNumber { get; init; }

    [IsoId("_2id1N0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Record Locator Number")]
    [IsoXmlTag("RcrdLctrNb")]
    public IsoMax35Text? RecordLocatorNumber { get; init; }

    [IsoId("_2id1OUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation System")]
    [IsoXmlTag("RsvatnSys")]
    public IsoMax4Text? ReservationSystem { get; init; }

    [IsoId("_2id1O0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public IsoMax35Text? ReservationNumber { get; init; }

    [IsoId("_2id1PUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation System")]
    [IsoXmlTag("OrgnlRsvatnSys")]
    public IsoMax4Text? OriginalReservationSystem { get; init; }

    [IsoId("_2id1P0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    public IsoMax35Text? OriginalReservationNumber { get; init; }

    [IsoId("_2id1QUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public IsoATICALaxProcessing? Document { get; init; }

    [IsoId("_2id1Q0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Transport Type")]
    [IsoXmlTag("TrnsprtTp")]
    public TransportType2Code? TransportType { get; init; }

    [IsoId("_2id1R0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Commodity Code")]
    [IsoXmlTag("CmmdtyCd")]
    public IsoMax4Text? CommodityCode { get; init; }

    [IsoId("_2id1SUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Carrier Name")]
    [IsoXmlTag("CrrierNm")]
    public IsoMax70Text? CarrierName { get; init; }

    [IsoId("_2id1S0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Carrier Code")]
    [IsoXmlTag("CrrierCd")]
    public IsoMax35Text? CarrierCode { get; init; }

    [IsoId("_2id1TUiDEfCMZJtj4J7UGQ")]
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    public IsoMax35Text? IATACode { get; init; }

    [IsoId("_2id1T0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Route Number")]
    [IsoXmlTag("RouteNb")]
    public IsoMax35Text? RouteNumber { get; init; }

    [IsoId("_2id1UUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Service Class")]
    [IsoXmlTag("SvcClss")]
    public IsoMax35Text? ServiceClass { get; init; }

    [IsoId("_2id1U0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    [IsoId("_2id1VUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival1? Arrival { get; init; }

    [IsoId("_2id1V0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    [IsoId("_2id1WUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Stop Over")]
    [IsoXmlTag("StopOver")]
    public IsoTrueFalseIndicator? StopOver { get; init; }

    [IsoId("_2id1W0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Non Direct Route Code")]
    [IsoXmlTag("NonDrctRouteCd")]
    public IsoMax35Text? NonDirectRouteCode { get; init; }

    [IsoId("_2id1XUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Fair Basis Code")]
    [IsoXmlTag("FairBsisCd")]
    public IsoMax35Text? FairBasisCode { get; init; }

    [IsoId("_2id1X0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    [IsoId("_2id1YUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ValueList<AmountAndTax1> Amount { get; init; } = [];

    [IsoId("_2id1Y0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    public IsoMax35Text? CreditReasonCode { get; init; }

    [IsoId("_2id1ZUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Procedure Identification")]
    [IsoXmlTag("PrcdrId")]
    public IsoMax35Text? ProcedureIdentification { get; init; }

    [IsoId("_2id1Z0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    [IsoId("_03GfgkiDEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_03Gfg0iDEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
