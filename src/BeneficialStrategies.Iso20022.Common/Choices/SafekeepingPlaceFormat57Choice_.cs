// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format57Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat57Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat57Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat57Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat57Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat57Choice.TypeAndIdentification))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat57Choice.Country),
        nameof(SafekeepingPlaceFormat57Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat57Choice.DigitalLedgerIdentification),
        nameof(SafekeepingPlaceFormat57Choice.DigitalLedgerIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat57Choice.Identification),
        nameof(SafekeepingPlaceFormat57Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat57Choice.Proprietary),
        nameof(SafekeepingPlaceFormat57Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat57Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat57Choice.TypeAndIdentification)
    )]
    [IsoId("_jKuIQ5t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format57Choice")]
    public abstract record SafekeepingPlaceFormat57Choice_ { }
}
