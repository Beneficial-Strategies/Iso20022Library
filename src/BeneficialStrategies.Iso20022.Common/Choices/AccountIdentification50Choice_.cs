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
    /// Choice between all accounts (GENR - General in ISO 15022) or one or more selected accounts.
    /// </summary>
    [KnownType(typeof(AccountIdentification50Choice.ForAllAccounts))]
    [KnownType(typeof(AccountIdentification50Choice.AccountsList))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification50Choice.ForAllAccounts),nameof(AccountIdentification50Choice.ForAllAccounts))]
    [JsonDerivedType(typeof(AccountIdentification50Choice.AccountsList),nameof(AccountIdentification50Choice.AccountsList))]
    #endif
    [IsoId("_pdA8Hzi7Eeydid5dcNPKvg")]
    [DisplayName("Account Identification 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification50Choice_
    #else
    public abstract partial class AccountIdentification50Choice_
    #endif
    {
    }
}
