// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the amount price type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beqZtdp-Ed-ak6NoX_4Aeg_904379222")]
[Description(@"Specifies the amount price type.")]
[Derivations(typeof(AmountPriceType1Code),typeof(AmountPriceType2Code),typeof(AmountPriceType3Code))]
public enum AmountPriceTypeCode
{
    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_beqZttp-Ed-ak6NoX_4Aeg_907150846")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount,
    
    /// <summary>
    /// Price expressed as a discount amount.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_beqZt9p-Ed-ak6NoX_4Aeg_907150854")]
    [Description(@"Price expressed as a discount amount.")]
    Discount,
    
    /// <summary>
    /// Price expressed as an amount of money per lot.
    /// Encoded/decoded by serializers as &quot;PLOT&quot;.
    /// </summary>
    [EnumMember(Value = "PLOT")]
    [IsoId("_beqZuNp-Ed-ak6NoX_4Aeg_907150877")]
    [Description(@"Price expressed as an amount of money per lot.")]
    Lot,
    
    /// <summary>
    /// Price expressed as a premium.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_be0KsNp-Ed-ak6NoX_4Aeg_907150885")]
    [Description(@"Price expressed as a premium.")]
    Premium,
    
}
