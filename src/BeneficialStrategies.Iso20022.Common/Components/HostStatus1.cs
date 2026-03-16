// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// State of a Host.
/// </summary>
[IsoId("_N2O4cN6MEeiwsev40qZGEQ")]
[DisplayName("Host Status")]
public record HostStatus1
{
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_Teh9sN6MEeiwsev40qZGEQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AcquirerIdentification { get; init; }

    /// <summary>
    /// Indicate if a Host is reachable.
    /// </summary>
    [IsoId("_WWtEsN6MEeiwsev40qZGEQ")]
    [DisplayName("Reachable")]
    [IsoXmlTag("Rchbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? Reachable { get; init; }
}
