// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities RTGS information.
    /// </summary>
    [KnownType(typeof(SecuritiesRTGS4Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesRTGS4Choice.Indicator),
        nameof(SecuritiesRTGS4Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(SecuritiesRTGS4Choice.Proprietary),
        nameof(SecuritiesRTGS4Choice.Proprietary)
    )]
    [IsoId("_90cwnzqEEeWVrPy0StzzSg")]
    [DisplayName("Securities RTGS 4 Choice")]
    public abstract record SecuritiesRTGS4Choice_ { }
}
