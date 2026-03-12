// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat16Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat16Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat16Choice.Code),nameof(AdditionalBusinessProcessFormat16Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat16Choice.Proprietary),nameof(AdditionalBusinessProcessFormat16Choice.Proprietary))]
    [IsoId("_MkrIodD7Eeetfps_dpxRmg")]
    [DisplayName("Additional Business Process Format 16 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat16Choice_
    {
    }
}
