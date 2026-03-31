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
[IsoId("_0IqGIAJhEeS2H9l84F_isg")]
[Description(@"Identifies the type of confirmation message being sent.")]
[Derivations(typeof(ConfirmationRequest1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConfirmationRequestCode>))]
#endif
public enum ConfirmationRequestCode
{
    /// <summary>
    /// To inquire about the status of the trade confirmation.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_4Cs50AJhEeS2H9l84F_isg")]
    [Description(@"To inquire about the status of the trade confirmation.")]
    Status,

    /// <summary>
    /// To confirm the trade.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_iDFaUAKBEeS2H9l84F_isg")]
    [Description(@"To confirm the trade.")]
    Confirmation,

    /// <summary>
    /// To reject the confirmation of the trade.
    /// Encoded/decoded by serializers as &quot;CNRR&quot;.
    /// </summary>
    [EnumMember(Value = "CNRR")]
    [IsoId("_kheIUAKBEeS2H9l84F_isg")]
    [Description(@"To reject the confirmation of the trade.")]
    ConfirmationRequestRejected,
}
