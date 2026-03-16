// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral reported is applied or in excess.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t9d80AF7EeutW5-TpeYJhA")]
[Description(@"Specifies if the collateral reported is applied or in excess.")]
[DerivedFrom(typeof(CollateralAppliedExcessCode))]
public enum CollateralAppliedExcess1Code
{
    /// <summary>
    /// Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider.
    /// Encoded/decoded by serializers as &quot;APLD&quot;.
    /// </summary>
    [EnumMember(Value = "APLD")]
    [IsoId("_v1E-sQF7EeutW5-TpeYJhA")]
    [Description(
        @"Collateral used by the collateral receiver to discharge liabilities owed to it by the collateral provider.|"
    )]
    Applied = CollateralAppliedExcessCode.Applied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it.
    /// Encoded/decoded by serializers as &quot;EXCS&quot;.
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_v-TzMQF7EeutW5-TpeYJhA")]
    [Description(
        @"Collateral held by the collateral receiver either in anticipation of future liabilities or towards previously liabilities no longer owed to it.|"
    )]
    Excess = CollateralAppliedExcessCode.Excess, // same ordinal as derivation source for type conversions
}
