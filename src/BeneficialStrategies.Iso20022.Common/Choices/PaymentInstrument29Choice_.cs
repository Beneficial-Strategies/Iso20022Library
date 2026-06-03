// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PaymentInstrument29Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between types of payment instrument, that is, cheque, credit transfer, direct debit, investment account or payment card.</summary>
    [IsoId("9972a6dd-dd48-4f4e-abea-5e90a1b1816e")]
    [DisplayName("Payment Instrument 29 Choice")]
    [KnownType(typeof(PaymentCardDetails))]
    [JsonDerivedType(typeof(PaymentCardDetails), nameof(PaymentCardDetails))]
    [KnownType(typeof(CreditTransferDetails))]
    [JsonDerivedType(typeof(CreditTransferDetails), nameof(CreditTransferDetails))]
    [KnownType(typeof(DirectDebitDetails))]
    [JsonDerivedType(typeof(DirectDebitDetails), nameof(DirectDebitDetails))]
    [KnownType(typeof(ChequeDetails))]
    [JsonDerivedType(typeof(ChequeDetails), nameof(ChequeDetails))]
    [KnownType(typeof(BankersDraftDetails))]
    [JsonDerivedType(typeof(BankersDraftDetails), nameof(BankersDraftDetails))]
    [KnownType(typeof(CashAccountDetails))]
    [JsonDerivedType(typeof(CashAccountDetails), nameof(CashAccountDetails))]
    [KnownType(typeof(BlockChainCashWallet))]
    [JsonDerivedType(typeof(BlockChainCashWallet), nameof(BlockChainCashWallet))]
    public abstract record PaymentInstrument29Choice_;
}
