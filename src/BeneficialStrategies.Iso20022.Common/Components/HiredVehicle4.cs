// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.
/// </summary>
[IsoId("_pF1jUVN4EfC0lMwgjvMClw")]
[DisplayName("Hired Vehicle4")]
public record HiredVehicle4
{
    /// <summary>
    /// Defines the type of company or vehicle being hired (for example, private, taxi, chauffeur service, rideshare).
    /// </summary>
    [IsoId("_pIkHMVN4EfC0lMwgjvMClw")]
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    public IsoMax35Text? CompanyType { get; init; }

    /// <summary>
    /// Contains the name of the company that provided the hired vehicle services.
    /// </summary>
    [IsoId("_pIkHM1N4EfC0lMwgjvMClw")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; }

    /// <summary>
    /// Contains the type of vehicle that was hired (for example, limousine, black, SUV).
    /// </summary>
    [IsoId("_pIkHNVN4EfC0lMwgjvMClw")]
    [DisplayName("Type Of Vehicle")]
    [IsoXmlTag("TpOfVhcl")]
    public IsoMax35Text? TypeOfVehicle { get; init; }

    /// <summary>
    /// Contains the identifier assigned to the vehicle.
    /// </summary>
    [IsoId("_pIkHN1N4EfC0lMwgjvMClw")]
    [DisplayName("Vehicle Identification")]
    [IsoXmlTag("VhclId")]
    public IsoMax35Text? VehicleIdentification { get; init; }

    /// <summary>
    /// Contains the identifier assigned to the driver.
    /// </summary>
    [IsoId("_pIkHOVN4EfC0lMwgjvMClw")]
    [DisplayName("Driver Identification")]
    [IsoXmlTag("DrvrId")]
    public IsoMax35Text? DriverIdentification { get; init; }

    /// <summary>
    /// Contains the tax identifier assigned to the driver.
    /// </summary>
    [IsoId("_pIkHO1N4EfC0lMwgjvMClw")]
    [DisplayName("Driver Tax Identification")]
    [IsoXmlTag("DrvrTaxId")]
    public IsoMax35Text? DriverTaxIdentification { get; init; }

    /// <summary>
    /// Name and location of the destination.
    /// </summary>
    [IsoId("_pIkHPVN4EfC0lMwgjvMClw")]
    [DisplayName("Destination Name And Location")]
    [IsoXmlTag("DstnNmAndLctn")]
    public IsoMax99Text? DestinationNameAndLocation { get; init; }

    /// <summary>
    /// Specific address of the destination.
    /// </summary>
    [IsoId("_pIkHP1N4EfC0lMwgjvMClw")]
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    public Address4? DestinationAddress { get; init; }
}
