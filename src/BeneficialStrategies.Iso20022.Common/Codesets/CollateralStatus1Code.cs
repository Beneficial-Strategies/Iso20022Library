// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HlWPQMUcEeiF-qqyf1JQhg")]
[Description(@"Provides the status after comparing the total collateral required and the total collateral value of all transactions covered in the message as a code")]
[DerivedFrom(typeof(CollateralStatusCode))]
public enum CollateralStatus1Code
{
    /// <summary>
    /// Excess of collateral.
    /// Encoded/decoded by serializers as &quot;EXCS&quot;.
    /// </summary>
    [EnumMember(Value = "EXCS")]
    [IsoId("_JpYjkcUcEeiF-qqyf1JQhg")]
    [Description(@"Excess of collateral.")]
    CollateralExcess = CollateralStatusCode.CollateralExcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shortage of collateral.
    /// Encoded/decoded by serializers as &quot;DEFI&quot;.
    /// </summary>
    [EnumMember(Value = "DEFI")]
    [IsoId("_JuqsMcUcEeiF-qqyf1JQhg")]
    [Description(@"Shortage of collateral.")]
    CollateralShortage = CollateralStatusCode.CollateralShortage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral covers the exposure and there is no excess.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_J0VPUcUcEeiF-qqyf1JQhg")]
    [Description(@"Collateral covers the exposure and there is no excess.")]
    NoExcessCollateral = CollateralStatusCode.NoExcessCollateral, // same ordinal as derivation source for type conversions
    
}
