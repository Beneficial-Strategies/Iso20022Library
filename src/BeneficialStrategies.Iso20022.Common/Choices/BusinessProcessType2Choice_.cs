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
    /// Choice between a code or a data source scheme to determine the business process type.
    /// </summary>
    [KnownType(typeof(BusinessProcessType2Choice.Code))]
    [KnownType(typeof(BusinessProcessType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BusinessProcessType2Choice.Code),nameof(BusinessProcessType2Choice.Code))]
    [JsonDerivedType(typeof(BusinessProcessType2Choice.Proprietary),nameof(BusinessProcessType2Choice.Proprietary))]
    #endif
    [IsoId("_0hNQAZBgEeakHoV5BVecAQ")]
    [DisplayName("Business Process Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessProcessType2Choice_
    #else
    public abstract partial class BusinessProcessType2Choice_
    #endif
    {
    }
}
