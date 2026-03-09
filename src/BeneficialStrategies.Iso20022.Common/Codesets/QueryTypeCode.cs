// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZXza4dp-Ed-ak6NoX_4Aeg_1663250443")]
[Description(@"Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.")]
[Derivations(typeof(QueryType2Code),typeof(QueryType3Code))]
public enum QueryTypeCode
{
    /// <summary>
    /// Specifies that the query requests that all matching items be returned.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_ZXza4tp-Ed-ak6NoX_4Aeg_1663250445")]
    [Description(@"Specifies that the query requests that all matching items be returned.")]
    All,
    
    /// <summary>
    /// Specifies that the query requests that only new matching items since the last similar query be returned.
    /// Encoded/decoded by serializers as &quot;CHNG&quot;.
    /// </summary>
    [EnumMember(Value = "CHNG")]
    [IsoId("_ZXza49p-Ed-ak6NoX_4Aeg_1663250454")]
    [Description(@"Specifies that the query requests that only new matching items since the last similar query be returned.")]
    Changed,
    
    /// <summary>
    /// Specifies that the query requests that only items that have changed since the last query be returned.
    /// Encoded/decoded by serializers as &quot;MODF&quot;.
    /// </summary>
    [EnumMember(Value = "MODF")]
    [IsoId("_ZXza5Np-Ed-ak6NoX_4Aeg_2022498795")]
    [Description(@"Specifies that the query requests that only items that have changed since the last query be returned.")]
    Modified,
    
    /// <summary>
    /// Specifies that the query requests that items that have been deleted since the last query be returned.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_ZX9L4Np-Ed-ak6NoX_4Aeg_2062212062")]
    [Description(@"Specifies that the query requests that items that have been deleted since the last query be returned.")]
    Deleted,
    
}
