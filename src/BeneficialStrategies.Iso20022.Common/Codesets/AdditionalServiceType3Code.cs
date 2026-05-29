// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of additional service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HMAZARN4EfC1ZfCQz0xB3g")]
[Description(@"Type of additional service.")]
[DerivedFrom(typeof(AdditionalServiceTypeCode))]
public enum AdditionalServiceType3Code
{
    /// <summary>
    /// Add card to the card on file.
    /// Encoded/decoded by serializers as &quot;ADCA&quot;.
    /// </summary>
    [EnumMember(Value = "ADCA")]
    [IsoId("_oCTz0V57EfCoP_h9uwd39Q")]
    [Description(@"Add card to the card on file.")]
    CardAddedToCardOnFile = AdditionalServiceTypeCode.CardAddedToCardOnFile,

    /// <summary>
    /// Account name inquiry service.
    /// Encoded/decoded by serializers as &quot;ANIQ&quot;.
    /// </summary>
    [EnumMember(Value = "ANIQ")]
    [IsoId("_NSrcURN4EfC1ZfCQz0xB3g")]
    [Description(@"Account name inquiry service.")]
    AccountNameInquiryService = AdditionalServiceTypeCode.AccountNameInquiryService,

    /// <summary>
    /// Return the account balance with the transaction.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_HTgvQxN4EfC1ZfCQz0xB3g")]
    [Description(@"Return the account balance with the transaction.")]
    AccountBalance = AdditionalServiceTypeCode.AccountBalance,

    /// <summary>
    /// Card activation.
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_HTgvMRN4EfC1ZfCQz0xB3g")]
    [Description(@"Card activation.")]
    CardActivation = AdditionalServiceTypeCode.CardActivation,

    /// <summary>
    /// Validate the credential status.
    /// Encoded/decoded by serializers as &quot;CDTL&quot;.
    /// </summary>
    [EnumMember(Value = "CDTL")]
    [IsoId("_MwLMMRN4EfC1ZfCQz0xB3g")]
    [Description(@"Validate the credential status.")]
    CredentialStatus = AdditionalServiceTypeCode.CredentialStatus,

    /// <summary>
    /// Purchase of goods or services with cashback.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_HTgvMxN4EfC1ZfCQz0xB3g")]
    [Description(@"Purchase of goods or services with cashback.")]
    CashBack = AdditionalServiceTypeCode.CashBack,

    /// <summary>
    /// Dynamic Currency Conversion (DCC).
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_HTgvNRN4EfC1ZfCQz0xB3g")]
    [Description(@"Dynamic Currency Conversion (DCC).")]
    DCC = AdditionalServiceTypeCode.DCC,

    /// <summary>
    /// Instant payment from a cardholder's account to an acceptor's account.
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_HTgvNxN4EfC1ZfCQz0xB3g")]
    [Description(@"Instant payment from a cardholder's account to an acceptor's account.")]
    InstantPayment = AdditionalServiceTypeCode.InstantPayment,

    /// <summary>
    /// Instant transfer of funds from a payer's account to a payee's account.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_HTgvORN4EfC1ZfCQz0xB3g")]
    [Description(@"Instant transfer of funds from a payer's account to a payee's account.")]
    InstantTransfer = AdditionalServiceTypeCode.InstantTransfer,

    /// <summary>
    /// Loyalty services.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_HTgvOxN4EfC1ZfCQz0xB3g")]
    [Description(@"Loyalty services.")]
    Loyalty = AdditionalServiceTypeCode.Loyalty,

    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as &quot;PRST&quot;.
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_HTgvQRN4EfC1ZfCQz0xB3g")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel (amount could be absent).")]
    PreStagedTransaction = AdditionalServiceTypeCode.PreStagedTransaction,

    /// <summary>
    /// Verify the PIN data.
    /// Encoded/decoded by serializers as &quot;PVVS&quot;.
    /// </summary>
    [EnumMember(Value = "PVVS")]
    [IsoId("_Lzp5kRN4EfC1ZfCQz0xB3g")]
    [Description(@"Verify the PIN data.")]
    PINVerificationService = AdditionalServiceTypeCode.PINVerificationService,

    /// <summary>
    /// Request react service.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_L8aM8RN4EfC1ZfCQz0xB3g")]
    [Description(@"Request react service.")]
    React = AdditionalServiceTypeCode.React,

    /// <summary>
    /// Smart Account verification service.
    /// Encoded/decoded by serializers as &quot;SAVS&quot;.
    /// </summary>
    [EnumMember(Value = "SAVS")]
    [IsoId("_MFIrIRN4EfC1ZfCQz0xB3g")]
    [Description(@"Smart Account verification service.")]
    SmartAccountVerificationService = AdditionalServiceTypeCode.SmartAccountVerificationService,

    /// <summary>
    /// Processing the transaction on behalf of the Issuer.
    /// Encoded/decoded by serializers as &quot;STIP&quot;.
    /// </summary>
    [EnumMember(Value = "STIP")]
    [IsoId("_MNFGMRN4EfC1ZfCQz0xB3g")]
    [Description(@"Processing the transaction on behalf of the Issuer.")]
    StandInProcessing = AdditionalServiceTypeCode.StandInProcessing,

    /// <summary>
    /// Transaction identification service.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_MVA6MRN4EfC1ZfCQz0xB3g")]
    [Description(@"Transaction identification service.")]
    TransactionIdentificationService = AdditionalServiceTypeCode.TransactionIdentificationService,
}
