// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the inquiry type of the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8LOxMKa_EeSxuMLA5o46jQ")]
[Description(@"Specifies the inquiry type of the data.")]
[DerivedFrom(typeof(QueryDataTypeCode))]
public enum QueryDataType1Code
{
    /// <summary>
    /// Query for tading data of foreign exchange.
    /// Encoded/decoded by serializers as &quot;QFXT&quot;.
    /// </summary>
    [EnumMember(Value = "QFXT")]
    [IsoId("__WMRUaa_EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of foreign exchange.")]
    QueryForeignExchangeTradingData = QueryDataTypeCode.QueryForeignExchangeTradingData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for tading data of option.
    /// Encoded/decoded by serializers as &quot;QOTD&quot;.
    /// </summary>
    [EnumMember(Value = "QOTD")]
    [IsoId("__bscYaa_EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of option.")]
    QueryOptionTradingData = QueryDataTypeCode.QueryOptionTradingData, // same ordinal as derivation source for type conversions
    
}
