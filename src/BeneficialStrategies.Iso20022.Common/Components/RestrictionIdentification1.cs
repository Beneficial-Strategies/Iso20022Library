// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction References applied on the transaction for which the securities settlement condition modification is requested.
/// </summary>
[IsoId("_3d1RINj7EeiHnvcp3FV_5w")]
[DisplayName("Restriction Identification")]
public record RestrictionIdentification1
{
    /// <summary>
    /// Restriction identification removal or addition applied on the transaction expressed as a code.
    /// </summary>
    [IsoId("_DC-vUNj8EeiHnvcp3FV_5w")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RestrictionReference1Code Code { get; init; }

    /// <summary>
    /// Restriction identification applied on the transaction.
    /// </summary>
    [IsoId("_E3muoNj8EeiHnvcp3FV_5w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }
}
