// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the entity issuing the command.
/// </summary>
[IsoId("_tbkJAIqKEeSRT5rEzcAHEw")]
[DisplayName("ATM Command Identification")]
public record ATMCommandIdentification1
{
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_5ym-MIqKEeSRT5rEzcAHEw")]
    [DisplayName("Origin")]
    [IsoXmlTag("Orgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Origin { get; init; }

    /// <summary>
    /// Unique identification of the command for the issuer of the command.
    /// </summary>
    [IsoId("_9G_gEIqKEeSRT5rEzcAHEw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Identification or address of the host performing the command.
    /// </summary>
    [IsoId("_DAS1wIqLEeSRT5rEzcAHEw")]
    [DisplayName("Processor")]
    [IsoXmlTag("Prcr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Processor { get; init; }
}
