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
    /// Choice between a code or a data source scheme to determine a date format.
    /// </summary>
    [KnownType(typeof(Date3Choice.Code))]
    [KnownType(typeof(Date3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Date3Choice.Code),nameof(Date3Choice.Code))]
    [JsonDerivedType(typeof(Date3Choice.Proprietary),nameof(Date3Choice.Proprietary))]
    #endif
    [IsoId("_UmGspZEhEeakHoV5BVecAQ")]
    [DisplayName("Date 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Date3Choice_
    #else
    public abstract partial class Date3Choice_
    #endif
    {
    }
}
