// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat6Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat6Choice.Identification))]
    [KnownType(typeof(PledgeeFormat6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PledgeeFormat6Choice.TypeAndIdentification),
        nameof(PledgeeFormat6Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(PledgeeFormat6Choice.Identification),
        nameof(PledgeeFormat6Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(PledgeeFormat6Choice.Proprietary),
        nameof(PledgeeFormat6Choice.Proprietary)
    )]
    [IsoId("_Z07smffVEeiNZp_PtLohLw")]
    [DisplayName("Pledgee Format 6 Choice")]
    public abstract record PledgeeFormat6Choice_ { }
}
