// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sub type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kWS8sOkEEemeDPHh-U9b6w")]
[Description(@"Sub type of goods and services purchased.")]
[DerivedFrom(typeof(GoodsAndServicesSubTypeCode))]
public enum GoodsAndServicesSubType1Code
{
    /// <summary>
    /// Sub type applied is cryptocurrency.
    /// Encoded/decoded by serializers as &quot;CRCU&quot;.
    /// </summary>
    [EnumMember(Value = "CRCU")]
    [IsoId("_lrDJIOkEEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is cryptocurrency.")]
    CryptoCurrency = GoodsAndServicesSubTypeCode.CryptoCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub type applied is foreign exchange.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_lz3G4ukEEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is foreign exchange.")]
    ForeignExchange = GoodsAndServicesSubTypeCode.ForeignExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other sub type of goods and service at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_l-pakukEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at national level.")]
    OtherNational = GoodsAndServicesSubTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other sub type of goods and service at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_mGXzMukEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at private level.")]
    OtherPrivate = GoodsAndServicesSubTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sub type applied is securities.
    /// Encoded/decoded by serializers as &quot;SECS&quot;.
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_mOIoEukEEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is securities.")]
    Securities = GoodsAndServicesSubTypeCode.Securities, // same ordinal as derivation source for type conversions
    
}
