// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the status of the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZS5FuNp-Ed-ak6NoX_4Aeg_-1154442973")]
[Description(
    @"Specifies additional information about the status of the repurchase agreement call processed instruction."
)]
[Derivations(typeof(RepoCallRequestStatus1Code))]
public enum RepoCallRequestStatusCode
{
    /// <summary>
    /// Repurchase agreement call request is acknowledged/accepted.
    /// Encoded/decoded by serializers as &quot;CACK&quot;.
    /// </summary>
    [EnumMember(Value = "CACK")]
    [IsoId("_ZTCPoNp-Ed-ak6NoX_4Aeg_-1094415277")]
    [Description(@"Repurchase agreement call request is acknowledged/accepted.")]
    AcknowledgedAccepted,

    /// <summary>
    /// Repuchase agreement call request is denied.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZTCPodp-Ed-ak6NoX_4Aeg_-1044542139")]
    [Description(@"Repuchase agreement call request is denied.")]
    Denied,
}
