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
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(AccountCriteria3Choice.QueryName))]
    [KnownType(typeof(AccountCriteria3Choice.NewCriteria))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountCriteria3Choice.QueryName),nameof(AccountCriteria3Choice.QueryName))]
    [JsonDerivedType(typeof(AccountCriteria3Choice.NewCriteria),nameof(AccountCriteria3Choice.NewCriteria))]
    #endif
    [IsoId("_PhEfF249EeiU9cctagi5ow")]
    [DisplayName("Account Criteria 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountCriteria3Choice_
    #else
    public abstract partial class AccountCriteria3Choice_
    #endif
    {
    }
}
