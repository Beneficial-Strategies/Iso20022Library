// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cash Account Identification9Choice.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification9Choice.BlockChainCashWallet))]
    [KnownType(typeof(CashAccountIdentification9Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification9Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAccountIdentification9Choice.BlockChainCashWallet),nameof(CashAccountIdentification9Choice.BlockChainCashWallet))]
    [JsonDerivedType(typeof(CashAccountIdentification9Choice.IBAN),nameof(CashAccountIdentification9Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification9Choice.Proprietary),nameof(CashAccountIdentification9Choice.Proprietary))]
    [IsoId("_lf5ssZBPEe-COKgew96POA")]
    [DisplayName("Cash Account Identification9Choice")]
    public abstract partial record CashAccountIdentification9Choice_
    {
    }
}
