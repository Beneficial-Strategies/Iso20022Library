// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to indicate the activity type to be reconciled
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ikZkgCX_Eeym0KcvJF9aDQ")]
[Description(@"Code to indicate the activity type to be reconciled")]
[Derivations(typeof(ReconciliationActivityType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReconciliationActivityTypeCode>))]
#endif
public enum ReconciliationActivityTypeCode
{
    /// <summary>
    /// Acquiring activity.
    /// Encoded/decoded by serializers as &quot;ACQG&quot;.
    /// </summary>
    [EnumMember(Value = "ACQG")]
    [IsoId("_wAVlMCX_Eeym0KcvJF9aDQ")]
    [Description(@"Acquiring activity.")]
    Acquiring,

    /// <summary>
    /// Issuing activity
    /// Encoded/decoded by serializers as &quot;ISSG&quot;.
    /// </summary>
    [EnumMember(Value = "ISSG")]
    [IsoId("_HGWegCYAEeym0KcvJF9aDQ")]
    [Description(@"Issuing activity")]
    Issuing,

    /// <summary>
    /// All types of activity.
    /// Encoded/decoded by serializers as &quot;CNSD&quot;.
    /// </summary>
    [EnumMember(Value = "CNSD")]
    [IsoId("_TcHhUCYAEeym0KcvJF9aDQ")]
    [Description(@"All types of activity.")]
    Consolidated,

    /// <summary>
    /// Other reconciliation activity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ckuroCYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at private level ")]
    OtherPrivate,

    /// <summary>
    /// Other reconciliation activity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_uAjCQCYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at national level")]
    OtherNational,
}
