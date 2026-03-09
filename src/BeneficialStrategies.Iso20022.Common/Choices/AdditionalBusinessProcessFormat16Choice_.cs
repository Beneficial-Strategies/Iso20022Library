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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat16Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat16Choice.Code),nameof(AdditionalBusinessProcessFormat16Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat16Choice.Proprietary),nameof(AdditionalBusinessProcessFormat16Choice.Proprietary))]
    #endif
    [IsoId("_MkrIodD7Eeetfps_dpxRmg")]
    [DisplayName("Additional Business Process Format 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat16Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat16Choice_
    #endif
    {
    }
}
