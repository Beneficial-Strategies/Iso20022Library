// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PaymentInstrument30Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between types of payment instrument, that is, cheque, credit transfer, direct debit, investment account or payment card.</summary>
    [IsoId("a6bd61f1-eae0-44df-aeb0-bcee442af5df")]
    [DisplayName("Payment Instrument 30 Choice")]
    [KnownType(typeof(PaymentCardDetails))]
    [KnownType(typeof(CreditTransferDetails))]
    [KnownType(typeof(DirectDebitDetails))]
    [KnownType(typeof(ChequeDetails))]
    [KnownType(typeof(BankersDraftDetails))]
    [KnownType(typeof(CashAccountDetails))]
    [KnownType(typeof(BlockChainCashWallet))]
    [JsonDerivedType(typeof(PaymentCardDetails))]
    [JsonDerivedType(typeof(CreditTransferDetails))]
    [JsonDerivedType(typeof(DirectDebitDetails))]
    [JsonDerivedType(typeof(ChequeDetails))]
    [JsonDerivedType(typeof(BankersDraftDetails))]
    [JsonDerivedType(typeof(CashAccountDetails))]
    [JsonDerivedType(typeof(BlockChainCashWallet))]
    public abstract record PaymentInstrument30Choice_;
}
