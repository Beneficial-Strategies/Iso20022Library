// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__qxMVNojEeC60axPepSq7g_1753446814")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unaffirmed."
)]
[Derivations(typeof(UnaffirmedReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnaffirmedReasonCode>))]
#endif
public enum UnaffirmedReasonCode
{
    /// <summary>
    /// Specifies the reason the counterparty has not affirmed.
    /// Encoded/decoded by serializers as &quot;NAFF&quot;.
    /// </summary>
    [EnumMember(Value = "NAFF")]
    [IsoId("__q6WQNojEeC60axPepSq7g_1606974359")]
    [Description(@"Specifies the reason the counterparty has not affirmed.")]
    CounterpartyNotAffirmed,
}
