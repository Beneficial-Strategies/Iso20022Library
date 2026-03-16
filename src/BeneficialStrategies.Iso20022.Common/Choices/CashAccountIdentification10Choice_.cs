// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification10Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification10Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification10Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification10Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification10Choice.BlockChainCashWallet),nameof(CashAccountIdentification10Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(CashAccountIdentification10Choice.IBAN),nameof(CashAccountIdentification10Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification10Choice.Proprietary),nameof(CashAccountIdentification10Choice.Proprietary))]
    [IsoId("_jhnlXZt3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification10Choice")]
    public abstract partial record CashAccountIdentification10Choice_
    {
    }
}
