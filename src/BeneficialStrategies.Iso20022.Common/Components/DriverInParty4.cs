// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Driver in a car rental party.
/// </summary>
[IsoId("_ZlwOsVN6EfC0lMwgjvMClw")]
[DisplayName("Driver In Party4")]
public record DriverInParty4
{
    /// <summary>
    /// Name of vehicle rental driver.
    /// </summary>
    [IsoId("_ZoVBkVN6EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_sVg5c1N6EfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_sVg5dFN6EfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_sVg5dVN6EfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Address of driver in party.
    /// </summary>
    [IsoId("_ZoVBk1N6EfC0lMwgjvMClw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Contact details of driver in party.
    /// </summary>
    [IsoId("_ZoVBlVN6EfC0lMwgjvMClw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal2? Contact { get; init; }

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_ZoVBl1N6EfC0lMwgjvMClw")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Age of driver.
    /// </summary>
    [IsoId("_ZoVBmVN6EfC0lMwgjvMClw")]
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    public IsoMax2NumericText? Age { get; init; }

    /// <summary>
    /// Credential used by the driver for identification.
    /// </summary>
    [IsoId("_ZoVBm1N6EfC0lMwgjvMClw")]
    [DisplayName("Driver Credential")]
    [IsoXmlTag("DrvrCrdntl")]
    public ValueList<TravelDocument3> DriverCredential { get; init; } = [];

    /// <summary>
    /// Type of driving license.
    /// </summary>
    [IsoId("_ZoVBnVN6EfC0lMwgjvMClw")]
    [DisplayName("License Type")]
    [IsoXmlTag("LicTp")]
    public IsoMax70Text? LicenseType { get; init; }

    /// <summary>
    /// Form of driving license.
    /// </summary>
    [IsoId("_ZoVBn1N6EfC0lMwgjvMClw")]
    [DisplayName("License Form")]
    [IsoXmlTag("LicForm")]
    public PresentationMedium2Code? LicenseForm { get; init; }

    /// <summary>
    /// Identification of the driver license (for example, driver license number).
    /// </summary>
    [IsoId("_ZoVBoVN6EfC0lMwgjvMClw")]
    [DisplayName("License Identification")]
    [IsoXmlTag("LicId")]
    public IsoMax70Text? LicenseIdentification { get; init; }

    /// <summary>
    /// Authority assigning an identification to a driver license.
    /// </summary>
    [IsoId("_ZoVBo1N6EfC0lMwgjvMClw")]
    [DisplayName("License Assigner")]
    [IsoXmlTag("LicAssgnr")]
    public LegalStructure1Code? LicenseAssigner { get; init; }

    /// <summary>
    /// Date of issuance of the driving license.
    /// </summary>
    [IsoId("_ZoVBpVN6EfC0lMwgjvMClw")]
    [DisplayName("License Issuance Date")]
    [IsoXmlTag("LicIssncDt")]
    public IsoISODate? LicenseIssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of the driving license (if and when relevant).
    /// </summary>
    [IsoId("_ZoVBp1N6EfC0lMwgjvMClw")]
    [DisplayName("License Expiration Date")]
    [IsoXmlTag("LicXprtnDt")]
    public IsoISODate? LicenseExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the driver license.
    /// </summary>
    [IsoId("_ZoVBqVN6EfC0lMwgjvMClw")]
    [DisplayName("License Country")]
    [IsoXmlTag("LicCtry")]
    public ISOMax3ACountryCode? LicenseCountry { get; init; }

    /// <summary>
    /// Country Sub Division major issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_ZoVBq1N6EfC0lMwgjvMClw")]
    [DisplayName("License Country Sub Division Major")]
    [IsoXmlTag("LicCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Country Sub Division minor issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_ZoVBrVN6EfC0lMwgjvMClw")]
    [DisplayName("License Country Sub Division Minor")]
    [IsoXmlTag("LicCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Other authority issuing a driver license.
    /// </summary>
    [IsoId("_ZoVBr1N6EfC0lMwgjvMClw")]
    [DisplayName("License Other Authority")]
    [IsoXmlTag("LicOthrAuthrty")]
    public IsoMax16Text? LicenseOtherAuthority { get; init; }
}
