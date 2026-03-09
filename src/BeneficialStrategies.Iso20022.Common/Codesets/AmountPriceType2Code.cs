// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beqZs9p-Ed-ak6NoX_4Aeg_-1075944972")]
[Description(@"Specifies the amount price type.")]
[DerivedFrom(typeof(AmountPriceTypeCode))]
public enum AmountPriceType2Code
{
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_beqZtNp-Ed-ak6NoX_4Aeg_-777647527")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount = AmountPriceTypeCode.ActualAmount, // same ordinal as derivation source for type conversions
    
}
