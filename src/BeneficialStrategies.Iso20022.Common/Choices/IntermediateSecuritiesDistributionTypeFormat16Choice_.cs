// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary))]
    [IsoId("_fh8v0UGPEeWqy4niLuXETA")]
    [DisplayName("Intermediate Securities Distribution Type Format 16 Choice")]
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat16Choice_
    {
    }
}
