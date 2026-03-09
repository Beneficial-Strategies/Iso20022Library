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
    /// Identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification30Choice.Card))]
    [KnownType(typeof(AccountIdentification30Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification30Choice.EMail))]
    [KnownType(typeof(AccountIdentification30Choice.IBAN))]
    [KnownType(typeof(AccountIdentification30Choice.BBAN))]
    [KnownType(typeof(AccountIdentification30Choice.UPIC))]
    [KnownType(typeof(AccountIdentification30Choice.Domestic))]
    [KnownType(typeof(AccountIdentification30Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification30Choice.Card),nameof(AccountIdentification30Choice.Card))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.MSISDN),nameof(AccountIdentification30Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.EMail),nameof(AccountIdentification30Choice.EMail))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.IBAN),nameof(AccountIdentification30Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.BBAN),nameof(AccountIdentification30Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.UPIC),nameof(AccountIdentification30Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.Domestic),nameof(AccountIdentification30Choice.Domestic))]
    [JsonDerivedType(typeof(AccountIdentification30Choice.Other),nameof(AccountIdentification30Choice.Other))]
    #endif
    [IsoId("_cLSqYHs8EeSTS7uHCe8FPQ")]
    [DisplayName("Account Identification 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification30Choice_
    #else
    public abstract partial class AccountIdentification30Choice_
    #endif
    {
    }
}
