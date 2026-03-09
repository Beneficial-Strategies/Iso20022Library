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
    [KnownType(typeof(MemberReportOrError4Choice.Member))]
    [KnownType(typeof(MemberReportOrError4Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberReportOrError4Choice.Member),nameof(MemberReportOrError4Choice.Member))]
    [JsonDerivedType(typeof(MemberReportOrError4Choice.BusinessError),nameof(MemberReportOrError4Choice.BusinessError))]
    #endif
    [IsoId("_i8mp9ZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Report Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberReportOrError4Choice_
    #else
    public abstract partial class MemberReportOrError4Choice_
    #endif
    {
    }
}
