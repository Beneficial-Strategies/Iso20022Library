// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact13.
/// </summary>
[IsoId("_YinuxzE_Ee62xuUQ2zyZww")]
public interface IContact13 : IIsoComponent
{
    /// <summary>
    /// Department.
    /// </summary>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    IsoMax70Text? Department { get; }

    /// <summary>
    /// Email Address.
    /// </summary>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    IsoMax256Text? EmailAddress { get; }

    /// <summary>
    /// Email Purpose.
    /// </summary>
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    IsoMax35Text? EmailPurpose { get; }

    /// <summary>
    /// Fax Number.
    /// </summary>
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    IsoPhoneNumber? FaxNumber { get; }

    /// <summary>
    /// Job Title.
    /// </summary>
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    IsoMax35Text? JobTitle { get; }

    /// <summary>
    /// Mobile Number.
    /// </summary>
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    IsoPhoneNumber? MobileNumber { get; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Name Prefix.
    /// </summary>
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    NamePrefix2Code? NamePrefix { get; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IEnumerable<IOtherContact1> Other { get; }

    /// <summary>
    /// Phone Number.
    /// </summary>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    IsoPhoneNumber? PhoneNumber { get; }

    /// <summary>
    /// Preferred Method.
    /// </summary>
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    PreferredContactMethod2Code? PreferredMethod { get; }

    /// <summary>
    /// Responsibility.
    /// </summary>
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    IsoMax35Text? Responsibility { get; }

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    IsoMax2048Text? URLAddress { get; }
}
