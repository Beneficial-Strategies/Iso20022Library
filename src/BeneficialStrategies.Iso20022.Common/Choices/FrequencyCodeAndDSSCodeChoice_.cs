// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the frequency.
    /// </summary>
    [KnownType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode))]
    [KnownType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS))]
    [JsonDerivedType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode),nameof(FrequencyCodeAndDSSCodeChoice.FrequencyAsCode))]
    [JsonDerivedType(typeof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS),nameof(FrequencyCodeAndDSSCodeChoice.FrequencyAsDSS))]
    [IsoId("_UuhioNp-Ed-ak6NoX_4Aeg_400175868")]
    [DisplayName("Frequency Code And DSS Code Choice")]
    public abstract partial record FrequencyCodeAndDSSCodeChoice_
    {
    }
}
