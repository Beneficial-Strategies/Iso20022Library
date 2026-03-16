// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of intermediate security distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecurityDistributionType1FormatChoice.Code))]
    [KnownType(typeof(IntermediateSecurityDistributionType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(IntermediateSecurityDistributionType1FormatChoice.Code),
        nameof(IntermediateSecurityDistributionType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(IntermediateSecurityDistributionType1FormatChoice.Proprietary),
        nameof(IntermediateSecurityDistributionType1FormatChoice.Proprietary)
    )]
    [IsoId("_Rms2Etp-Ed-ak6NoX_4Aeg_-820578542")]
    [DisplayName("Intermediate Security Distribution Type 1 Format Choice")]
    public abstract record IntermediateSecurityDistributionType1FormatChoice_ { }
}
