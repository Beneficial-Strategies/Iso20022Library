// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a deemed rate type.
    /// </summary>
    [KnownType(typeof(DeemedRateType2Choice.Code))]
    [KnownType(typeof(DeemedRateType2Choice.Proprietary))]
    [JsonDerivedType(typeof(DeemedRateType2Choice.Code),nameof(DeemedRateType2Choice.Code))]
    [JsonDerivedType(typeof(DeemedRateType2Choice.Proprietary),nameof(DeemedRateType2Choice.Proprietary))]
    [IsoId("_r25EEdBbEee0mNiKMkpGNQ")]
    [DisplayName("Deemed Rate Type 2 Choice")]
    public abstract partial record DeemedRateType2Choice_
    {
    }
}
