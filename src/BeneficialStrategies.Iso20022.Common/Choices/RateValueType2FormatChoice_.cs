// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the value of a rate.
    /// </summary>
    [KnownType(typeof(RateValueType2FormatChoice.Code))]
    [KnownType(typeof(RateValueType2FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(RateValueType2FormatChoice.Code),
        nameof(RateValueType2FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(RateValueType2FormatChoice.Proprietary),
        nameof(RateValueType2FormatChoice.Proprietary)
    )]
    [IsoId("_Rn5I5Np-Ed-ak6NoX_4Aeg_-1085531011")]
    [DisplayName("Rate Value Type 2 Format Choice")]
    public abstract record RateValueType2FormatChoice_ { }
}
