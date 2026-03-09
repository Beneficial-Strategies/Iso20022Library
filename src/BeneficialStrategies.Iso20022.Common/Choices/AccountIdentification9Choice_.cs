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
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts and balance information.
    /// </summary>
    [KnownType(typeof(AccountIdentification9Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification9Choice.AccountsListAndBalanceDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification9Choice.ForAllAccounts),nameof(AccountIdentification9Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification9Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification9Choice.AccountsListAndBalanceDetails))]
    #endif
    [IsoId("_QSNvZdp-Ed-ak6NoX_4Aeg_-1885189248")]
    [DisplayName("Account Identification 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification9Choice_
    #else
    public abstract partial class AccountIdentification9Choice_
    #endif
    {
    }
}
