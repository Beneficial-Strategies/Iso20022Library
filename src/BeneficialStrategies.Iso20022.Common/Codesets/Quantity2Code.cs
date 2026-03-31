// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies quantity of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXWu9tp-Ed-ak6NoX_4Aeg_274124251")]
[Description(@"Specifies quantity of a financial instrument.")]
[DerivedFrom(typeof(QuantityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Quantity2Code>))]
#endif
public enum Quantity2Code
{
    /// <summary>
    /// Instruction applies to the entire eligible balance of underlying securities.
    /// Encoded/decoded by serializers as &quot;QALL&quot;.
    /// </summary>
    [EnumMember(Value = "QALL")]
    [IsoId("_ZXgf8Np-Ed-ak6NoX_4Aeg_274124253")]
    [Description(@"Instruction applies to the entire eligible balance of underlying securities.")]
    AllSecurities = QuantityCode.AllSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZXgf8dp-Ed-ak6NoX_4Aeg_391412322")]
    [Description(@"Quantity has not been established.")]
    Open = QuantityCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZXgf8tp-Ed-ak6NoX_4Aeg_678624841")]
    [Description(@"Quantity is unknown by the sender or has not been established.")]
    UnknownQuantity = QuantityCode.UnknownQuantity, // same ordinal as derivation source for type conversions
}
