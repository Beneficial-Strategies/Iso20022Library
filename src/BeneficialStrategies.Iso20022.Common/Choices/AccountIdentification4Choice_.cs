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
    /// Specifies the unique identification of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(AccountIdentification4Choice.IBAN))]
    [KnownType(typeof(AccountIdentification4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification4Choice.IBAN),nameof(AccountIdentification4Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification4Choice.Other),nameof(AccountIdentification4Choice.Other))]
    #endif
    [IsoId("_Pdwzodp-Ed-ak6NoX_4Aeg_-1833658219")]
    [DisplayName("Account Identification 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification4Choice_
    #else
    public abstract partial class AccountIdentification4Choice_
    #endif
    {
    }
}
