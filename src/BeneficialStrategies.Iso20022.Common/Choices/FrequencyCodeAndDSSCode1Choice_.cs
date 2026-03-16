// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the frequency.
    /// </summary>
    [KnownType(typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsCode))]
    [KnownType(typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsDSS))]
    [JsonDerivedType(
        typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsCode),
        nameof(FrequencyCodeAndDSSCode1Choice.FrequencyAsCode)
    )]
    [JsonDerivedType(
        typeof(FrequencyCodeAndDSSCode1Choice.FrequencyAsDSS),
        nameof(FrequencyCodeAndDSSCode1Choice.FrequencyAsDSS)
    )]
    [IsoId("_Q7Vk5dp-Ed-ak6NoX_4Aeg_1533373090")]
    [DisplayName("Frequency Code And DSS Code 1 Choice")]
    public abstract record FrequencyCodeAndDSSCode1Choice_ { }
}
