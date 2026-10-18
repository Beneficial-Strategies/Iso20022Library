// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IContact13"/>
[IsoId("_YinuxzE_Ee62xuUQ2zyZww")]
[DisplayName("Contact13")]
public partial record Contact13
{
    /// <inheritdoc cref="IContact13.Department"/>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    public IsoMax70Text? Department { get; init; }

    /// <inheritdoc cref="IContact13.EmailAddress"/>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <inheritdoc cref="IContact13.EmailPurpose"/>
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    public IsoMax35Text? EmailPurpose { get; init; }

    /// <inheritdoc cref="IContact13.FaxNumber"/>
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <inheritdoc cref="IContact13.JobTitle"/>
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    public IsoMax35Text? JobTitle { get; init; }

    /// <inheritdoc cref="IContact13.MobileNumber"/>
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <inheritdoc cref="IContact13.Name"/>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IContact13.NamePrefix"/>
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; }

    /// <inheritdoc cref="IContact13.Other"/>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <inheritdoc cref="IContact13.PhoneNumber"/>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <inheritdoc cref="IContact13.PreferredMethod"/>
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod2Code? PreferredMethod { get; init; }

    /// <inheritdoc cref="IContact13.Responsibility"/>
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    public IsoMax35Text? Responsibility { get; init; }

    /// <inheritdoc cref="IContact13.URLAddress"/>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax2048Text? URLAddress { get; init; }
}
