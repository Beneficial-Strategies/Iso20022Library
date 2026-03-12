// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType50Choice.Code))]
    [KnownType(typeof(RateType50Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType50Choice.Code),nameof(RateType50Choice.Code))]
    [JsonDerivedType(typeof(RateType50Choice.Proprietary),nameof(RateType50Choice.Proprietary))]
    [IsoId("_ckN-05KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 50 Choice")]
    public abstract partial record RateType50Choice_
    {
    }
}
