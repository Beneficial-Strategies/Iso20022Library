// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the deadline reference of a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bDPpCNp-Ed-ak6NoX_4Aeg_474204484")]
[Description(@"Specifies the deadline reference of a corporate action.")]
[DerivedFrom(typeof(CorporateActionReferenceDateCode))]
public enum CorporateActionDeadline1Code
{
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an election instruction, to an outstanding offer or privilege.
    /// Encoded/decoded by serializers as &quot;MKDT&quot;.
    /// </summary>
    [EnumMember(Value = "MKDT")]
    [IsoId("_bDPpCdp-Ed-ak6NoX_4Aeg_803900500")]
    [Description(@"Issuer or issuer's agent deadline to respond, with an election instruction, to an outstanding offer or privilege.")]
    MarketDeadline = CorporateActionReferenceDateCode.MarketDeadline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as &quot;RDDT&quot;.
    /// </summary>
    [EnumMember(Value = "RDDT")]
    [IsoId("_bDZaANp-Ed-ak6NoX_4Aeg_819599893")]
    [Description(@"Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    ResponseDeadline = CorporateActionReferenceDateCode.ResponseDeadline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as &quot;EARD&quot;.
    /// </summary>
    [EnumMember(Value = "EARD")]
    [IsoId("_bDZaAdp-Ed-ak6NoX_4Aeg_842687467")]
    [Description(@"Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    EarlyResponseDeadline = CorporateActionReferenceDateCode.EarlyResponseDeadline, // same ordinal as derivation source for type conversions
    
}
