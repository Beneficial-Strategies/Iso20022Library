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
    /// <summary>
    /// Details of good and services included in the sale.
    /// </summary>
    [IsoId("_jSIlMUYYEfCQAqQ9lolFUg")]
    [DisplayName("Sale")]
    [IsoXmlTag("Sale")]
    public Sale4? Sale { get; init; }

    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_jSIlM0YYEfCQAqQ9lolFUg")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData7? Fleet { get; init; }

    /// <summary>
    /// Invoice data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_jSIlNUYYEfCQAqQ9lolFUg")]
    [DisplayName("Invoice")]
    [IsoXmlTag("Invc")]
    public Invoice4? Invoice { get; init; }

    /// <summary>
    /// Component supports corporate transactions for travel agency, airline, or railway transactions.
    /// </summary>
    [IsoId("_jSIlN0YYEfCQAqQ9lolFUg")]
    [DisplayName("Travel Agency")]
    [IsoXmlTag("TrvlAgcy")]
    public ValueList<TravelAgency5> TravelAgency { get; init; } = [];

    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder.
    /// </summary>
    [IsoId("_jSIlOUYYEfCQAqQ9lolFUg")]
    [DisplayName("Passenger Transport")]
    [IsoXmlTag("PssngrTrnsprt")]
    public PassengerTransport4? PassengerTransport { get; init; }

    /// <summary>
    /// Component provides detailed vehicle rental information. One occurrence of this component provides rental agreement data reporting for a single vehicle rental transaction.
    /// </summary>
    [IsoId("_jSIlO0YYEfCQAqQ9lolFUg")]
    [DisplayName("Vehicle Rental")]
    [IsoXmlTag("VhclRntl")]
    public ValueList<VehicleRentalService4> VehicleRental { get; init; } = [];

    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder.
    /// </summary>
    [IsoId("_jSIlPUYYEfCQAqQ9lolFUg")]
    [DisplayName("Lodging")]
    [IsoXmlTag("Ldgg")]
    public ValueList<Lodging5> Lodging { get; init; } = [];

    /// <summary>
    /// Shipping or Courier Service detail component provides detailed information regarding delivery or courier services.
    /// </summary>
    [IsoId("_jSIlP0YYEfCQAqQ9lolFUg")]
    [DisplayName("Shipping Data")]
    [IsoXmlTag("ShppgData")]
    public ShippingData4? ShippingData { get; init; }

    /// <summary>
    /// Telecommunication services component is designed to carry telephony billing data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to telecommunications services and related billing information.
    /// </summary>
    [IsoId("_jSIlQUYYEfCQAqQ9lolFUg")]
    [DisplayName("Telecommunication Services")]
    [IsoXmlTag("TelecomSvcs")]
    public TelecomServices4? TelecommunicationServices { get; init; }

    /// <summary>
    /// Temporary Services component provides detailed information regarding the billing for services rendered on a temporary or contract basis.
    /// </summary>
    [IsoId("_jSIlQ0YYEfCQAqQ9lolFUg")]
    [DisplayName("Temporary Services")]
    [IsoXmlTag("TempSvcs")]
    public ValueList<TemporaryServices4> TemporaryServices { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_ybFhUkYYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_ybFhU0YYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
