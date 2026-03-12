// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat17Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat17Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat17Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat17Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat17Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat17Choice.Proprietary))]
    [IsoId("_cjsaoZKQEeWHWpTQn1FFVg")]
    [DisplayName("Intermediate Securities Distribution Type Format 17 Choice")]
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat17Choice_
    {
    }
}
