// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice45Choice.Code))]
    [KnownType(typeof(TypeOfPrice45Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice45Choice.Code),nameof(TypeOfPrice45Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice45Choice.Proprietary),nameof(TypeOfPrice45Choice.Proprietary))]
    [IsoId("_8bg2hZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price 45 Choice")]
    public abstract partial record TypeOfPrice45Choice_
    {
    }
}
