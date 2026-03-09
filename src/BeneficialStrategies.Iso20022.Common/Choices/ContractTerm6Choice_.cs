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
    /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
    /// </summary>
    [KnownType(typeof(ContractTerm6Choice.Open))]
    [KnownType(typeof(ContractTerm6Choice.Fixed))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ContractTerm6Choice.Open),nameof(ContractTerm6Choice.Open))]
    [JsonDerivedType(typeof(ContractTerm6Choice.Fixed),nameof(ContractTerm6Choice.Fixed))]
    #endif
    [IsoId("_-9nQEa5OEeuo-IflVgGqiA")]
    [DisplayName("Contract Term 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractTerm6Choice_
    #else
    public abstract partial class ContractTerm6Choice_
    #endif
    {
    }
}
