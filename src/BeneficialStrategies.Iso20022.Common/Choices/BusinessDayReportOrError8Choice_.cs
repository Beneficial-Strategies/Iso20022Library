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
    [KnownType(typeof(BusinessDayReportOrError8Choice.BusinessDayInformation))]
    [KnownType(typeof(BusinessDayReportOrError8Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BusinessDayReportOrError8Choice.BusinessDayInformation),nameof(BusinessDayReportOrError8Choice.BusinessDayInformation))]
    [JsonDerivedType(typeof(BusinessDayReportOrError8Choice.BusinessError),nameof(BusinessDayReportOrError8Choice.BusinessError))]
    #endif
    [IsoId("_wy9-B5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Day Report Or Error 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BusinessDayReportOrError8Choice_
    #else
    public abstract partial class BusinessDayReportOrError8Choice_
    #endif
    {
    }
}
