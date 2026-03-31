// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of risk management answer from an Acquirer (or its IntermediaryAgent) to a POI through a NonFinancialResponse.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qrdJwC_vEeugIJ3Gvoevmg")]
[Description(
    @"Type of risk management answer from an Acquirer (or its IntermediaryAgent) to a POI through a NonFinancialResponse. "
)]
[Derivations(typeof(NonFinancialResponseRisk1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NonFinancialResponseRiskCode>))]
#endif
public enum NonFinancialResponseRiskCode
{
    /// <summary>
    /// An authorisation is expected from the POI to manage risk.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_MuDscC_wEeugIJ3Gvoevmg")]
    [Description(@"An authorisation is expected from the POI to manage risk.")]
    RequestOnline,

    /// <summary>
    /// A decline of the transaction is expected by the POI to manage risk.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_qv-A4C_wEeugIJ3Gvoevmg")]
    [Description(@"A decline of the transaction is expected by the POI to manage risk.")]
    Decline,

    /// <summary>
    /// The POI is able to assess the risk by himself.
    /// Encoded/decoded by serializers as &quot;NCHG&quot;.
    /// </summary>
    [EnumMember(Value = "NCHG")]
    [IsoId("_vf1CQC_wEeugIJ3Gvoevmg")]
    [Description(@"The POI is able to assess the risk by himself.")]
    LocallyManaged,
}
