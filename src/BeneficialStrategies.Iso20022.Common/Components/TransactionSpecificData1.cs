// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains data structures applicable to certain merchant verticals that require industry-specific data within transaction messages.
/// </summary>
[IsoId("_jPs8QUYYEfCQAqQ9lolFUg")]
[DisplayName("Transaction Specific Data1")]
public record TransactionSpecificData1
{
    [IsoId("_jSIlMUYYEfCQAqQ9lolFUg")]
    [DisplayName("Sale")]
    [IsoXmlTag("Sale")]
    public Sale4? Sale { get; init; }

    [IsoId("_jSIlM0YYEfCQAqQ9lolFUg")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData7? Fleet { get; init; }

    [IsoId("_jSIlNUYYEfCQAqQ9lolFUg")]
    [DisplayName("Invoice")]
    [IsoXmlTag("Invc")]
    public Invoice4? Invoice { get; init; }

    [IsoId("_jSIlN0YYEfCQAqQ9lolFUg")]
    [DisplayName("Travel Agency")]
    [IsoXmlTag("TrvlAgcy")]
    public ValueList<TravelAgency5> TravelAgency { get; init; } = [];

    [IsoId("_jSIlOUYYEfCQAqQ9lolFUg")]
    [DisplayName("Passenger Transport")]
    [IsoXmlTag("PssngrTrnsprt")]
    public PassengerTransport4? PassengerTransport { get; init; }

    [IsoId("_jSIlO0YYEfCQAqQ9lolFUg")]
    [DisplayName("Vehicle Rental")]
    [IsoXmlTag("VhclRntl")]
    public ValueList<VehicleRentalService4> VehicleRental { get; init; } = [];

    [IsoId("_jSIlPUYYEfCQAqQ9lolFUg")]
    [DisplayName("Lodging")]
    [IsoXmlTag("Ldgg")]
    public ValueList<Lodging5> Lodging { get; init; } = [];

    [IsoId("_jSIlP0YYEfCQAqQ9lolFUg")]
    [DisplayName("Shipping Data")]
    [IsoXmlTag("ShppgData")]
    public ShippingData4? ShippingData { get; init; }

    [IsoId("_jSIlQUYYEfCQAqQ9lolFUg")]
    [DisplayName("Telecommunication Services")]
    [IsoXmlTag("TelecomSvcs")]
    public TelecomServices4? TelecommunicationServices { get; init; }

    [IsoId("_jSIlQ0YYEfCQAqQ9lolFUg")]
    [DisplayName("Temporary Services")]
    [IsoXmlTag("TempSvcs")]
    public ValueList<TemporaryServices4> TemporaryServices { get; init; } = [];

    [IsoId("_ybFhUkYYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_ybFhU0YYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
