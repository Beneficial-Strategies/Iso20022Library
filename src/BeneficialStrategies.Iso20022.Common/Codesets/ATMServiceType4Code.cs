// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service to be offered for a customer at an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kpAfsIq1EeSIDtZ76p6McQ")]
[Description(@"Type of service to be offered for a customer at an ATM.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType4Code
{
    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_q0NdsYq1EeSIDtZ76p6McQ")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements = ATMServiceTypeCode.AccountStatements, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_rAu2w4q1EeSIDtZ76p6McQ")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeCode.BalanceInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of items.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_r33TE4q1EeSIDtZ76p6McQ")]
    [Description(@"Deposit of items.")]
    Deposit = ATMServiceTypeCode.Deposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_sHXHo4q1EeSIDtZ76p6McQ")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_tePbA4q1EeSIDtZ76p6McQ")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_ttIyo4q1EeSIDtZ76p6McQ")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_uqYeA4q1EeSIDtZ76p6McQ")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_-zpAkYq1EeSIDtZ76p6McQ")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions
}
