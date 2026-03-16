// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification273.
/// </summary>
[IsoId("_xbbHTTEyEe6g-ffJsqGiSA")]
[DisplayName("Party Identification273")]
public record PartyIdentification273
{
    /// <summary>
    /// Contact Details.
    /// </summary>
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public Contact13? ContactDetails { get; init; }

    /// <summary>
    /// Country Of Residence.
    /// </summary>
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required Party56Choice_ Identification { get; init; }

    /// <summary>
    /// Legal Name.
    /// </summary>
    [DisplayName("Legal Name")]
    [IsoXmlTag("LglNm")]
    public IsoMax140Text? LegalName { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required IsoMax140Text Name { get; init; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress27? PostalAddress { get; init; }
}
