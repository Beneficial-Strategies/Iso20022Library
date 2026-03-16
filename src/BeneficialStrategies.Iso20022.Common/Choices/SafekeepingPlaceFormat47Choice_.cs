// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format47Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat47Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat47Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat47Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat47Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat47Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat47Choice.Country),
        nameof(SafekeepingPlaceFormat47Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat47Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat47Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat47Choice.Identification),
        nameof(SafekeepingPlaceFormat47Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat47Choice.Proprietary),
        nameof(SafekeepingPlaceFormat47Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat47Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat47Choice.TypeAndIdentification)
    )]
    [IsoId("_kLpaNpt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format47Choice")]
    public abstract record SafekeepingPlaceFormat47Choice_ { }
}
