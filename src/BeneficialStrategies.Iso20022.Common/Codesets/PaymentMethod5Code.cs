// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer an amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vr6_BNp-Ed-ak6NoX_4Aeg_445510957")]
[Description(@"Specifies the transfer method that will be used to transfer an amount of money.")]
[DerivedFrom(typeof(PaymentMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentMethod5Code>))]
#endif
public enum PaymentMethod5Code
{
    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_Vr6_Bdp-Ed-ak6NoX_4Aeg_869407428")]
    [Description(@"Transfer of an amount of money in the books of the account servicer.")]
    CreditTransfer = PaymentMethodCode.CreditTransfer, // same ordinal as derivation source for type conversions
}
