// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an number and an option number in a code format.
    /// </summary>
    [KnownType(typeof(OptionNumber1Choice.Number))]
    [KnownType(typeof(OptionNumber1Choice.Code))]
    [JsonDerivedType(typeof(OptionNumber1Choice.Number),nameof(OptionNumber1Choice.Number))]
    [JsonDerivedType(typeof(OptionNumber1Choice.Code),nameof(OptionNumber1Choice.Code))]
    [IsoId("_Q1O84dp-Ed-ak6NoX_4Aeg_-1276805181")]
    [DisplayName("Option Number 1 Choice")]
    public abstract partial record OptionNumber1Choice_
    {
    }
}
