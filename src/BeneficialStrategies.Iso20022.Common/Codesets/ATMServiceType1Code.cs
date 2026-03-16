// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of withdrawal selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yhZnkIogEeSirOZJBRz_nA")]
[Description(@"Describes the type of withdrawal selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType1Code
{
    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_1VkYUYogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal = ATMServiceTypeCode.ChosenWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_1aqTsYogEeSirOZJBRz_nA")]
    [Description(
        @"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message."
    )]
    PreAuthorisedWithdrawal = ATMServiceTypeCode.PreAuthorisedWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_1gFmQYogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal = ATMServiceTypeCode.ProfileWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_1mPRkYogEeSirOZJBRz_nA")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal = ATMServiceTypeCode.StandardWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_1rPtYYogEeSirOZJBRz_nA")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal = ATMServiceTypeCode.SupervisedWithdrawal, // same ordinal as derivation source for type conversions
}
