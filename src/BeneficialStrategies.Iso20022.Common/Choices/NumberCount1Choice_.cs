// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of number count type.
    /// </summary>
    [KnownType(typeof(NumberCount1Choice.CurrentInstructionNumber))]
    [KnownType(typeof(NumberCount1Choice.TotalNumber))]
    [JsonDerivedType(typeof(NumberCount1Choice.CurrentInstructionNumber),nameof(NumberCount1Choice.CurrentInstructionNumber))]
    [JsonDerivedType(typeof(NumberCount1Choice.TotalNumber),nameof(NumberCount1Choice.TotalNumber))]
    [IsoId("_QrsmZ9p-Ed-ak6NoX_4Aeg_994582654")]
    [DisplayName("Number Count 1 Choice")]
    public abstract partial record NumberCount1Choice_
    {
    }
}
