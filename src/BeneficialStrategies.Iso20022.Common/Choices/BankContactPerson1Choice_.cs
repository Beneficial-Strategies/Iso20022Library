// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Contact person details in a bank.
    /// </summary>
    [KnownType(typeof(BankContactPerson1Choice.BuyerBankContactPerson))]
    [KnownType(typeof(BankContactPerson1Choice.SellerBankContactPerson))]
    [JsonDerivedType(typeof(BankContactPerson1Choice.BuyerBankContactPerson),nameof(BankContactPerson1Choice.BuyerBankContactPerson))]
    [JsonDerivedType(typeof(BankContactPerson1Choice.SellerBankContactPerson),nameof(BankContactPerson1Choice.SellerBankContactPerson))]
    [IsoId("_eCkSADAZEeOKib24wnHaFg")]
    [DisplayName("Bank Contact Person 1 Choice")]
    public abstract partial record BankContactPerson1Choice_
    {
    }
}
