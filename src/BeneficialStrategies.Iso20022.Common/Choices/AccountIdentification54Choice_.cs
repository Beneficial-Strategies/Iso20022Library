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
    [KnownType(typeof(AccountIdentification54Choice.Card))]
    [KnownType(typeof(AccountIdentification54Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification54Choice.EMail))]
    [KnownType(typeof(AccountIdentification54Choice.IBAN))]
    [KnownType(typeof(AccountIdentification54Choice.BBAN))]
    [KnownType(typeof(AccountIdentification54Choice.UPIC))]
    [KnownType(typeof(AccountIdentification54Choice.Domestic))]
    [KnownType(typeof(AccountIdentification54Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification54Choice.Card),nameof(AccountIdentification54Choice.Card))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.MSISDN),nameof(AccountIdentification54Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.EMail),nameof(AccountIdentification54Choice.EMail))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.IBAN),nameof(AccountIdentification54Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.BBAN),nameof(AccountIdentification54Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.UPIC),nameof(AccountIdentification54Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.Domestic),nameof(AccountIdentification54Choice.Domestic))]
    [JsonDerivedType(typeof(AccountIdentification54Choice.Other),nameof(AccountIdentification54Choice.Other))]
    #endif
    [IsoId("_5jK-cVHSEey4xOoMoOPSJQ")]
    [DisplayName("Account Identification 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification54Choice_
    #else
    public abstract partial class AccountIdentification54Choice_
    #endif
    {
    }
}
