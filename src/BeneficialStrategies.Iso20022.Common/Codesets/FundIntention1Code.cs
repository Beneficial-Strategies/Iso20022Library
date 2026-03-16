// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the fund is intended for qualified investors.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WCVqYCDYEeWCLu74WLgP4w")]
[Description(@"Specifies if the fund is intended for qualified investors.")]
[DerivedFrom(typeof(FundIntentionCode))]
public enum FundIntention1Code
{
    /// <summary>
    /// Qualified.
    /// Encoded/decoded by serializers as &quot;YQUA&quot;.
    /// </summary>
    [EnumMember(Value = "YQUA")]
    [IsoId("_YBiiASDYEeWCLu74WLgP4w")]
    [Description(@"Qualified.")]
    Qualified = FundIntentionCode.Qualified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not qualified.
    /// Encoded/decoded by serializers as &quot;NQUA&quot;.
    /// </summary>
    [EnumMember(Value = "NQUA")]
    [IsoId("_uOC44TavEeWxoIK_IhudJg")]
    [Description(@"Not qualified.")]
    NotQualified = FundIntentionCode.NotQualified, // same ordinal as derivation source for type conversions
}
