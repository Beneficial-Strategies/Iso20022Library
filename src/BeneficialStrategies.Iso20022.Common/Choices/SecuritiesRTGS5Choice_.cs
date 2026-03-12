// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities RTGS information.
    /// </summary>
    [KnownType(typeof(SecuritiesRTGS5Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS5Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesRTGS5Choice.Indicator),nameof(SecuritiesRTGS5Choice.Indicator))]
    [JsonDerivedType(typeof(SecuritiesRTGS5Choice.Proprietary),nameof(SecuritiesRTGS5Choice.Proprietary))]
    [IsoId("_5TJ_AZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities RTGS 5 Choice")]
    public abstract partial record SecuritiesRTGS5Choice_
    {
    }
}
