// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format45Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat45Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat45Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat45Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat45Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat45Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat45Choice.Country),
        nameof(SafekeepingPlaceFormat45Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat45Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat45Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat45Choice.Identification),
        nameof(SafekeepingPlaceFormat45Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat45Choice.Proprietary),
        nameof(SafekeepingPlaceFormat45Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat45Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat45Choice.TypeAndIdentification)
    )]
    [IsoId("_jucghJt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format45Choice")]
    public abstract record SafekeepingPlaceFormat45Choice_ { }
}
