// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.</summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat19Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat19Choice.Code), nameof(IntermediateSecuritiesDistributionTypeFormat19Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat19Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat19Choice.Proprietary), nameof(IntermediateSecuritiesDistributionTypeFormat19Choice.Proprietary))]
    [IsoId("_qWCWYaRKEfC9EJoPPbbyNQ")]
    [DisplayName("Intermediate Securities Distribution Type Format 19 Choice")]
    public abstract record IntermediateSecuritiesDistributionTypeFormat19Choice_ { }
}
