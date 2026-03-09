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
    [KnownType(typeof(AccountIdentification23Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification23Choice.AccountsListAndBalanceDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification23Choice.ForAllAccounts),nameof(AccountIdentification23Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification23Choice.AccountsListAndBalanceDetails),nameof(AccountIdentification23Choice.AccountsListAndBalanceDetails))]
    #endif
    [IsoId("_IU89ASqdEeObprHJy8Zrxg")]
    [DisplayName("Account Identification 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification23Choice_
    #else
    public abstract partial class AccountIdentification23Choice_
    #endif
    {
    }
}
