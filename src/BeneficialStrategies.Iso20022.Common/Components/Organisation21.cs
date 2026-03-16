// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_xXY_ESX-EeWJkOUkQWu90g")]
[DisplayName("Organisation")]
public record Organisation21
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_x0S9gSX-EeWJkOUkQWu90g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    [IsoId("_x0S9gyX-EeWJkOUkQWu90g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification72Choice_? Identification { get; init; }

    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_x0S9hSX-EeWJkOUkQWu90g")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; }

    /// <summary>
    /// Country of taxation of an organisation.
    /// </summary>
    [IsoId("_x0S9hyX-EeWJkOUkQWu90g")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_x0S9iSX-EeWJkOUkQWu90g")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_x0S9iyX-EeWJkOUkQWu90g")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_x0S9jSX-EeWJkOUkQWu90g")]
    [DisplayName("Tax Identification Number")]
    [IsoXmlTag("TaxIdNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentificationNumber { get; init; }

    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_x0S9jyX-EeWJkOUkQWu90g")]
    [DisplayName("National Registration Number")]
    [IsoXmlTag("NtlRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NationalRegistrationNumber { get; init; }

    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_x0S9kSX-EeWJkOUkQWu90g")]
    [DisplayName("Corporate Investor Address")]
    [IsoXmlTag("CorpInvstrAdr")]
    public required PostalAddress1 CorporateInvestorAddress { get; init; }
}
