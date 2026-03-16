// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification11Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification11Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification11Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CashAccountIdentification11Choice.BlockChainCashWallet),
        nameof(CashAccountIdentification11Choice.BlockChainCashWallet)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification11Choice.IBAN),
        nameof(CashAccountIdentification11Choice.IBAN)
    )]
    [JsonDerivedType(
        typeof(CashAccountIdentification11Choice.Proprietary),
        nameof(CashAccountIdentification11Choice.Proprietary)
    )]
    [IsoId("_kLpaHpt3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification11Choice")]
    public abstract record CashAccountIdentification11Choice_ { }
}
