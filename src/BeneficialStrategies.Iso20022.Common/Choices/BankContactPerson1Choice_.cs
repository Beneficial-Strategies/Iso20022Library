// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Contact person details in a bank.
    /// </summary>
    [KnownType(typeof(BankContactPerson1Choice.BuyerBankContactPerson))]
    [KnownType(typeof(BankContactPerson1Choice.SellerBankContactPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BankContactPerson1Choice.BuyerBankContactPerson),nameof(BankContactPerson1Choice.BuyerBankContactPerson))]
    [JsonDerivedType(typeof(BankContactPerson1Choice.SellerBankContactPerson),nameof(BankContactPerson1Choice.SellerBankContactPerson))]
    #endif
    [IsoId("_eCkSADAZEeOKib24wnHaFg")]
    [DisplayName("Bank Contact Person 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BankContactPerson1Choice_
    #else
    public abstract partial class BankContactPerson1Choice_
    #endif
    {
    }
}
