// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a termination option.
/// </summary>
[IsoId("_GieqUdSaEemZdYGWu384Zw")]
[DisplayName("Compare Termination Option")]
public record CompareTerminationOption2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_GoekodSaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public RepoTerminationOption2Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Goeko9SaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public RepoTerminationOption2Code? Value2 { get; init; }
}
