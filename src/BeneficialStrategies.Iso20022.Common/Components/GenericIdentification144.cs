// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary information related to a balance.
/// </summary>
[IsoId("_5W2ye5NLEeWGlc8L7oPDIg")]
[DisplayName("Generic Identification")]
public record GenericIdentification144
{
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    [IsoId("_5W2yfZNLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText Identification { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_5W2yf5NLEeWGlc8L7oPDIg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText Issuer { get; init; }

    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    [IsoId("_5W2ygZNLEeWGlc8L7oPDIg")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? SchemeName { get; init; }

    /// <summary>
    /// Value of the balance.
    /// </summary>
    [IsoId("_5W2yg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Balance { get; init; }
}
