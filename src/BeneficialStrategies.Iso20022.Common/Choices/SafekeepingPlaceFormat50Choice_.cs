// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format50Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat50Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat50Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat50Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat50Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat50Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat50Choice.Country),nameof(SafekeepingPlaceFormat50Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat50Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat50Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat50Choice.Identification),nameof(SafekeepingPlaceFormat50Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat50Choice.Proprietary),nameof(SafekeepingPlaceFormat50Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat50Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat50Choice.TypeAndIdentification))]
    [IsoId("_kv6mA5t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format50Choice")]
    public abstract partial record SafekeepingPlaceFormat50Choice_
    {
    }
}
