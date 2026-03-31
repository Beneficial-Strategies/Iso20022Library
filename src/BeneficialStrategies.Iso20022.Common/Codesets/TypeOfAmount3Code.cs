// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_ZH9PwLEeGHDMP28rpT3g_-807892039")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfAmount3Code>))]
#endif
public enum TypeOfAmount3Code
{
    /// <summary>
    /// Cash-back amount.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_Y_iR4PwLEeGHDMP28rpT3g_-1513006654")]
    [Description(@"Cash-back amount.")]
    Cashback = TypeOfAmountCode.Cashback, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gratuity amount.
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_Y_iR4fwLEeGHDMP28rpT3g_-1804964392")]
    [Description(@"Gratuity amount.")]
    Gratuity = TypeOfAmountCode.Gratuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service fee.
    /// Encoded/decoded by serializers as &quot;SRVF&quot;.
    /// </summary>
    [EnumMember(Value = "SRVF")]
    [IsoId("_Y_iR4vwLEeGHDMP28rpT3g_748675924")]
    [Description(@"Service fee.")]
    ServiceFee = TypeOfAmountCode.ServiceFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interchange fee.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_Y_iR4_wLEeGHDMP28rpT3g_1117249163")]
    [Description(@"Interchange fee.")]
    InterchangeFee = TypeOfAmountCode.InterchangeFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original amount authorised during the real-time authorisation process.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_Y_iR5PwLEeGHDMP28rpT3g_1606769617")]
    [Description(@"Original amount authorised during the real-time authorisation process.")]
    Original = TypeOfAmountCode.Original, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra fee for a purchase or a withdrawal.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_Y_iR5fwLEeGHDMP28rpT3g_1784888289")]
    [Description(@"Extra fee for a purchase or a withdrawal.")]
    Surcharge = TypeOfAmountCode.Surcharge, // same ordinal as derivation source for type conversions
}
