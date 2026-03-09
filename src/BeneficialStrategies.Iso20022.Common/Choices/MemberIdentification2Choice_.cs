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
    [KnownType(typeof(MemberIdentification2Choice.BICFI))]
    [KnownType(typeof(MemberIdentification2Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(MemberIdentification2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MemberIdentification2Choice.BICFI),nameof(MemberIdentification2Choice.BICFI))]
    [JsonDerivedType(typeof(MemberIdentification2Choice.ClearingSystemMemberIdentification),nameof(MemberIdentification2Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(MemberIdentification2Choice.Other),nameof(MemberIdentification2Choice.Other))]
    #endif
    [IsoId("_8Hq3VqMgEeCJ6YNENx4h-w_1599829601")]
    [DisplayName("Member Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MemberIdentification2Choice_
    #else
    public abstract partial class MemberIdentification2Choice_
    #endif
    {
    }
}
