// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_waUkkqMOEeCojJW5vEuTEQ_951032316")]
[Description(@"Specifies the collateral account type.")]
[Derivations(typeof(CollateralAccountType1Code),typeof(CollateralAccountType3Code))]
public enum CollateralAccountTypeCode
{
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_waUkk6MOEeCojJW5vEuTEQ_1771953380")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries.")]
    House,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_waUklKMOEeCojJW5vEuTEQ_-1755897740")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for the clearing member's customers.")]
    Client,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities.
    /// Encoded/decoded by serializers as &quot;LIPR&quot;.
    /// </summary>
    [EnumMember(Value = "LIPR")]
    [IsoId("_waUklaMOEeCojJW5vEuTEQ_384687960")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for liquidity providers (also known as market maker) activities.")]
    LiquidityProvider,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;MGIN&quot;.
    /// </summary>
    [EnumMember(Value = "MGIN")]
    [IsoId("_waUklqMOEeCojJW5vEuTEQ_-470789377")]
    [Description(@"Specifies that the account is used to post collateral that covers the exposure resulting from trades executed for either the clearing member or its subsidiaries, or for the clearing member's customers.")]
    Margin,
    
    /// <summary>
    /// Specifies that the account is used to post collateral that covers clearing member&apos;s default risk.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_waUkl6MOEeCojJW5vEuTEQ_768200063")]
    [Description(@"Specifies that the account is used to post collateral that covers clearing member's default risk.")]
    DefaultFund,
    
}
