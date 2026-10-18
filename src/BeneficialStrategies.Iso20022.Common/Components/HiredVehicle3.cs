// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hired Vehicle3.
/// </summary>
[IsoId("_K1f94XTfEe6h-4AZRg9sVg")]
[DisplayName("Hired Vehicle3")]
public record HiredVehicle3
{
    /// <summary>
    /// Company Type.
    /// </summary>
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    public Max35Text? CompanyType { get; init; }

    /// <summary>
    /// Company Name.
    /// </summary>
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public Max70Text? CompanyName { get; init; }

    /// <summary>
    /// Type Of Vehicle.
    /// </summary>
    [DisplayName("Type Of Vehicle")]
    [IsoXmlTag("TpOfVhcl")]
    public Max35Text? TypeOfVehicle { get; init; }

    /// <summary>
    /// Vehicle Identification.
    /// </summary>
    [DisplayName("Vehicle Identification")]
    [IsoXmlTag("VhclId")]
    public Max35Text? VehicleIdentification { get; init; }

    /// <summary>
    /// Driver Identification.
    /// </summary>
    [DisplayName("Driver Identification")]
    [IsoXmlTag("DrvrId")]
    public Max35Text? DriverIdentification { get; init; }

    /// <summary>
    /// Driver Tax Identification.
    /// </summary>
    [DisplayName("Driver Tax Identification")]
    [IsoXmlTag("DrvrTaxId")]
    public Max35Text? DriverTaxIdentification { get; init; }

    /// <summary>
    /// Destination Name And Location.
    /// </summary>
    [DisplayName("Destination Name And Location")]
    [IsoXmlTag("DstnNmAndLctn")]
    public Max99Text? DestinationNameAndLocation { get; init; }

    /// <summary>
    /// Destination Address.
    /// </summary>
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    public Address2? DestinationAddress { get; init; }
}
