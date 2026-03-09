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
    [KnownType(typeof(DistributionTypeFormat7Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DistributionTypeFormat7Choice.Code),nameof(DistributionTypeFormat7Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat7Choice.Proprietary),nameof(DistributionTypeFormat7Choice.Proprietary))]
    #endif
    [IsoId("_4kYtQUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Distribution Type Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DistributionTypeFormat7Choice_
    #else
    public abstract partial class DistributionTypeFormat7Choice_
    #endif
    {
    }
}
