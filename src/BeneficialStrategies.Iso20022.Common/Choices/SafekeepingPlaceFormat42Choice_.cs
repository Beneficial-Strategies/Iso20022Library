// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format42Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat42Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat42Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat42Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat42Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat42Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat42Choice.Country),nameof(SafekeepingPlaceFormat42Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat42Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat42Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat42Choice.Identification),nameof(SafekeepingPlaceFormat42Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat42Choice.Proprietary),nameof(SafekeepingPlaceFormat42Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat42Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat42Choice.TypeAndIdentification))]
    [IsoId("_384S04-9Ee-COKgew96POA")]
    [DisplayName("Safekeeping Place Format42Choice")]
    public abstract partial record SafekeepingPlaceFormat42Choice_
    {
    }
}
