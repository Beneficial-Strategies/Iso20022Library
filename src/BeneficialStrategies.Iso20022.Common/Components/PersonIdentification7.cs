// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of unique and unambiguous ways to identify a person.
/// </summary>
[IsoId("_De5uQS_mEeO4w-IWHJMI9g")]
[DisplayName("Person Identification")]
public record PersonIdentification7
{
    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// </summary>
    [IsoId("_apyOkC_oEeO4w-IWHJMI9g")]
    [DisplayName("Drivers License Number")]
    [IsoXmlTag("DrvrsLicNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DriversLicenseNumber { get; init; }

    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    [IsoId("_kk_zIC_rEeO4w-IWHJMI9g")]
    [DisplayName("Customer Number")]
    [IsoXmlTag("CstmrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerNumber { get; init; }

    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_v1poAC_rEeO4w-IWHJMI9g")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SocialSecurityNumber { get; init; }

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_4QqFcC_rEeO4w-IWHJMI9g")]
    [DisplayName("Alien Registration Number")]
    [IsoXmlTag("AlnRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AlienRegistrationNumber { get; init; }

    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_9W60oC_rEeO4w-IWHJMI9g")]
    [DisplayName("Passport Number")]
    [IsoXmlTag("PsptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PassportNumber { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_Go-O0C_sEeO4w-IWHJMI9g")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_Lx6ekC_sEeO4w-IWHJMI9g")]
    [DisplayName("Identity Card Number")]
    [IsoXmlTag("IdntyCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IdentityCardNumber { get; init; }

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_Qic1YC_sEeO4w-IWHJMI9g")]
    [DisplayName("Employer Identification Number")]
    [IsoXmlTag("MplyrIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EmployerIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned to an employee by a employer.
    /// </summary>
    [IsoId("_WV728C_sEeO4w-IWHJMI9g")]
    [DisplayName("Employee Identification Number")]
    [IsoXmlTag("MplyeeIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EmployeeIdentificationNumber { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_T1UacEtuEeOC3MFxIpMwug")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_DtoGwy_mEeO4w-IWHJMI9g")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_DtoGxS_mEeO4w-IWHJMI9g")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericIdentification4? Other { get; init; }
}
