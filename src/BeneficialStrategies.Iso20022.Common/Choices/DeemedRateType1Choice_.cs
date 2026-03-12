// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a deemed rate type.
    /// </summary>
    [KnownType(typeof(DeemedRateType1Choice.Code))]
    [KnownType(typeof(DeemedRateType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DeemedRateType1Choice.Code),nameof(DeemedRateType1Choice.Code))]
    [JsonDerivedType(typeof(DeemedRateType1Choice.Proprietary),nameof(DeemedRateType1Choice.Proprietary))]
    [IsoId("_D-CdM5SmEeeh5JjedkaA_g")]
    [DisplayName("Deemed Rate Type 1 Choice")]
    public abstract partial record DeemedRateType1Choice_
    {
    }
}
