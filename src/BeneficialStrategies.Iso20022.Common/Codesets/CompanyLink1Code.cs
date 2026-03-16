// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of links to a company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r7rB4CCbEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of links to a company.")]
[DerivedFrom(typeof(CompanyLinkCode))]
public enum CompanyLink1Code
{
    /// <summary>
    /// Autonomous agent accredited by the broker.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_4wnUASCbEeWJd9HF2tO7BA")]
    [Description(@"Autonomous agent accredited by the broker.")]
    Agent = CompanyLinkCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Employee, operator or agent of the broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_43di4SCbEeWJd9HF2tO7BA")]
    [Description(@"Employee, operator or agent of the broker.")]
    Broker = CompanyLinkCode.Broker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_4-KAwSCbEeWJd9HF2tO7BA")]
    [Description(
        @"Brokerage partner or shareholder, individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position."
    )]
    BrokeragePartner = CompanyLinkCode.BrokeragePartner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate).
    /// Encoded/decoded by serializers as &quot;MEMB&quot;.
    /// </summary>
    [EnumMember(Value = "MEMB")]
    [IsoId("_5E2eoSCbEeWJd9HF2tO7BA")]
    [Description(
        @"Member broker of a financial conglomerate (person is a board member, director, officer and employee of a member company of the conglomerate)."
    )]
    MemberBroker = CompanyLinkCode.MemberBroker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Parent company of the broker.
    /// Encoded/decoded by serializers as &quot;PCOM&quot;.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_5NL7QSCbEeWJd9HF2tO7BA")]
    [Description(@"Parent company of the broker.")]
    ParentCompany = CompanyLinkCode.ParentCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position.
    /// Encoded/decoded by serializers as &quot;RELA&quot;.
    /// </summary>
    [EnumMember(Value = "RELA")]
    [IsoId("_5U668SCbEeWJd9HF2tO7BA")]
    [Description(
        @"Spouse or partner and child of an employee, operator or agent of the broker; agent of the broker; brokerage partners or shareholders; individual or entity who holds a direct or an indirect control function and the holder of a management or an administration position."
    )]
    Relative = CompanyLinkCode.Relative, // same ordinal as derivation source for type conversions
}
