// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification15Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification15Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification15Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification15Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification15Choice.BlockChainCashWallet),nameof(CashAccountIdentification15Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(CashAccountIdentification15Choice.IBAN),nameof(CashAccountIdentification15Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification15Choice.Proprietary),nameof(CashAccountIdentification15Choice.Proprietary))]
    [IsoId("_nLmlDZt3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification15Choice")]
    public abstract partial record CashAccountIdentification15Choice_
    {
    }
}
