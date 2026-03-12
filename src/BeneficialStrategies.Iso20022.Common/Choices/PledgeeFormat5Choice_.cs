// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat5Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat5Choice.Identification))]
    [KnownType(typeof(PledgeeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(PledgeeFormat5Choice.TypeAndIdentification),nameof(PledgeeFormat5Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat5Choice.Identification),nameof(PledgeeFormat5Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat5Choice.Proprietary),nameof(PledgeeFormat5Choice.Proprietary))]
    [IsoId("_YdRwN9LGEeiN28wlpBQScw")]
    [DisplayName("Pledgee Format 5 Choice")]
    public abstract partial record PledgeeFormat5Choice_
    {
    }
}
