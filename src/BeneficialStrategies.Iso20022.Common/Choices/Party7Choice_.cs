// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party7Choice.Party))]
    [KnownType(typeof(Party7Choice.Agent))]
    [JsonDerivedType(typeof(Party7Choice.Party),nameof(Party7Choice.Party))]
    [JsonDerivedType(typeof(Party7Choice.Agent),nameof(Party7Choice.Agent))]
    [IsoId("_Pa7iF9p-Ed-ak6NoX_4Aeg_2027182418")]
    [DisplayName("Party 7 Choice")]
    public abstract partial record Party7Choice_
    {
    }
}
