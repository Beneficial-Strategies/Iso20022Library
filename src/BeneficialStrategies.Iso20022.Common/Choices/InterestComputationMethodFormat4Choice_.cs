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
    /// Choice between a standard code or proprietary code to specify the type of interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethodFormat4Choice.Code))]
    [KnownType(typeof(InterestComputationMethodFormat4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestComputationMethodFormat4Choice.Code),nameof(InterestComputationMethodFormat4Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethodFormat4Choice.Proprietary),nameof(InterestComputationMethodFormat4Choice.Proprietary))]
    #endif
    [IsoId("_atvUATm6EeWV5sr121Fc8A")]
    [DisplayName("Interest Computation Method Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestComputationMethodFormat4Choice_
    #else
    public abstract partial class InterestComputationMethodFormat4Choice_
    #endif
    {
    }
}
