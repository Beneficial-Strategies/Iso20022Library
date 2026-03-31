// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZP6DINp-Ed-ak6NoX_4Aeg_1021868679")]
[Description(@"Specifies the type of standing instruction.")]
[Derivations(typeof(StandingInstructionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StandingInstructionTypeCode>))]
#endif
public enum StandingInstructionTypeCode
{
    /// <summary>
    /// Standing instruction for a cash distribution.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ZP6DIdp-Ed-ak6NoX_4Aeg_1046801721")]
    [Description(@"Standing instruction for a cash distribution.")]
    CashDistribution,

    /// <summary>
    /// Standing instruction for the payment modality, gross or net.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_ZP6DItp-Ed-ak6NoX_4Aeg_1046801722")]
    [Description(@"Standing instruction for the payment modality, gross or net.")]
    GrossNet,

    /// <summary>
    /// Standing instruction for a securities distribution.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZP6DI9p-Ed-ak6NoX_4Aeg_1046801751")]
    [Description(@"Standing instruction for a securities distribution.")]
    SecuritiesDistribution,
}
