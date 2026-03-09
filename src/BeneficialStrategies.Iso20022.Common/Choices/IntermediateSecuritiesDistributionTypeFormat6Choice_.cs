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
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code),nameof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code))]
    [JsonDerivedType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary),nameof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary))]
    #endif
    [IsoId("_x8LwkeAZEd-D2OAFXdoRmA")]
    [DisplayName("Intermediate Securities Distribution Type Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntermediateSecuritiesDistributionTypeFormat6Choice_
    #else
    public abstract partial class IntermediateSecuritiesDistributionTypeFormat6Choice_
    #endif
    {
    }
}
