// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet vehicle driver.
/// </summary>
[IsoId("_5r7WYVN5EfC0lMwgjvMClw")]
[DisplayName("Fleet Driver Data2")]
public record FleetDriverData2
{
    /// <summary>
    /// Name of fleet driver.
    /// </summary>
    [IsoId("_5ugJQVN5EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// Fleet driver identification.
    /// </summary>
    [IsoId("_5ugJQ1N5EfC0lMwgjvMClw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Type of driving license.
    /// </summary>
    [IsoId("_5ugJRVN5EfC0lMwgjvMClw")]
    [DisplayName("License Type")]
    [IsoXmlTag("LicTp")]
    public IsoMax70Text? LicenseType { get; init; }

    /// <summary>
    /// Form of driving license.
    /// </summary>
    [IsoId("_5ugJR1N5EfC0lMwgjvMClw")]
    [DisplayName("License Form")]
    [IsoXmlTag("LicForm")]
    public PresentationMedium2Code? LicenseForm { get; init; }

    /// <summary>
    /// Identification of the driver license (for example, driver license number).
    /// </summary>
    [IsoId("_5ugJSVN5EfC0lMwgjvMClw")]
    [DisplayName("License Identification")]
    [IsoXmlTag("LicId")]
    public IsoMax70Text? LicenseIdentification { get; init; }

    /// <summary>
    /// Authority assigning an identification to a driver license.
    /// </summary>
    [IsoId("_5ugJS1N5EfC0lMwgjvMClw")]
    [DisplayName("License Assigner")]
    [IsoXmlTag("LicAssgnr")]
    public LegalStructure1Code? LicenseAssigner { get; init; }

    /// <summary>
    /// Date of issuance of the driving license.
    /// </summary>
    [IsoId("_5ugJTVN5EfC0lMwgjvMClw")]
    [DisplayName("License Issuance Date")]
    [IsoXmlTag("LicIssncDt")]
    public IsoISODate? LicenseIssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of the driving license (if and when relevant).
    /// </summary>
    [IsoId("_5ugJT1N5EfC0lMwgjvMClw")]
    [DisplayName("License Expiration Date")]
    [IsoXmlTag("LicXprtnDt")]
    public IsoISODate? LicenseExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the driver license.
    /// </summary>
    [IsoId("_5ugJUVN5EfC0lMwgjvMClw")]
    [DisplayName("License Country")]
    [IsoXmlTag("LicCtry")]
    public ISOMax3ACountryCode? LicenseCountry { get; init; }

    /// <summary>
    /// Country Sub Division major issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_5ugJU1N5EfC0lMwgjvMClw")]
    [DisplayName("License Country Sub Division Major")]
    [IsoXmlTag("LicCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Country Sub Division minor issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_5ugJVVN5EfC0lMwgjvMClw")]
    [DisplayName("License Country Sub Division Minor")]
    [IsoXmlTag("LicCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Other authority issuing a driver license.
    /// </summary>
    [IsoId("_5ugJV1N5EfC0lMwgjvMClw")]
    [DisplayName("License Other Authority")]
    [IsoXmlTag("LicOthrAuthrty")]
    public IsoMax16Text? LicenseOtherAuthority { get; init; }

    /// <summary>
    /// Contains the employer information.
    /// </summary>
    [IsoId("_5ugJWVN5EfC0lMwgjvMClw")]
    [DisplayName("Employer")]
    [IsoXmlTag("Mplyr")]
    public IsoMax70Text? Employer { get; init; }

    /// <summary>
    /// Contains the employee identification number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_5ugJW1N5EfC0lMwgjvMClw")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    public IsoMax70Text? EmployeeIdentification { get; init; }

    /// <summary>
    /// Contains the fleet driver's department number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_5ugJXVN5EfC0lMwgjvMClw")]
    [DisplayName("Department Number")]
    [IsoXmlTag("DeptNb")]
    public IsoMax35Text? DepartmentNumber { get; init; }

    /// <summary>
    /// Additional identification used for the driver.
    /// </summary>
    [IsoId("_5ugJX1N5EfC0lMwgjvMClw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<TravelDocument3> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_5ugJYVN5EfC0lMwgjvMClw")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_5ugJY1N5EfC0lMwgjvMClw")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_5ugJZVN5EfC0lMwgjvMClw")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
