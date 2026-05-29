// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to define the type of the currency exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_biU5ESH2EfCkq6-p7S3J1Q")]
[Description(@"Code used to define the type of the currency exchange.")]
[DerivedFrom(typeof(ExchangeRateTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExchangeRateType3Code>))]
public enum ExchangeRateType3Code
{
    /// <summary>
    /// Exchange rate is the Sell rate.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_blL_0SH2EfCkq6-p7S3J1Q")]
    [Description(@"Exchange rate is the Sell rate.")]
    Sell = ExchangeRateTypeCode.Sell,

    /// <summary>
    /// Exchange rate is the Middle rate.
    /// Encoded/decoded by serializers as &quot;MIDL&quot;.
    /// </summary>
    [EnumMember(Value = "MIDL")]
    [IsoId("_blL_1yH2EfCkq6-p7S3J1Q")]
    [Description(@"Exchange rate is the Middle rate.")]
    Middle = ExchangeRateTypeCode.Middle,

    /// <summary>
    /// Exchange rate is the Buy rate.
    /// Encoded/decoded by serializers as &quot;BUYR&quot;.
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_blL_2SH2EfCkq6-p7S3J1Q")]
    [Description(@"Exchange rate is the Buy rate.")]
    Buy = ExchangeRateTypeCode.Buy,

    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as &quot;AGRD&quot;.
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_blL_2yH2EfCkq6-p7S3J1Q")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed = ExchangeRateTypeCode.Agreed,
}
