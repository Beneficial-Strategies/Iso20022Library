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
    [KnownType(typeof(MemberReportOrError8Choice.Member))]
    [KnownType(typeof(MemberReportOrError8Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberReportOrError8Choice.Member),nameof(MemberReportOrError8Choice.Member))]
    [JsonDerivedType(typeof(MemberReportOrError8Choice.BusinessError),nameof(MemberReportOrError8Choice.BusinessError))]
    #endif
    [IsoId("_fQIE5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Member Report Or Error 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberReportOrError8Choice_
    #else
    public abstract partial class MemberReportOrError8Choice_
    #endif
    {
    }
}
