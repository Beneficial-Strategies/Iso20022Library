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
    /// Choice between business day information details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(BusinessDayReportOrError9Choice.BusinessReport))]
    [KnownType(typeof(BusinessDayReportOrError9Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BusinessDayReportOrError9Choice.BusinessReport),nameof(BusinessDayReportOrError9Choice.BusinessReport))]
    [JsonDerivedType(typeof(BusinessDayReportOrError9Choice.OperationalError),nameof(BusinessDayReportOrError9Choice.OperationalError))]
    #endif
    [IsoId("_N58csXXyEei3jO6riKEVXg")]
    [DisplayName("Business Day Report Or Error 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessDayReportOrError9Choice_
    #else
    public abstract partial class BusinessDayReportOrError9Choice_
    #endif
    {
    }
}
