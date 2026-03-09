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
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat4Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DistributionTypeFormat4Choice.Code),nameof(DistributionTypeFormat4Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat4Choice.Proprietary),nameof(DistributionTypeFormat4Choice.Proprietary))]
    #endif
    [IsoId("_3WE64SXXEeOFIcNWlDEvdQ")]
    [DisplayName("Distribution Type Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionTypeFormat4Choice_
    #else
    public abstract partial class DistributionTypeFormat4Choice_
    #endif
    {
    }
}
