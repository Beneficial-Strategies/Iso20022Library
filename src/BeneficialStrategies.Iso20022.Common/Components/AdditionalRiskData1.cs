// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional data related to risk assessment of the transaction.
/// </summary>
[IsoId("_QlXxgEbQEeeIjf8aP9KbJA")]
[DisplayName("Additional Risk Data")]
public record AdditionalRiskData1
{
    /// <summary>
    /// Identification of the additional risk data type related to the transaction.
    /// </summary>
    [IsoId("_neNxgEbQEeeIjf8aP9KbJA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Data value of the additional risk data associated with the transaction.
    /// </summary>
    [IsoId("_wBlgwEbQEeeIjf8aP9KbJA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max10KText)]
    [StringLength(maximumLength: 10000, MinimumLength = 1)]
    public required IsoMax10KText Value { get; init; }
}
