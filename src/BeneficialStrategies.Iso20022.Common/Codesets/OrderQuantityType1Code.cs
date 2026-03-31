// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViiZgdp-Ed-ak6NoX_4Aeg_-392071140")]
[Description(@"Specifies how the order is placed, eg by quantity of units or by amount of money.")]
[DerivedFrom(typeof(OrderQuantityTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrderQuantityType1Code>))]
#endif
public enum OrderQuantityType1Code
{
    /// <summary>
    /// Order is placed by unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_ViiZgtp-Ed-ak6NoX_4Aeg_-278477005")]
    [Description(@"Order is placed by unit.")]
    Unit = OrderQuantityTypeCode.Unit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is placed by amount of money.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ViiZg9p-Ed-ak6NoX_4Aeg_-278476987")]
    [Description(@"Order is placed by amount of money.")]
    Amount = OrderQuantityTypeCode.Amount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ViiZhNp-Ed-ak6NoX_4Aeg_-278476962")]
    [Description(@"Transaction is another type of transaction.")]
    Other = OrderQuantityTypeCode.Other, // same ordinal as derivation source for type conversions
}
