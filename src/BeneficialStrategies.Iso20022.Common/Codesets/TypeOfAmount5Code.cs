// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EYCUwHs1EeSTS7uHCe8FPQ")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfAmount5Code>))]
#endif
public enum TypeOfAmount5Code
{
    /// <summary>
    /// Cash-back amount.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_JB5b0Xs1EeSTS7uHCe8FPQ")]
    [Description(@"Cash-back amount.")]
    Cashback = TypeOfAmountCode.Cashback, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_JW-7A3s1EeSTS7uHCe8FPQ")]
    [Description(
        @"Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount."
    )]
    Discount = TypeOfAmountCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_KEPCk3s1EeSTS7uHCe8FPQ")]
    [Description(@"Fees.")]
    Fees = TypeOfAmountCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gratuity amount.
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_KM4oQXs1EeSTS7uHCe8FPQ")]
    [Description(@"Gratuity amount.")]
    Gratuity = TypeOfAmountCode.Gratuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra fee for a purchase or a withdrawal.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_KqKaI3s1EeSTS7uHCe8FPQ")]
    [Description(@"Extra fee for a purchase or a withdrawal.")]
    Surcharge = TypeOfAmountCode.Surcharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value added tax amount.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_KxCeM3s1EeSTS7uHCe8FPQ")]
    [Description(@"Value added tax amount.")]
    ValueAddedTax = TypeOfAmountCode.ValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission, for example for DCC (Dynamic Currency Conversion) transactions.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_7D9GwdPHEeSFn54OzS96Iw")]
    [Description(@"Commission, for example for DCC (Dynamic Currency Conversion) transactions.")]
    Commission = TypeOfAmountCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Donation amount.
    /// Encoded/decoded by serializers as &quot;DONN&quot;.
    /// </summary>
    [EnumMember(Value = "DONN")]
    [IsoId("_Zu6dgS70EeWc7f-D6ByqMg")]
    [Description(@"Donation amount.")]
    Donation = TypeOfAmountCode.Donation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Taxes applicable to the transaction.
    /// Encoded/decoded by serializers as &quot;TAXT&quot;.
    /// </summary>
    [EnumMember(Value = "TAXT")]
    [IsoId("_W5BZAS71EeWDa4uwlWChEA")]
    [Description(@"Taxes applicable to the transaction.")]
    Tax = TypeOfAmountCode.Tax, // same ordinal as derivation source for type conversions
}
