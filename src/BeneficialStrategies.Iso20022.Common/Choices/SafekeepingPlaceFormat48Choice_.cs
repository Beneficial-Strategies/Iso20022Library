// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format48Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat48Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat48Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat48Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat48Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat48Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat48Choice.Country),
        nameof(SafekeepingPlaceFormat48Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat48Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat48Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat48Choice.Identification),
        nameof(SafekeepingPlaceFormat48Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat48Choice.Proprietary),
        nameof(SafekeepingPlaceFormat48Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat48Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat48Choice.TypeAndIdentification)
    )]
    [IsoId("_kV2fTZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format48Choice")]
    public abstract record SafekeepingPlaceFormat48Choice_ { }
}
