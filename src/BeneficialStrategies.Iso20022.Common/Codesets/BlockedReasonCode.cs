// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iybhYxHaEeKVqeHljBM1MQ")]
[Description(@"Specifies the reason an account is blocked.")]
[Derivations(typeof(BlockedReason1Code), typeof(BlockedReason2Code), typeof(DisabledReason2Code))]
public enum BlockedReasonCode
{
    /// <summary>
    /// Commitment.
    /// Encoded/decoded by serializers as &quot;CMMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_qE3NMBHaEeKVqeHljBM1MQ")]
    [Description(@"Commitment.")]
    Commitment,

    /// <summary>
    /// Pledged.
    /// Encoded/decoded by serializers as &quot;PLDG&quot;.
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_qTKu8BHaEeKVqeHljBM1MQ")]
    [Description(@"Pledged.")]
    Pledged,

    /// <summary>
    /// Confiscation.
    /// Encoded/decoded by serializers as &quot;CNFS&quot;.
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_rQHfYBHaEeKVqeHljBM1MQ")]
    [Description(@"Confiscation.")]
    Confiscation,

    /// <summary>
    /// Bankruptcy.
    /// Encoded/decoded by serializers as &quot;BKRP&quot;.
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_rZgE4BHaEeKVqeHljBM1MQ")]
    [Description(@"Bankruptcy.")]
    Bankruptcy,

    /// <summary>
    /// Reserved in contemplation of death.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_rjV9YBHaEeKVqeHljBM1MQ")]
    [Description(@"Reserved in contemplation of death.")]
    MortisCausa,

    /// <summary>
    /// Transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_rs4T4BHaEeKVqeHljBM1MQ")]
    [Description(@"Transfer.")]
    Transfer,

    /// <summary>
    /// Reregistration.
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_r1rDgBHaEeKVqeHljBM1MQ")]
    [Description(@"Reregistration.")]
    Reregistration,

    /// <summary>
    /// Sanctions are in place.
    /// Encoded/decoded by serializers as &quot;SANC&quot;.
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("_ZiGRsFsMEeaY86V9afpFqA")]
    [Description(@"Sanctions are in place.")]
    Sanctions,

    /// <summary>
    /// Pending compliance verification.
    /// Encoded/decoded by serializers as &quot;PCOM&quot;.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_ZnwNwFsMEeaY86V9afpFqA")]
    [Description(@"Pending compliance verification.")]
    PendingComplianceVerification,

    /// <summary>
    /// Account closing is in process.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_3ES48GBqEeaHEJD5P6-ccw")]
    [Description(@"Account closing is in process.")]
    AccountClosingInProcess,

    /// <summary>
    /// Account was pending opening but is now rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_nBWeIGCIEeabZtzjEVWYCQ")]
    [Description(@"Account was pending opening but is now rejected.")]
    Rejected,
}
