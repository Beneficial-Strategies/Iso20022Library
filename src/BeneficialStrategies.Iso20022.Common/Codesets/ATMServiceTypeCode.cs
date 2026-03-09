// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of transaction available for a customer on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bItp4IogEeSirOZJBRz_nA")]
[Description(@"Describes the type of transaction available for a customer on an ATM.")]
[Derivations(typeof(ATMServiceType10Code),typeof(ATMServiceType2Code),typeof(ATMServiceType7Code),typeof(ATMServiceType6Code),typeof(ATMServiceType8Code),typeof(ATMServiceType1Code),typeof(ATMServiceType5Code),typeof(ATMServiceType4Code),typeof(ATMServiceType3Code),typeof(ATMServiceType9Code))]
public enum ATMServiceTypeCode
{
    /// <summary>
    /// Amount and notes values are chosen by the customer.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_fd3FMIogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes values are chosen by the customer.")]
    ChosenWithdrawal,
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.
    /// Encoded/decoded by serializers as &quot;PATH&quot;.
    /// </summary>
    [EnumMember(Value = "PATH")]
    [IsoId("_ikdCsIogEeSirOZJBRz_nA")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel, for instance a mobile. The amount could be absent from the withdrawal request message.")]
    PreAuthorisedWithdrawal,
    
    /// <summary>
    /// Amount and notes Values are pre-defined by the customer profile.
    /// Encoded/decoded by serializers as &quot;PRFL&quot;.
    /// </summary>
    [EnumMember(Value = "PRFL")]
    [IsoId("_lIKVkIogEeSirOZJBRz_nA")]
    [Description(@"Amount and notes Values are pre-defined by the customer profile.")]
    ProfileWithdrawal,
    
    /// <summary>
    /// Standard withdrawal of items.
    /// Encoded/decoded by serializers as &quot;STDR&quot;.
    /// </summary>
    [EnumMember(Value = "STDR")]
    [IsoId("_nt3MgIogEeSirOZJBRz_nA")]
    [Description(@"Standard withdrawal of items.")]
    StandardWithdrawal,
    
    /// <summary>
    /// Withdrawal authorised by a supervisor.
    /// Encoded/decoded by serializers as &quot;SPRV&quot;.
    /// </summary>
    [EnumMember(Value = "SPRV")]
    [IsoId("_qlSsoIogEeSirOZJBRz_nA")]
    [Description(@"Withdrawal authorised by a supervisor.")]
    SupervisedWithdrawal,
    
    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_boN9AIqnEeS4a4abTJTSSw")]
    [Description(@"Modification of the card PIN value.")]
    PINChange,
    
    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_frzHMIqnEeS4a4abTJTSSw")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery,
    
    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_hsZtAIqnEeS4a4abTJTSSw")]
    [Description(@"Unblock the PIN.")]
    PINUnblock,
    
    /// <summary>
    /// Ask for account statement information to a related custumer account.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_vDDg4IquEeSIDtZ76p6McQ")]
    [Description(@"Ask for account statement information to a related custumer account.")]
    AccountStatements,
    
    /// <summary>
    /// Verification of the card.
    /// Encoded/decoded by serializers as &quot;CDVF&quot;.
    /// </summary>
    [EnumMember(Value = "CDVF")]
    [IsoId("_xv8k8IquEeSIDtZ76p6McQ")]
    [Description(@"Verification of the card.")]
    CardVerification,
    
    /// <summary>
    /// Ask for customer profile with eventualy related account information.
    /// Encoded/decoded by serializers as &quot;CMPF&quot;.
    /// </summary>
    [EnumMember(Value = "CMPF")]
    [IsoId("_5oRzIIquEeSIDtZ76p6McQ")]
    [Description(@"Ask for customer profile with eventualy related account information.")]
    CustomerProfile,
    
    /// <summary>
    /// Ask to a DCC service provider to qualify the currency conversion for the card.
    /// Encoded/decoded by serializers as &quot;DCCS&quot;.
    /// </summary>
    [EnumMember(Value = "DCCS")]
    [IsoId("_7ONPIIquEeSIDtZ76p6McQ")]
    [Description(@"Ask to a DCC service provider to qualify the currency conversion for the card.")]
    DynamicCurrencyConversion,
    
    /// <summary>
    /// Ask for exchange rate for the ongoing deposit transaction.
    /// Encoded/decoded by serializers as &quot;XRTD&quot;.
    /// </summary>
    [EnumMember(Value = "XRTD")]
    [IsoId("_9f0scIquEeSIDtZ76p6McQ")]
    [Description(@"Ask for exchange rate for the ongoing deposit transaction.")]
    ExchangeRateDeposit,
    
    /// <summary>
    /// Ask for exchange rate for the ongoing withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;XRTW&quot;.
    /// </summary>
    [EnumMember(Value = "XRTW")]
    [IsoId("_ABibQIqvEeSIDtZ76p6McQ")]
    [Description(@"Ask for exchange rate for the ongoing withdrawal transaction.")]
    ExchangeRateWithdrawal,
    
    /// <summary>
    /// Select the EMV applications allowed by the acquirer.
    /// Encoded/decoded by serializers as &quot;EMVS&quot;.
    /// </summary>
    [EnumMember(Value = "EMVS")]
    [IsoId("_CrHFkIqvEeSIDtZ76p6McQ")]
    [Description(@"Select the EMV applications allowed by the acquirer.")]
    SelectEMVApplication,
    
    /// <summary>
    /// Balance inquiry.
    /// Encoded/decoded by serializers as &quot;BLCQ&quot;.
    /// </summary>
    [EnumMember(Value = "BLCQ")]
    [IsoId("_j4lk0Iq0EeSIDtZ76p6McQ")]
    [Description(@"Balance inquiry.")]
    BalanceInquiry,
    
    /// <summary>
    /// Deposit of items.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_pbi3EIq0EeSIDtZ76p6McQ")]
    [Description(@"Deposit of items.")]
    Deposit,
    
    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_-ywhoK3-EeWL1uap3dNhCQ")]
    [Description(@"Making change between media types.")]
    MakingChange,
    
    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_CHlvcK3_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit,
    
    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_GccP0K3_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit,
    
    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as &quot;TRFC&quot;.
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_4pTgAK4SEeWZgJQOa6iKCQ")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer,
    
    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as &quot;TRFI&quot;.
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_83KAgK4SEeWZgJQOa6iKCQ")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer,
    
    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as &quot;TRFP&quot;.
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_J3VTcK4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment,
    
}
