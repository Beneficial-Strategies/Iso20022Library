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
    [KnownType(typeof(AccountIdentification5Choice.IBAN))]
    [KnownType(typeof(AccountIdentification5Choice.BBAN))]
    [KnownType(typeof(AccountIdentification5Choice.DomesticAccount))]
    [KnownType(typeof(AccountIdentification5Choice.DepositoryAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification5Choice.IBAN),nameof(AccountIdentification5Choice.IBAN))]
    [JsonDerivedType(typeof(AccountIdentification5Choice.BBAN),nameof(AccountIdentification5Choice.BBAN))]
    [JsonDerivedType(typeof(AccountIdentification5Choice.DomesticAccount),nameof(AccountIdentification5Choice.DomesticAccount))]
    [JsonDerivedType(typeof(AccountIdentification5Choice.DepositoryAccount),nameof(AccountIdentification5Choice.DepositoryAccount))]
    #endif
    [IsoId("_Pdd4stp-Ed-ak6NoX_4Aeg_-1989600356")]
    [DisplayName("Account Identification 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification5Choice_
    #else
    public abstract partial class AccountIdentification5Choice_
    #endif
    {
    }
}
