// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXqQ8dp-Ed-ak6NoX_4Aeg_-1313852264")]
[Description(
    @"Specifies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned."
)]
[DerivedFrom(typeof(QueryTypeCode))]
public enum QueryType2Code
{
    /// <summary>
    /// Specifies that the query requests that all matching items be returned.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_ZXqQ8tp-Ed-ak6NoX_4Aeg_-1313851984")]
    [Description(@"Specifies that the query requests that all matching items be returned.")]
    All = QueryTypeCode.All, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the query requests that only new matching items since the last similar query be returned.
    /// Encoded/decoded by serializers as &quot;CHNG&quot;.
    /// </summary>
    [EnumMember(Value = "CHNG")]
    [IsoId("_ZXqQ89p-Ed-ak6NoX_4Aeg_-1313851983")]
    [Description(
        @"Specifies that the query requests that only new matching items since the last similar query be returned."
    )]
    Changed = QueryTypeCode.Changed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the query requests that only items that have changed since the last query be returned.
    /// Encoded/decoded by serializers as &quot;MODF&quot;.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_ZXqQ9Np-Ed-ak6NoX_4Aeg_-1313851982")]
    [Description(
        @"Specifies that the query requests that only items that have changed since the last query be returned."
    )]
    Modified = QueryTypeCode.Modified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the query requests that items that have been deleted since the last query be returned.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_ZXqQ9dp-Ed-ak6NoX_4Aeg_-1313851954")]
    [Description(
        @"Specifies that the query requests that items that have been deleted since the last query be returned."
    )]
    Deleted = QueryTypeCode.Deleted, // same ordinal as derivation source for type conversions
}
