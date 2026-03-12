// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party12Choice.Party))]
    [KnownType(typeof(Party12Choice.Agent))]
    [JsonDerivedType(typeof(Party12Choice.Party),nameof(Party12Choice.Party))]
    [JsonDerivedType(typeof(Party12Choice.Agent),nameof(Party12Choice.Agent))]
    [IsoId("_4MlDgNFmEd-Lq65KLayVeg")]
    [DisplayName("Party 12 Choice")]
    public abstract partial record Party12Choice_
    {
    }
}
