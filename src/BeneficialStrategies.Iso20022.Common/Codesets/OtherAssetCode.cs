// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_deqTgEyMEeiepssxrmRw1A")]
[Description(@"Specifies a type of asset.")]
[Derivations(typeof(OtherAsset1Code), typeof(OtherAsset2Code))]
public enum OtherAssetCode
{
    /// <summary>
    /// Property that is real estate.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_fdkQMEyMEeiepssxrmRw1A")]
    [Description(@"Property that is real estate.")]
    Property,

    /// <summary>
    /// Property that is not real estate. Also known as &apos;movable chattels&apos;.
    /// Encoded/decoded by serializers as &quot;MOVE&quot;.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_j1tVIEyMEeiepssxrmRw1A")]
    [Description(@"Property that is not real estate. Also known as 'movable chattels'.")]
    MovableProperty,

    /// <summary>
    /// Asset is an external investment account.
    /// Encoded/decoded by serializers as &quot;EXIA&quot;.
    /// </summary>
    [EnumMember(Value = "EXIA")]
    [IsoId("_DYEaAJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is an external investment account.")]
    ExternalAccount,

    /// <summary>
    /// Asset is a discretionary investment manager account
    /// Encoded/decoded by serializers as &quot;DIMA&quot;.
    /// </summary>
    [EnumMember(Value = "DIMA")]
    [IsoId("_OfW3gJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a discretionary investment manager account")]
    Discretionary,

    /// <summary>
    /// Asset is a trustee investment plan (TIP).
    /// Encoded/decoded by serializers as &quot;TIPP&quot;.
    /// </summary>
    [EnumMember(Value = "TIPP")]
    [IsoId("_XhV1YJNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a trustee investment plan (TIP).")]
    TrusteeInvestmentPlan,
}
