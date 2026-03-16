// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Safekeeping Place Format53Choice.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat53Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat53Choice.DigitalLedgerIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat53Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat53Choice.Proprietary))]
    [KnownType(typeof(SafekeepingPlaceFormat53Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat53Choice.Country),nameof(SafekeepingPlaceFormat53Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat53Choice.DigitalLedgerIdentification),nameof(SafekeepingPlaceFormat53Choice.DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat53Choice.Identification),nameof(SafekeepingPlaceFormat53Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat53Choice.Proprietary),nameof(SafekeepingPlaceFormat53Choice.Proprietary))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat53Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat53Choice.TypeAndIdentification))]
    [IsoId("_l6VxPZt3Ee-wQIOX0djF2w")]
    [DisplayName("Safekeeping Place Format53Choice")]
    public abstract partial record SafekeepingPlaceFormat53Choice_
    {
    }
}
