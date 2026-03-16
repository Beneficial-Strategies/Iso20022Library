// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classification of the requirement that collateral in the collateral account is covering.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-SycYFHPEeeqtLmveSCYmA")]
[Description(
    @"Classification of the requirement that collateral in the collateral account is covering."
)]
[DerivedFrom(typeof(CollateralAccountTypeCode))]
public enum CollateralAccountType3Code
{
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;MGIN&quot;.
    /// </summary>
    [EnumMember(Value = "MGIN")]
    [IsoId("_Ce_XEVHQEeeqtLmveSCYmA")]
    [Description(
        @"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers."
    )]
    Margin = CollateralAccountTypeCode.Margin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the account is used to post collateral that covers clearing member&apos;s default risk.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_Cwzf0VHQEeeqtLmveSCYmA")]
    [Description(
        @"Specifies that the account is used to post collateral that covers clearing member's default risk."
    )]
    DefaultFund = CollateralAccountTypeCode.DefaultFund, // same ordinal as derivation source for type conversions
}
