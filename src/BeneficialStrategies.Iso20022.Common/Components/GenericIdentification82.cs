// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of a party.
/// </summary>
[IsoId("_o10CASCMEeWJd9HF2tO7BA")]
[DisplayName("Generic Identification")]
public record GenericIdentification82
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity.
    /// </summary>
    [IsoId("_pRU5UyCMEeWJd9HF2tO7BA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identification.
    /// </summary>
    [IsoId("_pRU5VSCMEeWJd9HF2tO7BA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OtherIdentification3Choice_ Type { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_pRU5VyCMEeWJd9HF2tO7BA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }

    /// <summary>
    /// Date at which the identification was issued.
    /// </summary>
    [IsoId("_pRU5WSCMEeWJd9HF2tO7BA")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date at which the identification expires.
    /// </summary>
    [IsoId("_pRU5WyCMEeWJd9HF2tO7BA")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Name of the state, county or country sub-division that issued the identification document.
    /// </summary>
    [IsoId("_g2odEFxlEeW0RaYpOo325g")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? State { get; init; }

    /// <summary>
    /// Country that issued the identification document.
    /// </summary>
    [IsoId("_pRU5XSCMEeWJd9HF2tO7BA")]
    [DisplayName("Issuer Country")]
    [IsoXmlTag("IssrCtry")]
    public CountryCode? IssuerCountry { get; init; }
}
