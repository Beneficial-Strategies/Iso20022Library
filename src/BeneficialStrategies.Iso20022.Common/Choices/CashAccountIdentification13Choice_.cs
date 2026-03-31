// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification13Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification13Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification13Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CashAccountIdentification13Choice.BlockChainCashWallet),
        nameof(CashAccountIdentification13Choice.BlockChainCashWallet)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification13Choice.IBAN),
        nameof(CashAccountIdentification13Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification13Choice.Proprietary),
        nameof(CashAccountIdentification13Choice.Proprietary)
    )]
    [IsoId("_l6YNnZt3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification13Choice")]
    public abstract record CashAccountIdentification13Choice_ { }
}
