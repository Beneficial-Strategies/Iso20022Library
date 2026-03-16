// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format56Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat56Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat56Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat56Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat56Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat56Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat56Choice.Country),nameof(SafekeepingPlaceFormat56Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat56Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat56Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat56Choice.Identification),nameof(SafekeepingPlaceFormat56Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat56Choice.Proprietary),nameof(SafekeepingPlaceFormat56Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat56Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat56Choice.TypeAndIdentification))]
    [IsoId("_nLkvl5t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format56Choice")]
    public abstract partial record SafekeepingPlaceFormat56Choice_
    {
    }
}
