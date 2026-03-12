// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Detailed information of abnormal values.
    /// </summary>
    [KnownType(typeof(DetailedAbnormalValuesStatistics4Choice.DataSetAction))]
    [KnownType(typeof(DetailedAbnormalValuesStatistics4Choice.Report))]
    [JsonDerivedType(typeof(DetailedAbnormalValuesStatistics4Choice.DataSetAction),nameof(DetailedAbnormalValuesStatistics4Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedAbnormalValuesStatistics4Choice.Report),nameof(DetailedAbnormalValuesStatistics4Choice.Report))]
    [IsoId("_x32K4VyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Abnormal Values Statistics 4 Choice")]
    public abstract partial record DetailedAbnormalValuesStatistics4Choice_
    {
    }
}
