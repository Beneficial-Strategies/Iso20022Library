// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the request, that is whether all information be returned or only information that has changed since the last similar request was returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXqQ9tp-Ed-ak6NoX_4Aeg_1181990652")]
[Description(
    @"Specifies the nature of the request, that is whether all information be returned or only information that has changed since the last similar request was returned."
)]
[DerivedFrom(typeof(QueryTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<QueryType3Code>))]
#endif
public enum QueryType3Code
{
    /// <summary>
    /// Specifies that the query requests that all matching items be returned.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_ZXqQ99p-Ed-ak6NoX_4Aeg_1181990669")]
    [Description(@"Specifies that the query requests that all matching items be returned.")]
    All = QueryTypeCode.All, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the query requests that only new matching items since the last similar query be returned.
    /// Encoded/decoded by serializers as &quot;CHNG&quot;.
    /// </summary>
    [EnumMember(Value = "CHNG")]
    [IsoId("_ZXqQ-Np-Ed-ak6NoX_4Aeg_1181990712")]
    [Description(
        @"Specifies that the query requests that only new matching items since the last similar query be returned."
    )]
    Changed = QueryTypeCode.Changed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the query requests that only items that have changed since the last query be returned.
    /// Encoded/decoded by serializers as &quot;MODF&quot;.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_ZXza4Np-Ed-ak6NoX_4Aeg_1181990713")]
    [Description(
        @"Specifies that the query requests that only items that have changed since the last query be returned."
    )]
    Modified = QueryTypeCode.Modified, // same ordinal as derivation source for type conversions
}
