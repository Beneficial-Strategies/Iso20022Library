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
    /// Choice of formats for the specification of the type of account usage.
    /// </summary>
    [KnownType(typeof(AccountUsageType1Choice.Code))]
    [KnownType(typeof(AccountUsageType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountUsageType1Choice.Code),nameof(AccountUsageType1Choice.Code))]
    [JsonDerivedType(typeof(AccountUsageType1Choice.Proprietary),nameof(AccountUsageType1Choice.Proprietary))]
    #endif
    [IsoId("_xerkExKCEeKj15WxqwlXPw")]
    [DisplayName("Account Usage Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountUsageType1Choice_
    #else
    public abstract partial class AccountUsageType1Choice_
    #endif
    {
    }
}
