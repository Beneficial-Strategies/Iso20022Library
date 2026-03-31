// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of links to a company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FFnMsCCaEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of links to a company.")]
[Derivations(typeof(CompanyLink1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CompanyLinkCode>))]
#endif
public enum CompanyLinkCode
{
    /// <summary>
    /// Employee, operator or agent of the broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_OnADYCCaEeWJd9HF2tO7BA")]
    [Description(@"Employee, operator or agent of the broker.")]
    Broker,

    /// <summary>
    /// Autonomous agent accredited by the broker.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_R5XzECCaEeWJd9HF2tO7BA")]
    [Description(@"Autonomous agent accredited by the broker.")]
    Agent,

    /// <summary>
    /// Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_UNsmICCaEeWJd9HF2tO7BA")]
    [Description(
        @"Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position."
    )]
    BrokeragePartner,

    /// <summary>
    /// Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as &quot;RELA&quot;.
    /// </summary>
    [EnumMember(Value = "RELA")]
    [IsoId("_Ykp_UCCaEeWJd9HF2tO7BA")]
    [Description(
        @"Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position."
    )]
    Relative,

    /// <summary>
    /// Parent company of the broker.
    /// Encoded/decoded by serializers as &quot;PCOM&quot;.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_bt9SkCCaEeWJd9HF2tO7BA")]
    [Description(@"Parent company of the broker.")]
    ParentCompany,

    /// <summary>
    /// Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate).
    /// Encoded/decoded by serializers as &quot;MEMB&quot;.
    /// </summary>
    [EnumMember(Value = "MEMB")]
    [IsoId("_gmiyICCaEeWJd9HF2tO7BA")]
    [Description(
        @"Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate)."
    )]
    MemberBroker,
}
