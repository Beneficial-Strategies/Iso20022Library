// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle rental service provides detailed vehicle rental information.
/// </summary>
[IsoId("_9dqxI_TdEeife6veM7daYw")]
[DisplayName("Vehicle Rental Service")]
public record VehicleRentalService1
{
    /// <summary>
    /// Company in charge of a vehicle rental service.
    /// </summary>
    [IsoId("_9dqxJPTdEeife6veM7daYw")]
    [DisplayName("Vehicle Rental Company")]
    [IsoXmlTag("VhclRntlCpny")]
    public VehicleRentalCompany1? VehicleRentalCompany { get; init; }

    /// <summary>
    /// Customer renting a vehicle.
    /// </summary>
    [IsoId("_9dqxJfTdEeife6veM7daYw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public VehicleRentalCustomer1? Customer { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_h6EcwfTeEeife6veM7daYw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Agreement (contract) related to a vehicle rental service.
    /// </summary>
    [IsoId("_exWYUPTeEeife6veM7daYw")]
    [DisplayName("Rental Agreement")]
    [IsoXmlTag("RntlAgrmt")]
    public VehicleRentalAgreement1? RentalAgreement { get; init; }

    /// <summary>
    /// Invoice related to a vehicle rental service.
    /// </summary>
    [IsoId("_sJKG8PTeEeife6veM7daYw")]
    [DisplayName("Rental Invoice")]
    [IsoXmlTag("RntlInvc")]
    public VehicleRentalInvoice1? RentalInvoice { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the vehicle rental.
    /// </summary>
    [IsoId("_w51nsfTeEeife6veM7daYw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
