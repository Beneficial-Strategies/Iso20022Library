// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a data source scheme to determine the revaluation.
    /// </summary>
    [KnownType(typeof(Revaluation1Choice.Indicator))]
    [KnownType(typeof(Revaluation1Choice.Proprietary))]
    [JsonDerivedType(typeof(Revaluation1Choice.Indicator),nameof(Revaluation1Choice.Indicator))]
    [JsonDerivedType(typeof(Revaluation1Choice.Proprietary),nameof(Revaluation1Choice.Proprietary))]
    [IsoId("_Q-eYdNp-Ed-ak6NoX_4Aeg_180533021")]
    [DisplayName("Revaluation 1 Choice")]
    public abstract partial record Revaluation1Choice_
    {
    }
}
