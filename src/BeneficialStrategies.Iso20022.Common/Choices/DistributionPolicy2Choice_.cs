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
    /// Choice of format for a distribution policy.
    /// </summary>
    [KnownType(typeof(DistributionPolicy2Choice.Code))]
    [KnownType(typeof(DistributionPolicy2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DistributionPolicy2Choice.Code),nameof(DistributionPolicy2Choice.Code))]
    [JsonDerivedType(typeof(DistributionPolicy2Choice.Proprietary),nameof(DistributionPolicy2Choice.Proprietary))]
    #endif
    [IsoId("_HolxYeLaEeWFtOV72FbX9w")]
    [DisplayName("Distribution Policy 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionPolicy2Choice_
    #else
    public abstract partial class DistributionPolicy2Choice_
    #endif
    {
    }
}
