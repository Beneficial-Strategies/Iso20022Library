// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_avIaNdp-Ed-ak6NoX_4Aeg_1497408468")]
[Description(@"Specifies the type of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum HedgeFundOrderType2Code
{
    /// <summary>
    /// Investment fund order is for a limited partnership instrument.
    /// Encoded/decoded by serializers as &quot;NUNI&quot;.
    /// </summary>
    [EnumMember(Value = "NUNI")]
    [IsoId("_avIaNtp-Ed-ak6NoX_4Aeg_1497408498")]
    [Description(@"Investment fund order is for a limited partnership instrument.")]
    NonUnitized = FundOrderTypeCode.NonUnitized, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order contains a side pocket component.
    /// Encoded/decoded by serializers as &quot;SPCM&quot;.
    /// </summary>
    [EnumMember(Value = "SPCM")]
    [IsoId("_avIaN9p-Ed-ak6NoX_4Aeg_1497408529")]
    [Description(@"Investment fund order contains a side pocket component.")]
    SidePocketComponent = FundOrderTypeCode.SidePocketComponent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is part of a bed and breakfast transaction.
    /// Encoded/decoded by serializers as &quot;BEDB&quot;.
    /// </summary>
    [EnumMember(Value = "BEDB")]
    [IsoId("_avIaONp-Ed-ak6NoX_4Aeg_1497408560")]
    [Description(@"Investment fund order is part of a bed and breakfast transaction.")]
    BedAndBreakfast = FundOrderTypeCode.BedAndBreakfast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is a side pocket order.
    /// Encoded/decoded by serializers as &quot;SPOR&quot;.
    /// </summary>
    [EnumMember(Value = "SPOR")]
    [IsoId("_avIaOdp-Ed-ak6NoX_4Aeg_1497408561")]
    [Description(@"Investment fund order is a side pocket order.")]
    SidePocketOrder = FundOrderTypeCode.SidePocketOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order is for a unitized instrument.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_avRkINp-Ed-ak6NoX_4Aeg_1497408590")]
    [Description(@"Investment fund order is for a unitized instrument.")]
    Unitized = FundOrderTypeCode.Unitized, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order specifies a top up.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_avRkIdp-Ed-ak6NoX_4Aeg_1497408591")]
    [Description(@"Investment fund order specifies a top up.")]
    TopUp = FundOrderTypeCode.TopUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment fund order specifies a hold back.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_avRkItp-Ed-ak6NoX_4Aeg_-1544341372")]
    [Description(@"Investment fund order specifies a hold back.")]
    HoldBack = FundOrderTypeCode.HoldBack, // same ordinal as derivation source for type conversions
    
}
