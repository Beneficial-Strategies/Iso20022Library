// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the closing of the securities lending contract.
    /// </summary>
    [KnownType(typeof(Reversible1Choice.Code))]
    [KnownType(typeof(Reversible1Choice.Proprietary))]
    [JsonDerivedType(typeof(Reversible1Choice.Code),nameof(Reversible1Choice.Code))]
    [JsonDerivedType(typeof(Reversible1Choice.Proprietary),nameof(Reversible1Choice.Proprietary))]
    [IsoId("_AYOIONokEeC60axPepSq7g_-1179089003")]
    [DisplayName("Reversible 1 Choice")]
    public abstract partial record Reversible1Choice_
    {
    }
}
