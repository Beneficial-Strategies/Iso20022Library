// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by an organisation, to unambiguously identify a party.
/// </summary>
[IsoId("_IV_5UEkJEeaOe8w0NJ11wQ")]
[DisplayName("Organisation Identification")]
public record OrganisationIdentification28
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_OYEwgEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_R8TFMEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_WSgQcEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OrganisationIdentification8? Identification { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_cnmxUEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Set of elements used to indicate how to contact the party.
    /// </summary>
    [IsoId("_fIbIQEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public required ContactDetails2 ContactDetails { get; init; }
}
