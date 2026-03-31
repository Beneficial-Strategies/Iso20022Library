// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregated values and volumes of internalised settlements instructions for a specific type of financial instruments, type of transaction, type of clients, and cash transfers.
/// </summary>
[IsoId("_i6SKoO3sEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data Volume")]
public record InternalisationDataVolume1
{
    /// <summary>
    /// Specifies the aggregated volume of internalised settlement instructions, in terms of:
    /// •	Failed transactions,
    /// •	Settled transactions,
    /// •	Total  transactions.
    /// </summary>
    [IsoId("_4q-PwO3sEeaWjpoyrnG6Rw")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber Volume { get; init; }

    /// <summary>
    /// Specifies the aggregated value of internalised settlement instructions, in terms of:
    /// •	Failed transactions,
    /// •	Settled transactions,
    /// •	Total  transactions,
    /// •	Percentage rate.
    /// </summary>
    [IsoId("_7HfVgO3sEeaWjpoyrnG6Rw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveDecimalNumber)]
    public required IsoMax20PositiveDecimalNumber Value { get; init; }
}
