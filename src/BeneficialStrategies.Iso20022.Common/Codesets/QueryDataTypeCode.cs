// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry type of the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cklwEKa-EeSxuMLA5o46jQ")]
[Description(@"Specifies the inquiry type of the data.")]
[Derivations(typeof(QueryDataType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<QueryDataTypeCode>))]
#endif
public enum QueryDataTypeCode
{
    /// <summary>
    /// Query for tading data of foreign exchange.
    /// Encoded/decoded by serializers as &quot;QFXT&quot;.
    /// </summary>
    [EnumMember(Value = "QFXT")]
    [IsoId("_n6_AkKa-EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of foreign exchange.")]
    QueryForeignExchangeTradingData,

    /// <summary>
    /// Query for tading data of option.
    /// Encoded/decoded by serializers as &quot;QOTD&quot;.
    /// </summary>
    [EnumMember(Value = "QOTD")]
    [IsoId("_oEHucKa-EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of option.")]
    QueryOptionTradingData,
}
