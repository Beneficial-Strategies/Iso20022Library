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
    /// Set of elements used to identify a financial institution.
    /// </summary>
    [KnownType(typeof(MemberIdentification3Choice.BICFI))]
    [KnownType(typeof(MemberIdentification3Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(MemberIdentification3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberIdentification3Choice.BICFI),nameof(MemberIdentification3Choice.BICFI))]
    [JsonDerivedType(typeof(MemberIdentification3Choice.ClearingSystemMemberIdentification),nameof(MemberIdentification3Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(MemberIdentification3Choice.Other),nameof(MemberIdentification3Choice.Other))]
    #endif
    [IsoId("_h_8rhXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberIdentification3Choice_
    #else
    public abstract partial class MemberIdentification3Choice_
    #endif
    {
    }
}
