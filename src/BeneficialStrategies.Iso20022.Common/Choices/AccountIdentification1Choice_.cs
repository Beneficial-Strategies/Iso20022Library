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
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification1Choice.IBAN))]
    [KnownType(typeof(AccountIdentification1Choice.BBAN))]
    [KnownType(typeof(AccountIdentification1Choice.UPIC))]
    [KnownType(typeof(AccountIdentification1Choice.DomesticAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification1Choice.IBAN),nameof(AccountIdentification1Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification1Choice.BBAN),nameof(AccountIdentification1Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification1Choice.UPIC),nameof(AccountIdentification1Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification1Choice.DomesticAccount),nameof(AccountIdentification1Choice.DomesticAccount))]
    #endif
    [IsoId("_Pdd4t9p-Ed-ak6NoX_4Aeg_2089502043")]
    [DisplayName("Account Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification1Choice_
    #else
    public abstract partial class AccountIdentification1Choice_
    #endif
    {
    }
}
