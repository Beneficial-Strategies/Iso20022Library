// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Driver in a car rental party
/// </summary>
[IsoId("_DNYFscW0EeuhguwJmlgagQ")]
[DisplayName("Driver In Party")]
public record DriverInParty2
{
    /// <summary>
    /// Name of vehicle rental driver.
    /// </summary>
    [IsoId("_DSE_gcW0EeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Address of driver in party.
    /// </summary>
    [IsoId("_DSE_g8W0EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact details of driver in party.
    /// </summary>
    [IsoId("_DSE_hcW0EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; }

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_DSE_h8W0EeuhguwJmlgagQ")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Age of driver.
    /// </summary>
    [IsoId("_DSE_icW0EeuhguwJmlgagQ")]
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Age { get; init; }

    /// <summary>
    /// Credential used by the driver for identification.
    /// </summary>
    [IsoId("_DSE_i8W0EeuhguwJmlgagQ")]
    [DisplayName("Driver Credential")]
    [IsoXmlTag("DrvrCrdntl")]
    public TravelDocument2? DriverCredential { get; init; }

    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_DSE_jcW0EeuhguwJmlgagQ")]
    [DisplayName("Driving License")]
    [IsoXmlTag("DrvgLic")]
    public DrivingLicense2? DrivingLicense { get; init; }
}
