// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of amount.
    /// </summary>
    [KnownType(typeof(TypeOfAmount1Choice.Code))]
    [KnownType(typeof(TypeOfAmount1Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfAmount1Choice.Code), nameof(TypeOfAmount1Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfAmount1Choice.Proprietary),
        nameof(TypeOfAmount1Choice.Proprietary)
    )]
    [IsoId("_aq5l4F24EeiFXdiLi_Nf4A")]
    [DisplayName("Type Of Amount 1 Choice")]
    public abstract record TypeOfAmount1Choice_ { }
}
