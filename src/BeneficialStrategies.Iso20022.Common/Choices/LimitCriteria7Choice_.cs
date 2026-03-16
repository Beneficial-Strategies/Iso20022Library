// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Criteria7Choice.
    /// </summary>
    [KnownType(typeof(LimitCriteria7Choice.NewCriteria))]
    [KnownType(typeof(LimitCriteria7Choice.QueryName))]
    [JsonDerivedType(typeof(LimitCriteria7Choice.NewCriteria),nameof(LimitCriteria7Choice.NewCriteria))]
    [JsonDerivedType(typeof(LimitCriteria7Choice.QueryName),nameof(LimitCriteria7Choice.QueryName))]
    [IsoId("_zTuFoTEyEe6g-ffJsqGiSA")]
    [DisplayName("Limit Criteria7Choice")]
    public abstract partial record LimitCriteria7Choice_
    {
    }
}
