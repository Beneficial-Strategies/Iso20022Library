// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type for an underlying contract for difference derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2qD00IJoEeaStugbHOVOsA")]
[Description(@"Specifies the type for an underlying contract for difference derivative.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnderlyingContractForDifferenceType3Code>))]
#endif
public enum UnderlyingContractForDifferenceType3Code
{
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_-D6XQYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a bond.")]
    Bond = UnderlyingTypeV3Code.Bond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a commodity.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_-NuakYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a commodity.")]
    Commodity = UnderlyingTypeV3Code.Commodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a currency.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_-hqDMYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is a currency.")]
    Currency = UnderlyingTypeV3Code.Currency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is an emission allowance.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_-7ii0YJoEeaStugbHOVOsA")]
    [Description(@"Underlying is an emission allowance.")]
    EmissionAllowance = UnderlyingTypeV3Code.EmissionAllowance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("__UhqkYJoEeaStugbHOVOsA")]
    [Description(@"Underlying is an equity.")]
    Equity = UnderlyingTypeV3Code.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as &quot;FTEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_ANMX8YJpEeaStugbHOVOsA")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity = UnderlyingTypeV3Code.FutureOnEquity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as &quot;OPEQ&quot;.
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_BAgEMYJpEeaStugbHOVOsA")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity = UnderlyingTypeV3Code.OptionOnEquity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BPhXoYJpEeaStugbHOVOsA")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV3Code.Other, // same ordinal as derivation source for type conversions
}
