// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum Data6.
/// </summary>
[IsoId("_LlKvIXNREe6Y1uOeeiF_Eg")]
[DisplayName("Addendum Data6")]
public record AddendumData6
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData2> AdditionalData { get; init; } = [];

    /// <summary>
    /// Fleet.
    /// </summary>
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData6? Fleet { get; init; }

    /// <summary>
    /// Invoice.
    /// </summary>
    [DisplayName("Invoice")]
    [IsoXmlTag("Invc")]
    public Invoice3? Invoice { get; init; }

    /// <summary>
    /// Lodging.
    /// </summary>
    [DisplayName("Lodging")]
    [IsoXmlTag("Ldgg")]
    public ValueList<Lodging4> Lodging { get; init; } = [];

    /// <summary>
    /// Passenger Transport.
    /// </summary>
    [DisplayName("Passenger Transport")]
    [IsoXmlTag("PssngrTrnsprt")]
    public PassengerTransport3? PassengerTransport { get; init; }

    /// <summary>
    /// Sale.
    /// </summary>
    [DisplayName("Sale")]
    [IsoXmlTag("Sale")]
    public Sale3? Sale { get; init; }

    /// <summary>
    /// Shipping Data.
    /// </summary>
    [DisplayName("Shipping Data")]
    [IsoXmlTag("ShppgData")]
    public ShippingData3? ShippingData { get; init; }

    /// <summary>
    /// Telecommunication Services.
    /// </summary>
    [DisplayName("Telecommunication Services")]
    [IsoXmlTag("TelecomSvcs")]
    public TelecomServices3? TelecommunicationServices { get; init; }

    /// <summary>
    /// Temporary Services.
    /// </summary>
    [DisplayName("Temporary Services")]
    [IsoXmlTag("TempSvcs")]
    public ValueList<TemporaryServices3> TemporaryServices { get; init; } = [];

    /// <summary>
    /// Travel Agency.
    /// </summary>
    [DisplayName("Travel Agency")]
    [IsoXmlTag("TrvlAgcy")]
    public ValueList<TravelAgency4> TravelAgency { get; init; } = [];

    /// <summary>
    /// Vehicle Rental.
    /// </summary>
    [DisplayName("Vehicle Rental")]
    [IsoXmlTag("VhclRntl")]
    public ValueList<VehicleRentalService3> VehicleRental { get; init; } = [];
}
