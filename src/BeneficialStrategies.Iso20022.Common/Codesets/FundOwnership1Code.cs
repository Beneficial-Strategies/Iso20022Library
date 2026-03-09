// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if all the shares are owned exclusively by the fund company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j9NfQCDXEeWCLu74WLgP4w")]
[Description(@"Specifies if all the shares are owned exclusively by the fund company.")]
[DerivedFrom(typeof(FundOwnershipCode))]
public enum FundOwnership1Code
{
    /// <summary>
    /// All shares owned.
    /// Encoded/decoded by serializers as &quot;YALL&quot;.
    /// </summary>
    [EnumMember(Value = "YALL")]
    [IsoId("_cYpsMSDYEeWCLu74WLgP4w")]
    [Description(@"All shares owned.")]
    AllOwned = FundOwnershipCode.AllOwned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not all shares owned.
    /// Encoded/decoded by serializers as &quot;NALL&quot;.
    /// </summary>
    [EnumMember(Value = "NALL")]
    [IsoId("_cfy2ASDYEeWCLu74WLgP4w")]
    [Description(@"Not all shares owned.")]
    NotAllOwned = FundOwnershipCode.NotAllOwned, // same ordinal as derivation source for type conversions
    
}
