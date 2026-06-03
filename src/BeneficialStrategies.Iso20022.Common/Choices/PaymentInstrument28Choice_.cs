// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PaymentInstrument28Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between types of payment instrument, that is, cheque, credit transfer or investment account.</summary>
    [IsoId("c2d0d192-9ba7-44b8-b016-994c62c64439")]
    [DisplayName("Payment Instrument 28 Choice")]
    [KnownType(typeof(CreditTransferDetails))]
    [JsonDerivedType(typeof(CreditTransferDetails), nameof(CreditTransferDetails))]
    [KnownType(typeof(ChequeDetails))]
    [JsonDerivedType(typeof(ChequeDetails), nameof(ChequeDetails))]
    [KnownType(typeof(BankersDraftDetails))]
    [JsonDerivedType(typeof(BankersDraftDetails), nameof(BankersDraftDetails))]
    [KnownType(typeof(CashAccountDetails))]
    [JsonDerivedType(typeof(CashAccountDetails), nameof(CashAccountDetails))]
    [KnownType(typeof(BlockChainCashWallet))]
    [JsonDerivedType(typeof(BlockChainCashWallet), nameof(BlockChainCashWallet))]
    public abstract record PaymentInstrument28Choice_;
}
