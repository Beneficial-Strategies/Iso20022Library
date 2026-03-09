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
    [KnownType(typeof(AccountIdentification31Choice.IBAN))]
    [KnownType(typeof(AccountIdentification31Choice.BBAN))]
    [KnownType(typeof(AccountIdentification31Choice.UPIC))]
    [KnownType(typeof(AccountIdentification31Choice.DomesticAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification31Choice.IBAN),nameof(AccountIdentification31Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.BBAN),nameof(AccountIdentification31Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.UPIC),nameof(AccountIdentification31Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification31Choice.DomesticAccount),nameof(AccountIdentification31Choice.DomesticAccount))]
    #endif
    [IsoId("_sg7o4PSaEeSfzLT5J5kvFg")]
    [DisplayName("Account Identification 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification31Choice_
    #else
    public abstract partial class AccountIdentification31Choice_
    #endif
    {
    }
}
