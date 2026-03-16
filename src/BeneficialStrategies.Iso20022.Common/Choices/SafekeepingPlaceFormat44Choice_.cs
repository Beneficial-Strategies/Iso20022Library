// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format44Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat44Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat44Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat44Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat44Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat44Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat44Choice.Country),nameof(SafekeepingPlaceFormat44Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat44Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat44Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat44Choice.Identification),nameof(SafekeepingPlaceFormat44Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat44Choice.Proprietary),nameof(SafekeepingPlaceFormat44Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat44Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat44Choice.TypeAndIdentification))]
    [IsoId("_jhnldZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format44Choice")]
    public abstract partial record SafekeepingPlaceFormat44Choice_
    {
    }
}
