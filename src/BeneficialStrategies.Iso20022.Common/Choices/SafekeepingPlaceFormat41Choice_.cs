// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format41Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat41Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat41Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat41Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat41Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat41Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat41Choice.Country),
        nameof(SafekeepingPlaceFormat41Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat41Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat41Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat41Choice.Identification),
        nameof(SafekeepingPlaceFormat41Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat41Choice.Proprietary),
        nameof(SafekeepingPlaceFormat41Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat41Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat41Choice.TypeAndIdentification)
    )]
    [IsoId("_O8q28Y-4Ee-nyIlugK8fOQ")]
    [DisplayName("Safekeeping Place Format41Choice")]
    public abstract record SafekeepingPlaceFormat41Choice_ { }
}
