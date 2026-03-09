// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to define the type of the currency exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuZqcIZ3Eeufof77RM8ObQ")]
[Description(@"Code used to define the type of the currency exchange.")]
[DerivedFrom(typeof(ExchangeRateTypeCode))]
public enum ExchangeRateType2Code
{
    /// <summary>
    /// Exchange rate is the Sell rate.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_cstTEYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Sell rate.")]
    Sell = ExchangeRateTypeCode.Sell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate type is privately defined.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dMtBwYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type is privately defined.")]
    OtherPrivate = ExchangeRateTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate type that is defined at the National level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_dsjmgYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type that is defined at the National level.")]
    OtherNational = ExchangeRateTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate is the Middle rate.
    /// Encoded/decoded by serializers as &quot;MIDL&quot;.
    /// </summary>
    [EnumMember(Value = "MIDL")]
    [IsoId("_eNdUIYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Middle rate.")]
    Middle = ExchangeRateTypeCode.Middle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate is the Buy rate.
    /// Encoded/decoded by serializers as &quot;BUYR&quot;.
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_eNfJUYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Buy rate.")]
    Buy = ExchangeRateTypeCode.Buy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as &quot;AGRD&quot;.
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_ewAnkYZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed = ExchangeRateTypeCode.Agreed, // same ordinal as derivation source for type conversions
    
}
