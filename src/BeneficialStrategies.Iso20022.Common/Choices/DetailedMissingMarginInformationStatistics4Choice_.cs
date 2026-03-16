// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Detailed information of no margin or outdated margin information.
    /// </summary>
    [KnownType(typeof(DetailedMissingMarginInformationStatistics4Choice.DataSetAction))]
    [KnownType(typeof(DetailedMissingMarginInformationStatistics4Choice.Report))]
    [JsonDerivedType(
        typeof(DetailedMissingMarginInformationStatistics4Choice.DataSetAction),
        nameof(DetailedMissingMarginInformationStatistics4Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(DetailedMissingMarginInformationStatistics4Choice.Report),
        nameof(DetailedMissingMarginInformationStatistics4Choice.Report)
    )]
    [IsoId("_rqy-iVowEe23K4GXSpBSeg")]
    [DisplayName("Detailed Missing Margin Information Statistics 4 Choice")]
    public abstract record DetailedMissingMarginInformationStatistics4Choice_ { }
}
