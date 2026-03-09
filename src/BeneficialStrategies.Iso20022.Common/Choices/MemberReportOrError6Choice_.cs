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
    /// Reports either on a member or a business error.
    /// </summary>
    [KnownType(typeof(MemberReportOrError6Choice.Member))]
    [KnownType(typeof(MemberReportOrError6Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberReportOrError6Choice.Member),nameof(MemberReportOrError6Choice.Member))]
    [JsonDerivedType(typeof(MemberReportOrError6Choice.BusinessError),nameof(MemberReportOrError6Choice.BusinessError))]
    #endif
    [IsoId("_j3hRJXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Report Or Error 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberReportOrError6Choice_
    #else
    public abstract partial class MemberReportOrError6Choice_
    #endif
    {
    }
}
