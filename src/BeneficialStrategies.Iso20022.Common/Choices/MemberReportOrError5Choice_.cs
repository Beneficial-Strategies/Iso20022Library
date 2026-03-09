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
    /// It is used to provide information on transactions and booked entries held at the transaction administrator.
    /// </summary>
    [KnownType(typeof(MemberReportOrError5Choice.Report))]
    [KnownType(typeof(MemberReportOrError5Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberReportOrError5Choice.Report),nameof(MemberReportOrError5Choice.Report))]
    [JsonDerivedType(typeof(MemberReportOrError5Choice.OperationalError),nameof(MemberReportOrError5Choice.OperationalError))]
    #endif
    [IsoId("_jUbLIXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Report Or Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberReportOrError5Choice_
    #else
    public abstract partial class MemberReportOrError5Choice_
    #endif
    {
    }
}
