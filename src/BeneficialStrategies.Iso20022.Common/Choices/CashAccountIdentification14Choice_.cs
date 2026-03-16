// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification14Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification14Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification14Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification14Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification14Choice.BlockChainCashWallet),nameof(CashAccountIdentification14Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(CashAccountIdentification14Choice.IBAN),nameof(CashAccountIdentification14Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification14Choice.Proprietary),nameof(CashAccountIdentification14Choice.Proprietary))]
    [IsoId("_m45sd5t3Ee-wQIOX0djF2w")]
    [DisplayName("Cash Account Identification14Choice")]
    public abstract partial record CashAccountIdentification14Choice_
    {
    }
}
