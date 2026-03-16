// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aggregated values and volumes of settlements instructions for a specific type of financial instruments, type of transaction, type of clients, and cash transfers.
/// </summary>
[IsoId("_rv5NIY0SEemUAO64Q252gQ")]
[DisplayName("Settlement Data Volume")]
public record SettlementDataVolume2
{
    /// <summary>
    /// Specifies the aggregated volume of settlement instructions, in terms of failed, settled transactions and total transactions.
    /// </summary>
    [IsoId("_r1TRkY0SEemUAO64Q252gQ")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber Volume { get; init; }

    /// <summary>
    /// Specifies the aggregated value of settlement instructions, in terms of failed, settled transactions and total transactions.
    /// </summary>
    [IsoId("_r1TRk40SEemUAO64Q252gQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveDecimalNumber)]
    public required IsoMax20PositiveDecimalNumber Value { get; init; }
}
