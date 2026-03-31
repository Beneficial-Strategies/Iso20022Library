// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of confirmation message being sent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jIjf8H6IEeSAlrUr1Vow5g")]
[Description(@"Identifies the type of confirmation message being sent.")]
[DerivedFrom(typeof(ConfirmationRequestCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConfirmationRequest1Code>))]
#endif
public enum ConfirmationRequest1Code
{
    /// <summary>
    /// To confirm the trade.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_lrBcsX6IEeSAlrUr1Vow5g")]
    [Description(@"To confirm the trade.")]
    Confirmation = ConfirmationRequestCode.Confirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To reject the confirmation of the trade.
    /// Encoded/decoded by serializers as &quot;CNRR&quot;.
    /// </summary>
    [EnumMember(Value = "CNRR")]
    [IsoId("_lwYd0X6IEeSAlrUr1Vow5g")]
    [Description(@"To reject the confirmation of the trade.")]
    ConfirmationRequestRejected = ConfirmationRequestCode.ConfirmationRequestRejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To inquire about the status of the trade confirmation.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_l1rNgX6IEeSAlrUr1Vow5g")]
    [Description(@"To inquire about the status of the trade confirmation.")]
    Status = ConfirmationRequestCode.Status, // same ordinal as derivation source for type conversions
}
