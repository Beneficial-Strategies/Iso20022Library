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
    /// Choice of formats for the designation of an account.
    /// </summary>
    [KnownType(typeof(AccountDesignation1Choice.Code))]
    [KnownType(typeof(AccountDesignation1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountDesignation1Choice.Code),nameof(AccountDesignation1Choice.Code))]
    [JsonDerivedType(typeof(AccountDesignation1Choice.Proprietary),nameof(AccountDesignation1Choice.Proprietary))]
    #endif
    [IsoId("_gpWFICCzEeWJd9HF2tO7BA")]
    [DisplayName("Account Designation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountDesignation1Choice_
    #else
    public abstract partial class AccountDesignation1Choice_
    #endif
    {
    }
}
