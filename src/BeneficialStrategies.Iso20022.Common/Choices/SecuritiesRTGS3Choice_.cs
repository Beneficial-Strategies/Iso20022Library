// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities RTGS information.
    /// </summary>
    [KnownType(typeof(SecuritiesRTGS3Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesRTGS3Choice.Indicator),
        nameof(SecuritiesRTGS3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(SecuritiesRTGS3Choice.Proprietary),
        nameof(SecuritiesRTGS3Choice.Proprietary)
    )]
    [IsoId("_AZabAdokEeC60axPepSq7g_-1172529595")]
    [DisplayName("Securities RTGS 3 Choice")]
    public abstract record SecuritiesRTGS3Choice_ { }
}
