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
    /// Choice between business day information details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError10Choice.BusinessDayInformation))]
    [KnownType(typeof(BusinessDayReportOrError10Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BusinessDayReportOrError10Choice.BusinessDayInformation),nameof(BusinessDayReportOrError10Choice.BusinessDayInformation))]
    [JsonDerivedType(typeof(BusinessDayReportOrError10Choice.BusinessError),nameof(BusinessDayReportOrError10Choice.BusinessError))]
    #endif
    [IsoId("_ONBJt3XyEei3jO6riKEVXg")]
    [DisplayName("Business Day Report Or Error 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessDayReportOrError10Choice_
    #else
    public abstract partial class BusinessDayReportOrError10Choice_
    #endif
    {
    }
}
