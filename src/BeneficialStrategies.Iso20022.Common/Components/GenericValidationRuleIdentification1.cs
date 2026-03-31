// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the identification of a validation rule.
/// </summary>
[IsoId("_BWCfJdjGEeSD0e0ybx5L5Q")]
[DisplayName("Generic Validation Rule Identification")]
public record GenericValidationRuleIdentification1
{
    /// <summary>
    /// Unique and unambiguous identification of a validation rule.
    /// </summary>
    [IsoId("_BWCfKNjGEeSD0e0ybx5L5Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Further information on the validation rule as identified in the Identification.
    /// </summary>
    [IsoId("_RNyLgN7HEeSaBeqd_btViQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_BWCfJ9jGEeSD0e0ybx5L5Q")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public ValidationRuleSchemeName1Choice_? SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_BWCfJtjGEeSD0e0ybx5L5Q")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
