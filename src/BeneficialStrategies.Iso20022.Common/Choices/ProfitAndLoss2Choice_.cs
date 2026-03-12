// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between profit and loss.
    /// </summary>
    [KnownType(typeof(ProfitAndLoss2Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss2Choice.Loss))]
    [JsonDerivedType(typeof(ProfitAndLoss2Choice.Profit),nameof(ProfitAndLoss2Choice.Profit))]
    [JsonDerivedType(typeof(ProfitAndLoss2Choice.Loss),nameof(ProfitAndLoss2Choice.Loss))]
    [IsoId("_NDhRoWYDEeaJx-BUPcSWQA")]
    [DisplayName("Profit And Loss 2 Choice")]
    public abstract partial record ProfitAndLoss2Choice_
    {
    }
}
