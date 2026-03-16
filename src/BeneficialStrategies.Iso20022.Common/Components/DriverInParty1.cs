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
[IsoId("_dUOokFyvEeeve7Je9cXtkQ")]
[DisplayName("Driver In Party")]
public record DriverInParty1
{
    /// <summary>
    /// Name of vehicle rental driver.
    /// </summary>
    [IsoId("_njIFgFyvEeeve7Je9cXtkQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Address of driver in party.
    /// </summary>
    [IsoId("_oB86EFywEeeve7Je9cXtkQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Contact details of driver in party.
    /// </summary>
    [IsoId("_shr0wFywEeeve7Je9cXtkQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; }

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_fjFQUFywEeeve7Je9cXtkQ")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Age of driver.
    /// </summary>
    [IsoId("_xM6LwFzGEeeDqe2giKl0eQ")]
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Age { get; init; }

    /// <summary>
    /// Credential used by the driver for identification.
    /// </summary>
    [IsoId("_K7dFAFywEeeve7Je9cXtkQ")]
    [DisplayName("Driver Credential")]
    [IsoXmlTag("DrvrCrdntl")]
    public TravelDocument1? DriverCredential { get; init; }

    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_S-g8gFywEeeve7Je9cXtkQ")]
    [DisplayName("Driving License")]
    [IsoXmlTag("DrvgLic")]
    public DrivingLicense1? DrivingLicense { get; init; }
}
