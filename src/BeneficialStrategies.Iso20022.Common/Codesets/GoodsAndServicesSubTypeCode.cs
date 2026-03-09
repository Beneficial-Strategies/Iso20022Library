// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sub type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_38ZrgOkCEemeDPHh-U9b6w")]
[Description(@"Sub type of goods and services purchased.")]
[Derivations(typeof(GoodsAndServicesSubType1Code))]
public enum GoodsAndServicesSubTypeCode
{
    /// <summary>
    /// Sub type applied is securities.
    /// Encoded/decoded by serializers as &quot;SECS&quot;.
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_Ltug8OkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is securities.")]
    Securities,
    
    /// <summary>
    /// Sub type applied is foreign exchange.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_o3JuMOkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is foreign exchange.")]
    ForeignExchange,
    
    /// <summary>
    /// Sub type applied is cryptocurrency.
    /// Encoded/decoded by serializers as &quot;CRCU&quot;.
    /// </summary>
    [EnumMember(Value = "CRCU")]
    [IsoId("_zqKk0OkDEemeDPHh-U9b6w")]
    [Description(@"Sub type applied is cryptocurrency.")]
    CryptoCurrency,
    
    /// <summary>
    /// Other sub type of goods and service at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_B5UyMOkEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other sub type of goods and service at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_bnpKgOkEEemeDPHh-U9b6w")]
    [Description(@"Other sub type of goods and service at private level.")]
    OtherPrivate,
    
}
