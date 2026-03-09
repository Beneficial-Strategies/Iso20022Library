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
    [KnownType(typeof(AccountIdentification39Choice.Card))]
    [KnownType(typeof(AccountIdentification39Choice.MSISDN))]
    [KnownType(typeof(AccountIdentification39Choice.EMail))]
    [KnownType(typeof(AccountIdentification39Choice.IBAN))]
    [KnownType(typeof(AccountIdentification39Choice.BBAN))]
    [KnownType(typeof(AccountIdentification39Choice.UPIC))]
    [KnownType(typeof(AccountIdentification39Choice.Domestic))]
    [KnownType(typeof(AccountIdentification39Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification39Choice.Card),nameof(AccountIdentification39Choice.Card))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.MSISDN),nameof(AccountIdentification39Choice.MSISDN))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.EMail),nameof(AccountIdentification39Choice.EMail))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.IBAN),nameof(AccountIdentification39Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.BBAN),nameof(AccountIdentification39Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.UPIC),nameof(AccountIdentification39Choice.UPIC))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.Domestic),nameof(AccountIdentification39Choice.Domestic))]
    [JsonDerivedType(typeof(AccountIdentification39Choice.Other),nameof(AccountIdentification39Choice.Other))]
    #endif
    [IsoId("_metiEdmpEeeN3v2fup_Shw")]
    [DisplayName("Account Identification 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification39Choice_
    #else
    public abstract partial class AccountIdentification39Choice_
    #endif
    {
    }
}
