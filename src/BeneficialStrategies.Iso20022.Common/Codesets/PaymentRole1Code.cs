// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Role associated with a specific party in relation to a payment instruction. The role identifies either the specific function of the party, or the party&apos;s rights regarding management of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z7RUUNp-Ed-ak6NoX_4Aeg_-925433456")]
[Description(
    @"Role associated with a specific party in relation to a payment instruction. The role identifies either the specific function of the party, or the party's rights regarding management of the instruction."
)]
[DerivedFrom(typeof(PartyRoleCode))]
public enum PaymentRole1Code
{
    /// <summary>
    /// Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers ormanagement of standing instructions for liquidity control.
    /// Encoded/decoded by serializers as &quot;LQMG&quot;.
    /// </summary>
    [EnumMember(Value = "LQMG")]
    [IsoId("_Z7RUUdp-Ed-ak6NoX_4Aeg_-925433454")]
    [Description(
        @"Party in a financial institution responsible for the management of liquidity for the financial institution. This party has access to some functions available on the system, such as the liquidity transfers ormanagement of standing instructions for liquidity control."
    )]
    LiquidityManager = PartyRoleCode.LiquidityManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment.
    /// Encoded/decoded by serializers as &quot;LMMG&quot;.
    /// </summary>
    [EnumMember(Value = "LMMG")]
    [IsoId("_Z7RUUtp-Ed-ak6NoX_4Aeg_-925433453")]
    [Description(
        @"Party in a financial institution responsible for the management of the limits. This party is responsible for fixing, modifying, or suspending limits as relevant for the management of counterpart risk or systemic risk containment."
    )]
    LimitManager = PartyRoleCode.LimitManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions.
    /// Encoded/decoded by serializers as &quot;PYMG&quot;.
    /// </summary>
    [EnumMember(Value = "PYMG")]
    [IsoId("_Z7RUU9p-Ed-ak6NoX_4Aeg_-925433452")]
    [Description(
        @"Party in a financial institution responsible for the management of payment processing for the financial institution. This includes authorising, recycling, and modification of payment transactions."
    )]
    PaymentManager = PartyRoleCode.PaymentManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information.
    /// Encoded/decoded by serializers as &quot;REDR&quot;.
    /// </summary>
    [EnumMember(Value = "REDR")]
    [IsoId("_Z7RUVNp-Ed-ak6NoX_4Aeg_-925433443")]
    [Description(
        @"Party in a financial institution entitled to obtain information from the system, but not act upon/alter this information."
    )]
    Reader = PartyRoleCode.Reader, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party responsible for managing the recovery functions related to a system.
    /// Encoded/decoded by serializers as &quot;BKMG&quot;.
    /// </summary>
    [EnumMember(Value = "BKMG")]
    [IsoId("_Z7RUVdp-Ed-ak6NoX_4Aeg_-925433442")]
    [Description(@"Party responsible for managing the recovery functions related to a system.")]
    BackupManager = PartyRoleCode.BackupManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party in a financial institution responsible for the management of settlement processing.
    /// Encoded/decoded by serializers as &quot;STMG&quot;.
    /// </summary>
    [EnumMember(Value = "STMG")]
    [IsoId("_Z7RUVtp-Ed-ak6NoX_4Aeg_-925433441")]
    [Description(
        @"Party in a financial institution responsible for the management of settlement processing."
    )]
    SettlementManager = PartyRoleCode.SettlementManager, // same ordinal as derivation source for type conversions
}
