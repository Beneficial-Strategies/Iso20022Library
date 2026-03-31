// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing window in which the balance transfer will be processed on the switch date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K2bYsH6qEeePx-IqKegQ8Q")]
[Description(
    @"Specifies the processing window in which the balance transfer will be processed on the switch date."
)]
[DerivedFrom(typeof(BalanceTransferWindowCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BalanceTransferWindow1Code>))]
#endif
public enum BalanceTransferWindow1Code
{
    /// <summary>
    /// Indicates in business hours processing.
    /// Encoded/decoded by serializers as &quot;DAYH&quot;.
    /// </summary>
    [EnumMember(Value = "DAYH")]
    [IsoId("_MQ4kgX6qEeePx-IqKegQ8Q")]
    [Description(@"Indicates in business hours processing.")]
    InHours = BalanceTransferWindowCode.InHours, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates out of business hours processing.
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_MYPwwX6qEeePx-IqKegQ8Q")]
    [Description(@"Indicates out of business hours processing.")]
    OutOfHours = BalanceTransferWindowCode.OutOfHours, // same ordinal as derivation source for type conversions
}
