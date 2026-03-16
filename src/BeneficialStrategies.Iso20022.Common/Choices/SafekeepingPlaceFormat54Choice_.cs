// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format54Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat54Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat54Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat54Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat54Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat54Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat54Choice.Country),nameof(SafekeepingPlaceFormat54Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat54Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat54Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat54Choice.Identification),nameof(SafekeepingPlaceFormat54Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat54Choice.Proprietary),nameof(SafekeepingPlaceFormat54Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat54Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat54Choice.TypeAndIdentification))]
    [IsoId("_nF16aZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format54Choice")]
    public abstract partial record SafekeepingPlaceFormat54Choice_
    {
    }
}
