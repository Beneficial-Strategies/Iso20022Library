// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact13.
/// </summary>
[IsoId("_YinuxzE_Ee62xuUQ2zyZww")]
[DisplayName("Contact13")]
public record Contact13
{
    /// <summary>
    /// Name Prefix.
    /// </summary>
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max140Text? Name { get; init; }

    /// <summary>
    /// Phone Number.
    /// </summary>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public PhoneNumber? PhoneNumber { get; init; }

    /// <summary>
    /// Mobile Number.
    /// </summary>
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    public PhoneNumber? MobileNumber { get; init; }

    /// <summary>
    /// Fax Number.
    /// </summary>
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    public PhoneNumber? FaxNumber { get; init; }

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public Max2048Text? URLAddress { get; init; }

    /// <summary>
    /// Email Address.
    /// </summary>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public Max256Text? EmailAddress { get; init; }

    /// <summary>
    /// Email Purpose.
    /// </summary>
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    public Max35Text? EmailPurpose { get; init; }

    /// <summary>
    /// Job Title.
    /// </summary>
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    public Max35Text? JobTitle { get; init; }

    /// <summary>
    /// Responsibility.
    /// </summary>
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    public Max35Text? Responsibility { get; init; }

    /// <summary>
    /// Department.
    /// </summary>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    public Max70Text? Department { get; init; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <summary>
    /// Preferred Method.
    /// </summary>
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod2Code? PreferredMethod { get; init; }
}
