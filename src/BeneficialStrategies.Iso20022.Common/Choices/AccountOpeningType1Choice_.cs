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
    /// Choice of formats for the account opening type.
    /// </summary>
    [KnownType(typeof(AccountOpeningType1Choice.Code))]
    [KnownType(typeof(AccountOpeningType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountOpeningType1Choice.Code),nameof(AccountOpeningType1Choice.Code))]
    [JsonDerivedType(typeof(AccountOpeningType1Choice.Proprietary),nameof(AccountOpeningType1Choice.Proprietary))]
    #endif
    [IsoId("_wuO4IEzJEeafiMTDrtSnyw")]
    [DisplayName("Account Opening Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountOpeningType1Choice_
    #else
    public abstract partial class AccountOpeningType1Choice_
    #endif
    {
    }
}
