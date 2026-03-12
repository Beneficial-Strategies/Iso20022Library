// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice46Choice.Code))]
    [KnownType(typeof(TypeOfPrice46Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice46Choice.Code),nameof(TypeOfPrice46Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice46Choice.Proprietary),nameof(TypeOfPrice46Choice.Proprietary))]
    [IsoId("_pc5UMDhfEeamLZQeccJa7w")]
    [DisplayName("Type Of Price 46 Choice")]
    public abstract partial record TypeOfPrice46Choice_
    {
    }
}
