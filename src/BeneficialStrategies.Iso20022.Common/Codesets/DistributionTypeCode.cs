// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aw6i49p-Ed-ak6NoX_4Aeg_1235409327")]
[Description(@"Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.")]
[Derivations(typeof(DistributionType1Code),typeof(DistributionType2Code),typeof(DistributionType3Code))]
public enum DistributionTypeCode
{
    /// <summary>
    /// Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_aw6i5Np-Ed-ak6NoX_4Aeg_1493072319")]
    [Description(@"Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.")]
    RollingBasis,
    
    /// <summary>
    /// Final payment.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_vSOBd_mcEeCZMIez125r5g")]
    [Description(@"Final payment.")]
    Final,
    
    /// <summary>
    /// Interim payment.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_2YbPJ_mcEeCZMIez125r5g")]
    [Description(@"Interim payment.")]
    Interim,
    
    /// <summary>
    /// Event is ongoing for acceptance on an unsolicited basis.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_4ukCsCXVEeOxs5BTXTK7og")]
    [Description(@"Event is ongoing for acceptance on an unsolicited basis.")]
    Ongoing,
    
}
