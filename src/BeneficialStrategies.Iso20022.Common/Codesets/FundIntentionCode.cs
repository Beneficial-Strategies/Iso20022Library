// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the fund is intended for qualified investors.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xgI4wCDXEeWCLu74WLgP4w")]
[Description(@"Specifies if the fund is intended for qualified investors.")]
[Derivations(typeof(FundIntention1Code))]
public enum FundIntentionCode
{
    /// <summary>
    /// Qualified.
    /// Encoded/decoded by serializers as &quot;YQUA&quot;.
    /// </summary>
    [EnumMember(Value = "YQUA")]
    [IsoId("_4WlzMCDXEeWCLu74WLgP4w")]
    [Description(@"Qualified.")]
    Qualified,
    
    /// <summary>
    /// Not qualified.
    /// Encoded/decoded by serializers as &quot;NQUA&quot;.
    /// </summary>
    [EnumMember(Value = "NQUA")]
    [IsoId("_8clYMCDXEeWCLu74WLgP4w")]
    [Description(@"Not qualified.")]
    NotQualified,
    
}
