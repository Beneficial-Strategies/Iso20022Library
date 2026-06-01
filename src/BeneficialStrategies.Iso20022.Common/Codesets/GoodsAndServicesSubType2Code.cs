// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sub type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_55z6gXbdEfCmC4yYaU27Kg")]
[Description(@"Sub type of goods and services purchased.")]
[DerivedFrom(typeof(GoodsAndServicesSubTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<GoodsAndServicesSubType2Code>))]
public enum GoodsAndServicesSubType2Code
{
    /// <summary>
    /// Sub type applied is cryptocurrency.
    /// Encoded/decoded by serializers as &quot;CRCU&quot;.
    /// </summary>
    [EnumMember(Value = "CRCU")]
    [IsoId("_58bJoXbdEfCmC4yYaU27Kg")]
    [Description(@"Sub type applied is cryptocurrency.")]
    CryptoCurrency = GoodsAndServicesSubTypeCode.CryptoCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub type applied is foreign exchange.
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_58bJo3bdEfCmC4yYaU27Kg")]
    [Description(@"Sub type applied is foreign exchange.")]
    ForeignExchange = GoodsAndServicesSubTypeCode.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sub type applied is securities.
    /// Encoded/decoded by serializers as &quot;SECS&quot;.
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_58bJqXbdEfCmC4yYaU27Kg")]
    [Description(@"Sub type applied is securities.")]
    Securities = GoodsAndServicesSubTypeCode.Securities, // same ordinal as derivation source for type conversions
}
