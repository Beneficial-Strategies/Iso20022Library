// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party35Choice.Party))]
    [KnownType(typeof(Party35Choice.Agent))]
    [JsonDerivedType(typeof(Party35Choice.Party),nameof(Party35Choice.Party))]
    [JsonDerivedType(typeof(Party35Choice.Agent),nameof(Party35Choice.Agent))]
    [IsoId("_mfIvwbTREeeyuKckOGlwuA")]
    [DisplayName("Party 35 Choice")]
    public abstract partial record Party35Choice_
    {
    }
}
