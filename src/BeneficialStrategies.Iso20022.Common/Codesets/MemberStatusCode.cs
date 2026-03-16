// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the live status of a member of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLqgwtp-Ed-ak6NoX_4Aeg_-1869032551")]
[Description(@"Specifies the live status of a member of a system.")]
[Derivations(typeof(MemberStatus1Code))]
public enum MemberStatusCode
{
    /// <summary>
    /// Member is live on the system.
    /// Encoded/decoded by serializers as &quot;ENBL&quot;.
    /// </summary>
    [EnumMember(Value = "ENBL")]
    [IsoId("_aLqgw9p-Ed-ak6NoX_4Aeg_-1869032550")]
    [Description(@"Member is live on the system.")]
    Enabled,

    /// <summary>
    /// Member is temporarily not live on the system.
    /// Encoded/decoded by serializers as &quot;DSBL&quot;.
    /// </summary>
    [EnumMember(Value = "DSBL")]
    [IsoId("_aLqgxNp-Ed-ak6NoX_4Aeg_-1869032549")]
    [Description(@"Member is temporarily not live on the system.")]
    Disabled,

    /// <summary>
    /// Member is no longer live on the system.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_aLqgxdp-Ed-ak6NoX_4Aeg_-1869032548")]
    [Description(@"Member is no longer live on the system.")]
    Deleted,

    /// <summary>
    /// Member is joining and will soon be enabled on the system.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_aLqgxtp-Ed-ak6NoX_4Aeg_-1869032540")]
    [Description(@"Member is joining and will soon be enabled on the system.")]
    Joining,
}
