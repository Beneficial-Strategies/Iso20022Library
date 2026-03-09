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
    [KnownType(typeof(BusinessDayReportOrError7Choice.BusinessReport))]
    [KnownType(typeof(BusinessDayReportOrError7Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BusinessDayReportOrError7Choice.BusinessReport),nameof(BusinessDayReportOrError7Choice.BusinessReport))]
    [JsonDerivedType(typeof(BusinessDayReportOrError7Choice.OperationalError),nameof(BusinessDayReportOrError7Choice.OperationalError))]
    #endif
    [IsoId("_wiKh4ZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Report Or Error 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessDayReportOrError7Choice_
    #else
    public abstract partial class BusinessDayReportOrError7Choice_
    #endif
    {
    }
}
