// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the status of the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZS5Ftdp-Ed-ak6NoX_4Aeg_-1000214572")]
[Description(@"Specifies additional information about the status of the repurchase agreement call processed instruction.")]
[DerivedFrom(typeof(RepoCallRequestStatusCode))]
public enum RepoCallRequestStatus1Code
{
    /// <summary>
    /// Repurchase agreement call request is acknowledged/accepted.
    /// Encoded/decoded by serializers as &quot;CACK&quot;.
    /// </summary>
    [EnumMember(Value = "CACK")]
    [IsoId("_ZS5Fttp-Ed-ak6NoX_4Aeg_-1000214541")]
    [Description(@"Repurchase agreement call request is acknowledged/accepted.")]
    AcknowledgedAccepted = RepoCallRequestStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repuchase agreement call request is denied.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZS5Ft9p-Ed-ak6NoX_4Aeg_-1000214284")]
    [Description(@"Repuchase agreement call request is denied.")]
    Denied = RepoCallRequestStatusCode.Denied, // same ordinal as derivation source for type conversions
    
}
