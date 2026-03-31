// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format55Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat55Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat55Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat55Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat55Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat55Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat55Choice.Country),
        nameof(SafekeepingPlaceFormat55Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat55Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat55Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat55Choice.Identification),
        nameof(SafekeepingPlaceFormat55Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat55Choice.Proprietary),
        nameof(SafekeepingPlaceFormat55Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat55Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat55Choice.TypeAndIdentification)
    )]
    [IsoId("_nLX7V5t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format55Choice")]
    public abstract record SafekeepingPlaceFormat55Choice_ { }
}
