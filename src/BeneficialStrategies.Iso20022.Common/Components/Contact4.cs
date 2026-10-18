// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IContact4"/>
[IsoId("_q1hc0W4_EeiU9cctagi5ow")]
[DisplayName("Contact")]
public partial record Contact4
{
    /// <inheritdoc cref="IContact4.NamePrefix"/>
    [IsoId("_q-wRU24_EeiU9cctagi5ow")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; }

    /// <inheritdoc cref="IContact4.Name"/>
    [IsoId("_q-wRVW4_EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IContact4.PhoneNumber"/>
    [IsoId("_q-wRV24_EeiU9cctagi5ow")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <inheritdoc cref="IContact4.MobileNumber"/>
    [IsoId("_q-wRWW4_EeiU9cctagi5ow")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <inheritdoc cref="IContact4.FaxNumber"/>
    [IsoId("_q-wRW24_EeiU9cctagi5ow")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <inheritdoc cref="IContact4.EmailAddress"/>
    [IsoId("_q-wRXW4_EeiU9cctagi5ow")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? EmailAddress { get; init; }

    /// <inheritdoc cref="IContact4.EmailPurpose"/>
    [IsoId("_6a6f0b18Eeiut6mmSKzDFQ")]
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EmailPurpose { get; init; }

    /// <inheritdoc cref="IContact4.JobTitle"/>
    [IsoId("_65ANYXRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? JobTitle { get; init; }

    /// <inheritdoc cref="IContact4.Responsibility"/>
    [IsoId("_65ANYnRnEeiH1ZOt2UD8vQ")]
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Responsibility { get; init; }

    /// <inheritdoc cref="IContact4.Department"/>
    [IsoId("_65ANY3RnEeiH1ZOt2UD8vQ")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <inheritdoc cref="IContact4.Other"/>
    [IsoId("_A96WInRoEeiH1ZOt2UD8vQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <inheritdoc cref="IContact4.PreferredMethod"/>
    [IsoId("_A96WI3RoEeiH1ZOt2UD8vQ")]
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod1Code? PreferredMethod { get; init; }
}
