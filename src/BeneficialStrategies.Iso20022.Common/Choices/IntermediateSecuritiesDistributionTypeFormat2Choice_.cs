// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Proprietary))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat2Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat2Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat2Choice.Proprietary))]
    [IsoId("_Q0L0Atp-Ed-ak6NoX_4Aeg_-965201377")]
    [DisplayName("Intermediate Securities Distribution Type Format 2 Choice")]
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat2Choice_
    {
    }
}
