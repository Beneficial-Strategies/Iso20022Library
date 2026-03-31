// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Driver In Party3.
/// </summary>
[IsoId("_gN5CUXTgEe6h-4AZRg9sVg")]
[DisplayName("Driver In Party3")]
public record DriverInParty3
{
    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Age.
    /// </summary>
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    public IsoMax2NumericText? Age { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal1? Contact { get; init; }

    /// <summary>
    /// Date Of Birth.
    /// </summary>
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Driver Credential.
    /// </summary>
    [DisplayName("Driver Credential")]
    [IsoXmlTag("DrvrCrdntl")]
    public ValueList<TravelDocument2> DriverCredential { get; init; } = [];

    /// <summary>
    /// License Assigner.
    /// </summary>
    [DisplayName("License Assigner")]
    [IsoXmlTag("LicAssgnr")]
    public LegalStructure1Code? LicenseAssigner { get; init; }

    /// <summary>
    /// License Country.
    /// </summary>
    [DisplayName("License Country")]
    [IsoXmlTag("LicCtry")]
    public ISOMax3ACountryCode? LicenseCountry { get; init; }

    /// <summary>
    /// License Country Sub Division Major.
    /// </summary>
    [DisplayName("License Country Sub Division Major")]
    [IsoXmlTag("LicCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// License Country Sub Division Minor.
    /// </summary>
    [DisplayName("License Country Sub Division Minor")]
    [IsoXmlTag("LicCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// License Expiration Date.
    /// </summary>
    [DisplayName("License Expiration Date")]
    [IsoXmlTag("LicXprtnDt")]
    public IsoISODate? LicenseExpirationDate { get; init; }

    /// <summary>
    /// License Form.
    /// </summary>
    [DisplayName("License Form")]
    [IsoXmlTag("LicForm")]
    public PresentationMedium2Code? LicenseForm { get; init; }

    /// <summary>
    /// License Identification.
    /// </summary>
    [DisplayName("License Identification")]
    [IsoXmlTag("LicId")]
    public IsoMax70Text? LicenseIdentification { get; init; }

    /// <summary>
    /// License Issuance Date.
    /// </summary>
    [DisplayName("License Issuance Date")]
    [IsoXmlTag("LicIssncDt")]
    public IsoISODate? LicenseIssuanceDate { get; init; }

    /// <summary>
    /// License Other Authority.
    /// </summary>
    [DisplayName("License Other Authority")]
    [IsoXmlTag("LicOthrAuthrty")]
    public IsoMax16Text? LicenseOtherAuthority { get; init; }

    /// <summary>
    /// License Type.
    /// </summary>
    [DisplayName("License Type")]
    [IsoXmlTag("LicTp")]
    public IsoMax70Text? LicenseType { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }
}
