// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat4Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat4Choice.Identification))]
    [KnownType(typeof(PledgeeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PledgeeFormat4Choice.TypeAndIdentification),
        nameof(PledgeeFormat4Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(PledgeeFormat4Choice.Identification),
        nameof(PledgeeFormat4Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(PledgeeFormat4Choice.Proprietary),
        nameof(PledgeeFormat4Choice.Proprietary)
    )]
    [IsoId("_W1AgMZj3EeWn2ur3BXxtdg")]
    [DisplayName("Pledgee Format 4 Choice")]
    public abstract record PledgeeFormat4Choice_ { }
}
