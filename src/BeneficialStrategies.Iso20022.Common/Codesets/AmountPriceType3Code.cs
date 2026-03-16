// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eiyKAJbREee8S7xwGG7Veg")]
[Description(@"Specifies the amount price type.")]
[DerivedFrom(typeof(AmountPriceTypeCode))]
public enum AmountPriceType3Code
{
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_i3gHgZbREee8S7xwGG7Veg")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount = AmountPriceTypeCode.ActualAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as an amount of money per lot.
    /// Encoded/decoded by serializers as &quot;PLOT&quot;.
    /// </summary>
    [EnumMember(Value = "PLOT")]
    [IsoId("_i9wggZbREee8S7xwGG7Veg")]
    [Description(@"Price expressed as an amount of money per lot.")]
    Lot = AmountPriceTypeCode.Lot, // same ordinal as derivation source for type conversions
}
