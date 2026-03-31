// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format49Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat49Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat49Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat49Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat49Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat49Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat49Choice.Country),
        nameof(SafekeepingPlaceFormat49Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat49Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat49Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat49Choice.Identification),
        nameof(SafekeepingPlaceFormat49Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat49Choice.Proprietary),
        nameof(SafekeepingPlaceFormat49Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat49Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat49Choice.TypeAndIdentification)
    )]
    [IsoId("_kv1FP5t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format49Choice")]
    public abstract record SafekeepingPlaceFormat49Choice_ { }
}
