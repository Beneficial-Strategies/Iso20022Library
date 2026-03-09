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
    /// Choice between details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitReportOrError4Choice.BusinessReport))]
    [KnownType(typeof(LimitReportOrError4Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitReportOrError4Choice.BusinessReport),nameof(LimitReportOrError4Choice.BusinessReport))]
    [JsonDerivedType(typeof(LimitReportOrError4Choice.OperationalError),nameof(LimitReportOrError4Choice.OperationalError))]
    #endif
    [IsoId("_CtV4dW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Report Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitReportOrError4Choice_
    #else
    public abstract partial class LimitReportOrError4Choice_
    #endif
    {
    }
}
