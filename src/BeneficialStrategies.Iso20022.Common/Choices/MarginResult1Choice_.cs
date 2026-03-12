// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on the margin result.
    /// </summary>
    [KnownType(typeof(MarginResult1Choice.ExcessAmount))]
    [KnownType(typeof(MarginResult1Choice.DeficitAmount))]
    [JsonDerivedType(typeof(MarginResult1Choice.ExcessAmount),nameof(MarginResult1Choice.ExcessAmount))]
    [JsonDerivedType(typeof(MarginResult1Choice.DeficitAmount),nameof(MarginResult1Choice.DeficitAmount))]
    [IsoId("_Qk1wddp-Ed-ak6NoX_4Aeg_-1613861504")]
    [DisplayName("Margin Result 1 Choice")]
    public abstract partial record MarginResult1Choice_
    {
    }
}
