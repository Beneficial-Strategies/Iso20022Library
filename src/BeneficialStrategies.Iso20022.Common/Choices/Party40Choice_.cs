// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party40Choice.Party))]
    [KnownType(typeof(Party40Choice.Agent))]
    [JsonDerivedType(typeof(Party40Choice.Party),nameof(Party40Choice.Party))]
    [JsonDerivedType(typeof(Party40Choice.Agent),nameof(Party40Choice.Agent))]
    [IsoId("_8KfE5248EeiU9cctagi5ow")]
    [DisplayName("Party 40 Choice")]
    public abstract partial record Party40Choice_
    {
    }
}
