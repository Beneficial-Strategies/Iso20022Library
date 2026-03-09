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
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat16Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat16Choice.Proprietary))]
    #endif
    [IsoId("_fh8v0UGPEeWqy4niLuXETA")]
    [DisplayName("Intermediate Securities Distribution Type Format 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat16Choice_
    #else
    public abstract partial class IntermediateSecuritiesDistributionTypeFormat16Choice_
    #endif
    {
    }
}
