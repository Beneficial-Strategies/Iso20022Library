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
    /// Choice between a code or a data source scheme to determine the interest computation method.
    /// </summary>
    [KnownType(typeof(InterestComputationMethod3Choice.Code))]
    [KnownType(typeof(InterestComputationMethod3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestComputationMethod3Choice.Code),nameof(InterestComputationMethod3Choice.Code))]
    [JsonDerivedType(typeof(InterestComputationMethod3Choice.Proprietary),nameof(InterestComputationMethod3Choice.Proprietary))]
    #endif
    [IsoId("_xpR2AZEjEeakHoV5BVecAQ")]
    [DisplayName("Interest Computation Method 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestComputationMethod3Choice_
    #else
    public abstract partial class InterestComputationMethod3Choice_
    #endif
    {
    }
}
