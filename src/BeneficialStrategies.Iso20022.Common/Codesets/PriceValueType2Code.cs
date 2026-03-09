// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJR7Itp-Ed-ak6NoX_4Aeg_-228971923")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType2Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJR7I9p-Ed-ak6NoX_4Aeg_61936866")]
    [Description(@"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.")]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJR7JNp-Ed-ak6NoX_4Aeg_91492479")]
    [Description(@"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.")]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions
    
}
