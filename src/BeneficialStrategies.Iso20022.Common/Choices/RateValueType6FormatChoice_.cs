// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the value of a rate.
    /// </summary>
    [KnownType(typeof(RateValueType6FormatChoice.Code))]
    [KnownType(typeof(RateValueType6FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RateValueType6FormatChoice.Code),nameof(RateValueType6FormatChoice.Code))]
    [JsonDerivedType(typeof(RateValueType6FormatChoice.Proprietary),nameof(RateValueType6FormatChoice.Proprietary))]
    [IsoId("_Rn5I59p-Ed-ak6NoX_4Aeg_-1190812471")]
    [DisplayName("Rate Value Type 6 Format Choice")]
    public abstract partial record RateValueType6FormatChoice_
    {
    }
}
