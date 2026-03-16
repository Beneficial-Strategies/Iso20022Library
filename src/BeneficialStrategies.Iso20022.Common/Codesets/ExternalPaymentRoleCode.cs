// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2y16wML_EeiKUovBlz9Jxg")]
[Description(
    @"Specifies the role associated with a specific party in a payment instruction, as published in an external payment role code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPaymentRole1Code))]
public enum ExternalPaymentRoleCode
{
    /// <summary>
    /// Party responsible for managing the recovery functions related to a system.
    /// Encoded/decoded by serializers as &quot;BKMG&quot;.
    /// </summary>
    [EnumMember(Value = "BKMG")]
    [IsoId("_umh3ifRYEeuLhpyIdtJzwg")]
    [Description(@"Party responsible for managing the recovery functions related to a system.")]
    BackupManager,

    /// <summary>
    /// Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.
    /// Encoded/decoded by serializers as &quot;LMMG&quot;.
    /// </summary>
    [EnumMember(Value = "LMMG")]
    [IsoId("_umh3jPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment."
    )]
    LimitManager,

    /// <summary>
    /// Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers or management of standing instructions for liquidity control.
    /// Encoded/decoded by serializers as &quot;LQMG&quot;.
    /// </summary>
    [EnumMember(Value = "LQMG")]
    [IsoId("_umrogPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers or management of standing instructions for liquidity control."
    )]
    LiquidityManager,

    /// <summary>
    /// Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.
    /// Encoded/decoded by serializers as &quot;PYMG&quot;.
    /// </summary>
    [EnumMember(Value = "PYMG")]
    [IsoId("_umrog_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions."
    )]
    PaymentManager,

    /// <summary>
    /// Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_um0ycPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information."
    )]
    Reader,

    /// <summary>
    /// Party in a financial institution responsible for the management of settlement processing.
    /// Encoded/decoded by serializers as &quot;STMG&quot;.
    /// </summary>
    [EnumMember(Value = "STMG")]
    [IsoId("_um0yc_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Party in a financial institution responsible for the management of settlement processing."
    )]
    SettlementManager,
}
