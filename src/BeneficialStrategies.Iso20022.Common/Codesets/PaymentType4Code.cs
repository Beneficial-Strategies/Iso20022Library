// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8ibGUOkAEemV35DUs8L82Q")]
[Description(@"Specifies the type, or nature, of the payment.")]
[DerivedFrom(typeof(PaymentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentType4Code>))]
#endif
public enum PaymentType4Code
{
    /// <summary>
    /// Transaction is an initial payment made by one of the counterparties  either to bring a transaction to fair value or for any other reason that may be the cause of an off-market transaction.
    /// Encoded/decoded by serializers as &quot;UFRO&quot;.
    /// </summary>
    [EnumMember(Value = "UFRO")]
    [IsoId("_99VlIekAEemV35DUs8L82Q")]
    [Description(
        @"Transaction is an initial payment made by one of the counterparties  either to bring a transaction to fair value or for any other reason that may be the cause of an off-market transaction."
    )]
    Upfront = PaymentTypeCode.Upfront, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the final settlement payment made when a transaction is unwound prior to its end date or a payment that may result due to the full termination of derivative transaction(s).
    /// Encoded/decoded by serializers as &quot;UWIN&quot;.
    /// </summary>
    [EnumMember(Value = "UWIN")]
    [IsoId("_-BgTcekAEemV35DUs8L82Q")]
    [Description(
        @"Transaction is the final settlement payment made when a transaction is unwound prior to its end date or a payment that may result due to the full termination of derivative transaction(s)."
    )]
    UnWind = PaymentTypeCode.UnWind, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an exchange of notional values for cross-currency swaps.
    /// Encoded/decoded by serializers as &quot;PEXH&quot;.
    /// </summary>
    [EnumMember(Value = "PEXH")]
    [IsoId("__VvigekAEemV35DUs8L82Q")]
    [Description(@"Transaction is an exchange of notional values for cross-currency swaps.")]
    PrincipalExchange = PaymentTypeCode.PrincipalExchange, // same ordinal as derivation source for type conversions
}
