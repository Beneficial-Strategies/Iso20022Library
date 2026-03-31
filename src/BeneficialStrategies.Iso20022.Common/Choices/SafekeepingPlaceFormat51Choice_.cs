// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format51Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat51Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat51Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat51Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat51Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat51Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat51Choice.Country),
        nameof(SafekeepingPlaceFormat51Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat51Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat51Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat51Choice.Identification),
        nameof(SafekeepingPlaceFormat51Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat51Choice.Proprietary),
        nameof(SafekeepingPlaceFormat51Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat51Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat51Choice.TypeAndIdentification)
    )]
    [IsoId("_lxWNCZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format51Choice")]
    public abstract record SafekeepingPlaceFormat51Choice_ { }
}
