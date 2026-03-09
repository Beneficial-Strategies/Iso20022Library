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
    [KnownType(typeof(MemberReportOrError7Choice.Report))]
    [KnownType(typeof(MemberReportOrError7Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberReportOrError7Choice.Report),nameof(MemberReportOrError7Choice.Report))]
    [JsonDerivedType(typeof(MemberReportOrError7Choice.OperationalError),nameof(MemberReportOrError7Choice.OperationalError))]
    #endif
    [IsoId("_fMY0YdcZEeqRFcf2R4bPBw")]
    [DisplayName("Member Report Or Error 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberReportOrError7Choice_
    #else
    public abstract partial class MemberReportOrError7Choice_
    #endif
    {
    }
}
