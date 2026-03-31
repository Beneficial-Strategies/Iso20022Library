// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service to be offered for a customer at an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMServiceType13Code")]
[Description(@"Type of service to be offered for a customer at an ATM.")]
[DerivedFrom(typeof(ATMServiceTypeV2Code))]
public enum ATMServiceType13Code
{
    /// <summary>
    /// Request a full statement (that is a legal statement) related to a customer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_ATMServiceType13Code_AccountStatements")]
    [Description(
        @"Request a full statement (that is a legal statement) related to a customer account."
    )]
    AccountStatements = ATMServiceTypeV2Code.AccountStatements,

    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_ATMServiceType13Code_BalanceInquiry")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry = ATMServiceTypeV2Code.BalanceInquiry,

    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_ATMServiceType13Code_ChosenWithdrawal")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeV2Code.ChosenWithdrawal,

    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_ATMServiceType13Code_NonVerifiedDeposit")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit = ATMServiceTypeV2Code.NonVerifiedDeposit,

    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_ATMServiceType13Code_VerifiedDeposit")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit = ATMServiceTypeV2Code.VerifiedDeposit,

    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_ATMServiceType13Code_MakingChange")]
    [Description(@"Making change between media types.")]
    MakingChange = ATMServiceTypeV2Code.MakingChange,

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_ATMServiceType13Code_PreAuthorisedWithdrawal")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeV2Code.PreAuthorisedWithdrawal,

    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_ATMServiceType13Code_PINChange")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeV2Code.PINChange,

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_ATMServiceType13Code_PINRecovery")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery = ATMServiceTypeV2Code.PINRecovery,

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_ATMServiceType13Code_PINUnblock")]
    [Description(@"Unblock the PIN.")]
    PINUnblock = ATMServiceTypeV2Code.PINUnblock,

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_ATMServiceType13Code_ProfileWithdrawal")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeV2Code.ProfileWithdrawal,

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_ATMServiceType13Code_SupervisedWithdrawal")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal = ATMServiceTypeV2Code.SupervisedWithdrawal,

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_ATMServiceType13Code_StandardWithdrawal")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeV2Code.StandardWithdrawal,

    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_ATMServiceType13Code_CustomerTransfer")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer = ATMServiceTypeV2Code.CustomerTransfer,

    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_ATMServiceType13Code_InterCustomerTransfer")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer = ATMServiceTypeV2Code.InterCustomerTransfer,

    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_ATMServiceType13Code_Payment")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment = ATMServiceTypeV2Code.Payment,
}
