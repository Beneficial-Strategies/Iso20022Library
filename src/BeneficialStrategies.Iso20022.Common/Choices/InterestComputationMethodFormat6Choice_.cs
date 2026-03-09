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
    /// Defines the format to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat6Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestComputationMethodFormat6Choice.Code),nameof(InterestComputationMethodFormat6Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat6Choice.Proprietary),nameof(InterestComputationMethodFormat6Choice.Proprietary))]
    #endif
    [IsoId("_n8gFUSDuEeahCJeThTBhHA")]
    [DisplayName("Interest Computation Method Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestComputationMethodFormat6Choice_
    #else
    public abstract partial class InterestComputationMethodFormat6Choice_
    #endif
    {
    }
}
