// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the unique identification of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification82Choice.IBAN))]
    [KnownType(typeof(AccountIdentification82Choice.BlockChainCashWallet))]
    [KnownType(typeof(AccountIdentification82Choice.Other))]
    [JsonDerivedType(typeof(AccountIdentification82Choice.IBAN), nameof(AccountIdentification82Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification82Choice.BlockChainCashWallet), nameof(AccountIdentification82Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(AccountIdentification82Choice.Other), nameof(AccountIdentification82Choice.Other))]
    [IsoId("5d432272-b07c-4f64-a13b-2255d171423d")]
    [DisplayName("AccountIdentification82Choice")]
    public abstract record AccountIdentification82Choice_ { }
}
