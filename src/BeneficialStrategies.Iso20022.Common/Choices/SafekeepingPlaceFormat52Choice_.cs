// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format52Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat52Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat52Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat52Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat52Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat52Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat52Choice.Country),nameof(SafekeepingPlaceFormat52Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat52Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat52Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat52Choice.Identification),nameof(SafekeepingPlaceFormat52Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat52Choice.Proprietary),nameof(SafekeepingPlaceFormat52Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat52Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat52Choice.TypeAndIdentification))]
    [IsoId("_l6N065t3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format52Choice")]
    public abstract partial record SafekeepingPlaceFormat52Choice_
    {
    }
}
