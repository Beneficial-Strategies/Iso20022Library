// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fixing Condition1.
/// </summary>
[IsoId("_q0E0wAlHEe-A-I91qLDlIw")]
[DisplayName("Fixing Condition1")]
public record FixingCondition1
{
    /// <summary>
    /// Location Code.
    /// </summary>
    [DisplayName("Location Code")]
    [IsoXmlTag("")]
    public IsoExact2AlphaNumericText? LocationCode { get; init; }

    /// <summary>
    /// Rate Source.
    /// </summary>
    [DisplayName("Rate Source")]
    [IsoXmlTag("")]
    public required IsoRateSourceText RateSource { get; init; }

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("")]
    public IsoExact4NumericText? Time { get; init; }
}
