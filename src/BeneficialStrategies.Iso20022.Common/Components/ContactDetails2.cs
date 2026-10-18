// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IContactDetails2"/>
[IsoId("_QJ3rtNp-Ed-ak6NoX_4Aeg_446489744")]
[DisplayName("Contact Details")]
public partial record ContactDetails2
{
    /// <inheritdoc cref="IContactDetails2.NamePrefix"/>
    [IsoId("_QJ3rtdp-Ed-ak6NoX_4Aeg_-1688546792")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; }

    /// <inheritdoc cref="IContactDetails2.Name"/>
    [IsoId("_QJ3rttp-Ed-ak6NoX_4Aeg_446489753")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <inheritdoc cref="IContactDetails2.PhoneNumber"/>
    [IsoId("_QJ3rt9p-Ed-ak6NoX_4Aeg_447410116")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; }

    /// <inheritdoc cref="IContactDetails2.MobileNumber"/>
    [IsoId("_QJ3ruNp-Ed-ak6NoX_4Aeg_880542111")]
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? MobileNumber { get; init; }

    /// <inheritdoc cref="IContactDetails2.FaxNumber"/>
    [IsoId("_QKBcsNp-Ed-ak6NoX_4Aeg_447410147")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; }

    /// <inheritdoc cref="IContactDetails2.EmailAddress"/>
    [IsoId("_QKBcsdp-Ed-ak6NoX_4Aeg_446490084")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? EmailAddress { get; init; }

    /// <inheritdoc cref="IContactDetails2.Other"/>
    [IsoId("_QKBcstp-Ed-ak6NoX_4Aeg_1321060960")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Other { get; init; }
}
