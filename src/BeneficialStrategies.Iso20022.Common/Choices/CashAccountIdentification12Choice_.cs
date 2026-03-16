// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification12Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification12Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification12Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification12Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification12Choice.BlockChainCashWallet),nameof(CashAccountIdentification12Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(CashAccountIdentification12Choice.IBAN),nameof(CashAccountIdentification12Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification12Choice.Proprietary),nameof(CashAccountIdentification12Choice.Proprietary))]
    [IsoId("_kv-O-Zt3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification12Choice")]
    public abstract partial record CashAccountIdentification12Choice_
    {
    }
}
