// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of amounts.
    /// </summary>
    [KnownType(typeof(Amount1Choice.IncreaseAmount))]
    [KnownType(typeof(Amount1Choice.DecreaseAmount))]
    [JsonDerivedType(typeof(Amount1Choice.IncreaseAmount),nameof(Amount1Choice.IncreaseAmount))]
    [JsonDerivedType(typeof(Amount1Choice.DecreaseAmount),nameof(Amount1Choice.DecreaseAmount))]
    [IsoId("_95C-hHltEeG7BsjMvd1mEw_1631956892")]
    [DisplayName("Amount 1 Choice")]
    public abstract partial record Amount1Choice_
    {
    }
}
