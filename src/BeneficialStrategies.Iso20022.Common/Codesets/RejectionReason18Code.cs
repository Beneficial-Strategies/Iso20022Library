// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of an election advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zir1Ndp-Ed-ak6NoX_4Aeg_1336974420")]
[Description(@"Specifies the reason of a rejection of an election advice.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason18Code>))]
#endif
public enum RejectionReason18Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zir1Ntp-Ed-ak6NoX_4Aeg_-940679430")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as &quot;INHO&quot;.
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("_Zir1N9p-Ed-ak6NoX_4Aeg_-940679369")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance = RejectionReasonCode.InsufficientBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_Zir1ONp-Ed-ak6NoX_4Aeg_-940679338")]
    [Description(@"Instruction/Request arrives too late.")]
    Late = RejectionReasonCode.Late, // same ordinal as derivation source for type conversions
}
