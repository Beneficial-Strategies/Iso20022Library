// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities RTGS information.
    /// </summary>
    [KnownType(typeof(SecuritiesRTGS1Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS1Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesRTGS1Choice.Indicator),nameof(SecuritiesRTGS1Choice.Indicator))]
    [JsonDerivedType(typeof(SecuritiesRTGS1Choice.Proprietary),nameof(SecuritiesRTGS1Choice.Proprietary))]
    [IsoId("_QwBFt9p-Ed-ak6NoX_4Aeg_-613904769")]
    [DisplayName("Securities RTGS 1 Choice")]
    public abstract partial record SecuritiesRTGS1Choice_
    {
    }
}
