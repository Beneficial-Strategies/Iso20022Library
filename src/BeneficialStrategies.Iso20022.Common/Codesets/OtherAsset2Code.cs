// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c7iNMJNCEemQB_8XA98K0Q")]
[Description(@"Specifies a type of asset.")]
[DerivedFrom(typeof(OtherAssetCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OtherAsset2Code>))]
#endif
public enum OtherAsset2Code
{
    /// <summary>
    /// Asset is a discretionary investment manager account
    /// Encoded/decoded by serializers as &quot;DIMA&quot;.
    /// </summary>
    [EnumMember(Value = "DIMA")]
    [IsoId("_fnEmYZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a discretionary investment manager account")]
    Discretionary = OtherAssetCode.Discretionary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset is an external investment account.
    /// Encoded/decoded by serializers as &quot;EXIA&quot;.
    /// </summary>
    [EnumMember(Value = "EXIA")]
    [IsoId("_fsbAcZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is an external investment account.")]
    ExternalAccount = OtherAssetCode.ExternalAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Property that is not real estate. Also known as &apos;movable chattels&apos;.
    /// Encoded/decoded by serializers as &quot;MOVE&quot;.
    /// </summary>
    [EnumMember(Value = "MOVE")]
    [IsoId("_fyX3cZNCEemQB_8XA98K0Q")]
    [Description(@"Property that is not real estate. Also known as 'movable chattels'.")]
    MovableProperty = OtherAssetCode.MovableProperty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Property that is real estate.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_f5EVUZNCEemQB_8XA98K0Q")]
    [Description(@"Property that is real estate.")]
    Property = OtherAssetCode.Property, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset is a trustee investment plan (TIP).
    /// Encoded/decoded by serializers as &quot;TIPP&quot;.
    /// </summary>
    [EnumMember(Value = "TIPP")]
    [IsoId("_f_UuUZNCEemQB_8XA98K0Q")]
    [Description(@"Asset is a trustee investment plan (TIP).")]
    TrusteeInvestmentPlan = OtherAssetCode.TrusteeInvestmentPlan, // same ordinal as derivation source for type conversions
}
