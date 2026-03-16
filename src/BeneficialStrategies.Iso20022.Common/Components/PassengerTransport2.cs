// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Passenger ticket information for the cardholder.
/// </summary>
[IsoId("_vcAAUYv0EeumSPwlS1PkxQ")]
[DisplayName("Passenger Transport")]
public record PassengerTransport2
{
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit one occurrence of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_vhQTwYv0EeumSPwlS1PkxQ")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public PassengerTransportSummary2? Summary { get; init; }

    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit multiple occurrences of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_vhQTw4v0EeumSPwlS1PkxQ")]
    [DisplayName("Trip Leg")]
    [IsoXmlTag("TripLeg")]
    public TripLeg2? TripLeg { get; init; }

    /// <summary>
    /// Contains additional charges related to or during transit (for example, baggage fee, in-flight purchase). These are separate from the original ticket purchase.
    /// </summary>
    [IsoId("_vhQTxYv0EeumSPwlS1PkxQ")]
    [DisplayName("Ancillary Purchase")]
    [IsoXmlTag("AncllryPurchs")]
    public AncillaryPurchase2? AncillaryPurchase { get; init; }

    /// <summary>
    /// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.  Examples include, but are not limited to, taxi, chauffeured limousine, boats.
    /// </summary>
    [IsoId("_vhQTx4v0EeumSPwlS1PkxQ")]
    [DisplayName("Hired Vehicle Details")]
    [IsoXmlTag("HirdVhclDtls")]
    public HiredVehicle2? HiredVehicleDetails { get; init; }
}
