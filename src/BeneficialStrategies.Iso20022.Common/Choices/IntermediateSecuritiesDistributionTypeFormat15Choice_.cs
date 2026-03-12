// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat15Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat15Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat15Choice.Proprietary))]
    [IsoId("_J6Gb4UEGEeWVgfuHGaKtRQ")]
    [DisplayName("Intermediate Securities Distribution Type Format 15 Choice")]
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat15Choice_
    {
    }
}
