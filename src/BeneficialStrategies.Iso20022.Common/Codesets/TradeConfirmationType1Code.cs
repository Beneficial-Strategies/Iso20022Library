// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the contract was electronically confirmed or non-electronically confirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2EE7YA26EeWmAKKPnqYEVQ")]
[Description(
    @"Specifies whether the contract was electronically confirmed or non-electronically confirmed."
)]
[DerivedFrom(typeof(TradeConfirmationTypeCode))]
public enum TradeConfirmationType1Code
{
    /// <summary>
    /// Electronically confirmed.
    /// Encoded/decoded by serializers as &quot;ECNF&quot;.
    /// </summary>
    [EnumMember(Value = "ECNF")]
    [IsoId("_5vcZ4Q26EeWmAKKPnqYEVQ")]
    [Description(@"Electronically confirmed.")]
    ElectronicallyConfirmed = TradeConfirmationTypeCode.ElectronicallyConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-electronically confirmed.
    /// Encoded/decoded by serializers as &quot;YCNF&quot;.
    /// </summary>
    [EnumMember(Value = "YCNF")]
    [IsoId("_5-dtUQ26EeWmAKKPnqYEVQ")]
    [Description(@"Non-electronically confirmed.")]
    NonElectronicallyConfirmed = TradeConfirmationTypeCode.NonElectronicallyConfirmed, // same ordinal as derivation source for type conversions
}
