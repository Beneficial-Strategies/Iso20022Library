// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is a payment, or a receipt or none.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_939OkA5EEeenr-7g_0TYag")]
[Description(@"Specifies if an operation is a payment, or a receipt or none.")]
[DerivedFrom(typeof(PaymentReceiptCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentReceipt1Code>))]
#endif
public enum PaymentReceipt1Code
{
    /// <summary>
    /// Operation is a payment.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("__uhuoQ5EEeenr-7g_0TYag")]
    [Description(@"Operation is a payment.")]
    Payment = PaymentReceiptCode.Payment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Operation is a receipt.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("__0B5sQ5EEeenr-7g_0TYag")]
    [Description(@"Operation is a receipt.")]
    Receipt = PaymentReceiptCode.Receipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Operation is null.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("__51mwQ5EEeenr-7g_0TYag")]
    [Description(@"Operation is null.")]
    None = PaymentReceiptCode.None, // same ordinal as derivation source for type conversions
}
