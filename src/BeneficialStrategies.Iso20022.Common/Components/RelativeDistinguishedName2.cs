// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attribute of the certificate service to be put in the certificate extensions, or to be used for the request.
/// </summary>
[IsoId("_W-n0EY4TEeW6h7rGyYlyTg")]
[DisplayName("Relative Distinguished Name")]
public record RelativeDistinguishedName2
{
    /// <summary>
    /// Type of attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_XKBLwY4TEeW6h7rGyYlyTg")]
    [DisplayName("Attribute Type")]
    [IsoXmlTag("AttrTp")]
    public required AttributeType2Code AttributeType { get; init; }

    /// <summary>
    /// Value of the attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_XKBLw44TEeW6h7rGyYlyTg")]
    [DisplayName("Attribute Value")]
    [IsoXmlTag("AttrVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text AttributeValue { get; init; }
}
