// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of incorrect information.
/// </summary>
[IsoId("_f2qNhUgoEeaGKYpLDboHPQ")]
[DisplayName("Unable To Apply Incorrect")]
public record UnableToApplyIncorrect1
{
    /// <summary>
    /// Specifies the missing information in a coded form.
    /// </summary>
    [IsoId("_q8AC40grEeaGKYpLDboHPQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required UnableToApplyIncorrectInformation4Code Code { get; init; }

    /// <summary>
    /// Further details about the incorrect information.
    /// </summary>
    [IsoId("_q8AC5EgrEeaGKYpLDboHPQ")]
    [DisplayName("Additional Incorrect Information")]
    [IsoXmlTag("AddtlIncrrctInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalIncorrectInformation { get; init; }
}
