// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.  Examples include, but are not limited to, taxi, chauffered limousine, boats.
/// </summary>
[IsoId("_nUxnfPQZEeihCvvpsmGI2w")]
[DisplayName("Hired Vehicle")]
public record HiredVehicle1
{
    /// <summary>
    /// Defines the type of company or vehicle being hired (for example, private, taxi, chauffeur service, rideshare).
    /// </summary>
    [IsoId("_nUxngfQZEeihCvvpsmGI2w")]
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CompanyType { get; init; }

    /// <summary>
    /// Contains the name of the company that provided the hired vehicle services.
    /// </summary>
    [IsoId("_nUxnhvQZEeihCvvpsmGI2w")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CompanyName { get; init; }

    /// <summary>
    /// Contains the type of vehicle that was hired (for example, limousine, black, SUV).
    /// </summary>
    [IsoId("_nUxnhfQZEeihCvvpsmGI2w")]
    [DisplayName("Type Of Vehicle")]
    [IsoXmlTag("TpOfVhcl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TypeOfVehicle { get; init; }

    /// <summary>
    /// Contains the identifier assigned to the vehicle.
    /// </summary>
    [IsoId("_nUxnffQZEeihCvvpsmGI2w")]
    [DisplayName("Vehicle Identification")]
    [IsoXmlTag("VhclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VehicleIdentification { get; init; }

    /// <summary>
    /// Contains the identifier assigned to the driver.
    /// </summary>
    [IsoId("_nUxnf_QZEeihCvvpsmGI2w")]
    [DisplayName("Driver Identification")]
    [IsoXmlTag("DrvrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DriverIdentification { get; init; }

    /// <summary>
    /// Contains the tax identifier assigned to the driver.
    /// </summary>
    [IsoId("_nUxngPQZEeihCvvpsmGI2w")]
    [DisplayName("Driver Tax Identification")]
    [IsoXmlTag("DrvrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DriverTaxIdentification { get; init; }

    /// <summary>
    /// Destination of the hired vehicle.
    /// </summary>
    [IsoId("_nUxng_QZEeihCvvpsmGI2w")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public Destination2? Destination { get; init; }
}
