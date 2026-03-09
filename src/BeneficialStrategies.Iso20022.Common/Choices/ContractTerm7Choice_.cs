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
    /// Specifies whether the transaction is open term, that is. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [KnownType(typeof(ContractTerm7Choice.Open))]
    [KnownType(typeof(ContractTerm7Choice.Fixed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ContractTerm7Choice.Open),nameof(ContractTerm7Choice.Open))]
    [JsonDerivedType(typeof(ContractTerm7Choice.Fixed),nameof(ContractTerm7Choice.Fixed))]
    #endif
    [IsoId("_xcgx0a5qEeuo-IflVgGqiA")]
    [DisplayName("Contract Term 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractTerm7Choice_
    #else
    public abstract partial class ContractTerm7Choice_
    #endif
    {
    }
}
