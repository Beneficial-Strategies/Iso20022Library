// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format46Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat46Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat46Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat46Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat46Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat46Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat46Choice.Country),nameof(SafekeepingPlaceFormat46Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat46Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat46Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat46Choice.Identification),nameof(SafekeepingPlaceFormat46Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat46Choice.Proprietary),nameof(SafekeepingPlaceFormat46Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat46Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat46Choice.TypeAndIdentification))]
    [IsoId("_j2C9dZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format46Choice")]
    public abstract partial record SafekeepingPlaceFormat46Choice_
    {
    }
}
