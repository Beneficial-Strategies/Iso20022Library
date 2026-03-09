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
    /// Choice between account details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError3Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError3Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountOrBusinessError3Choice.Account),nameof(AccountOrBusinessError3Choice.Account))]
    [JsonDerivedType(typeof(AccountOrBusinessError3Choice.BusinessError),nameof(AccountOrBusinessError3Choice.BusinessError))]
    #endif
    [IsoId("_fd0Qx5-WEee28J7y9KlTWg")]
    [DisplayName("Account Or Business Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountOrBusinessError3Choice_
    #else
    public abstract partial class AccountOrBusinessError3Choice_
    #endif
    {
    }
}
