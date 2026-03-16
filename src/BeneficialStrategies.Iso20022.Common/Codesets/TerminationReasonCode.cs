// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the termination reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X1pf0HyiEeGWJuGCfvwOsQ")]
[Description(@"Specifies the termination reason.")]
[Derivations(typeof(TerminationReason1Code))]
public enum TerminationReasonCode
{
    /// <summary>
    /// Reason for termination is underlying business has finished.
    /// Encoded/decoded by serializers as &quot;BUFI&quot;.
    /// </summary>
    [EnumMember(Value = "BUFI")]
    [IsoId("_oq2kIBSJEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is underlying business has finished.")]
    UnderlyingBusinessFinished,

    /// <summary>
    /// Reason for termination is warranty obligation period has expired.
    /// Encoded/decoded by serializers as &quot;WOEX&quot;.
    /// </summary>
    [EnumMember(Value = "WOEX")]
    [IsoId("_8xeUIBSJEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is warranty obligation period has expired.")]
    WarrantyObligationPeriodExpired,

    /// <summary>
    /// Reason for termination is non-acceptance of a tender.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_PBLl0BSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is non-acceptance of a tender.")]
    TenderNonAcceptance,

    /// <summary>
    /// Reason for termination is reduction terms have been fulfilled.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_cd6QsBSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is reduction terms have been fulfilled.")]
    ReductionTermsFulfilled,
}
