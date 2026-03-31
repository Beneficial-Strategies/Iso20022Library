// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type, date and version of the agreement.
/// </summary>
[IsoId("_bedvoJUTEea7vKctaoIyEQ")]
[DisplayName("Agreement Conditions")]
public record AgreementConditions1
{
    /// <summary>
    /// Specifies the type of agreement.
    /// </summary>
    [IsoId("_LS4cYJUUEea7vKctaoIyEQ")]
    [DisplayName("Agreement Code")]
    [IsoXmlTag("AgrmtCd")]
    [IsoSimpleType(IsoSimpleType.Max6AlphaText)]
    public required IsoMax6AlphaText AgreementCode { get; init; }

    /// <summary>
    /// Specifies the date of the agreement.
    /// </summary>
    [IsoId("_6QcZoJUUEea7vKctaoIyEQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Specifies the version of the agreement.
    /// </summary>
    [IsoId("_-vvPcJUUEea7vKctaoIyEQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? Version { get; init; }
}
