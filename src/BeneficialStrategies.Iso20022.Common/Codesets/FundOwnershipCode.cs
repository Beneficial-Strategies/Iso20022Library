// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if all the shares are owned exclusively by the fund company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S5BlgCDXEeWCLu74WLgP4w")]
[Description(@"Specifies if all the shares are owned exclusively by the fund company.")]
[Derivations(typeof(FundOwnership1Code))]
public enum FundOwnershipCode
{
    /// <summary>
    /// All shares owned.
    /// Encoded/decoded by serializers as &quot;YALL&quot;.
    /// </summary>
    [EnumMember(Value = "YALL")]
    [IsoId("_bNgkMCDXEeWCLu74WLgP4w")]
    [Description(@"All shares owned.")]
    AllOwned,

    /// <summary>
    /// Not all shares owned.
    /// Encoded/decoded by serializers as &quot;NALL&quot;.
    /// </summary>
    [EnumMember(Value = "NALL")]
    [IsoId("_dekn4CDXEeWCLu74WLgP4w")]
    [Description(@"Not all shares owned.")]
    NotAllOwned,
}
