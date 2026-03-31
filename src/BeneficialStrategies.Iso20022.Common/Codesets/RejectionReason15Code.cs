// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of an information advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZhMnctp-Ed-ak6NoX_4Aeg_1863383216")]
[Description(@"Specifies the reason of a rejection of an information advice.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason15Code>))]
#endif
public enum RejectionReason15Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZhMnc9p-Ed-ak6NoX_4Aeg_-1572959091")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
}
