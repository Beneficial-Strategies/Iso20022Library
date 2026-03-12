// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat5Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat5Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat5Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat5Choice.Proprietary))]
    [IsoId("_waQgQeAYEd-D2OAFXdoRmA")]
    [DisplayName("Intermediate Securities Distribution Type Format 5 Choice")]
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat5Choice_
    {
    }
}
