// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the frequency of a CA event.
    /// </summary>
    [KnownType(typeof(CorporateActionFrequencyType1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionFrequencyType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionFrequencyType1FormatChoice.Code),nameof(CorporateActionFrequencyType1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionFrequencyType1FormatChoice.Proprietary),nameof(CorporateActionFrequencyType1FormatChoice.Proprietary))]
    [IsoId("_RmQKJ9p-Ed-ak6NoX_4Aeg_-1912631141")]
    [DisplayName("Corporate Action Frequency Type 1 Format Choice")]
    public abstract partial record CorporateActionFrequencyType1FormatChoice_
    {
    }
}
