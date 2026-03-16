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
[IsoId("_6nwg0UKSEeWuG5hmkcJWSQ")]
[DisplayName("Organisation")]
public record Organisation22
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_7DbwMUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Name of the organisation in short form.
    /// </summary>
    [IsoId("_yyVfkVxjEeWvPv3PXpS3fw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    [IsoId("_7DbwM0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification72Choice_? Identification { get; init; }

    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_7DbwNUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_7DbwN0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Purpose { get; init; }

    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_7DbwOUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Registration Country")]
    [IsoXmlTag("RegnCtry")]
    public CountryCode? RegistrationCountry { get; init; }

    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_7DbwO0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; }

    /// <summary>
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    [IsoId("__dOlgUKTEeWuG5hmkcJWSQ")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    public ValueList<ModificationScope34> ModifiedPostalAddress { get; init; } = [];

    /// <summary>
    /// Type of organisation.
    /// </summary>
    [IsoId("_7DbwRUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Type Of Organisation")]
    [IsoXmlTag("TpOfOrg")]
    public OrganisationType1Choice_? TypeOfOrganisation { get; init; }
}
