// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of ATM transaction selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qqjTwIqnEeS4a4abTJTSSw")]
[Description(@"Describes the type of ATM transaction selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType2Code
{
    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_w4CJsYqnEeS4a4abTJTSSw")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_w8NfEYqnEeS4a4abTJTSSw")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_xDhA84qnEeS4a4abTJTSSw")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery = ATMServiceTypeCode.PINRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_xH-qM4qnEeS4a4abTJTSSw")]
    [Description(@"Unblock the PIN.")]
    PINUnblock = ATMServiceTypeCode.PINUnblock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_xMJ_kYqnEeS4a4abTJTSSw")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_xV1gA4qnEeS4a4abTJTSSw")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_xaKmY4qnEeS4a4abTJTSSw")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_xhwcI4qnEeS4a4abTJTSSw")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal = ATMServiceTypeCode.SupervisedWithdrawal, // same ordinal as derivation source for type conversions
}
