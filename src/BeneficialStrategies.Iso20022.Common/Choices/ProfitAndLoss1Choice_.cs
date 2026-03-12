// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between profit and loss.
    /// </summary>
    [KnownType(typeof(ProfitAndLoss1Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss1Choice.Loss))]
    [JsonDerivedType(typeof(ProfitAndLoss1Choice.Profit),nameof(ProfitAndLoss1Choice.Profit))]
    [JsonDerivedType(typeof(ProfitAndLoss1Choice.Loss),nameof(ProfitAndLoss1Choice.Loss))]
    [IsoId("_Q65gCNp-Ed-ak6NoX_4Aeg_-931034423")]
    [DisplayName("Profit And Loss 1 Choice")]
    public abstract partial record ProfitAndLoss1Choice_
    {
    }
}
