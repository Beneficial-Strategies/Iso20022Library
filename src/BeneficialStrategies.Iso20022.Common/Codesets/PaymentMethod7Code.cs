// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbT9dNp-Ed-ak6NoX_4Aeg_698889928")]
[Description(@"Specifies the transfer method that will be used to transfer the cash.")]
[DerivedFrom(typeof(PaymentMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentMethod7Code>))]
#endif
public enum PaymentMethod7Code
{
    /// <summary>
    /// Written order to a bank to pay a certain amount of money from one person to another person.
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_YbT9ddp-Ed-ak6NoX_4Aeg_-1320976702")]
    [Description(
        @"Written order to a bank to pay a certain amount of money from one person to another person."
    )]
    Cheque = PaymentMethodCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer of an amount of money in the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;TRF&quot;.
    /// </summary>
    [EnumMember(Value = "TRF")]
    [IsoId("_YbT9dtp-Ed-ak6NoX_4Aeg_-2113712619")]
    [Description(@"Transfer of an amount of money in the books of the account servicer.")]
    CreditTransfer = PaymentMethodCode.CreditTransfer, // same ordinal as derivation source for type conversions
}
