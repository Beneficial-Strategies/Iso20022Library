// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the event is mandatory, mandatory with options or voluntary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKsU0dp-Ed-ak6NoX_4Aeg_-2134886943")]
[Description(@"Specifies whether the event is mandatory, mandatory with options or voluntary.")]
[DerivedFrom(typeof(CorporateActionMandatoryVoluntaryCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionMandatoryVoluntary1Code>))]
#endif
public enum CorporateActionMandatoryVoluntary1Code
{
    /// <summary>
    /// Participation in CA event is mandatory. Further instructions from the account owner are not required.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_bKsU0tp-Ed-ak6NoX_4Aeg_-1751624150")]
    [Description(
        @"Participation in CA event is mandatory. Further instructions from the account owner are not required."
    )]
    Mandatory = CorporateActionMandatoryVoluntaryCode.Mandatory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participation in the corporate action is mandatory and further instructions from the account owner are required, unless a default option has been specified.
    /// Encoded/decoded by serializers as &quot;CHOS&quot;.
    /// </summary>
    [EnumMember(Value = "CHOS")]
    [IsoId("_bKsU09p-Ed-ak6NoX_4Aeg_-1751624149")]
    [Description(
        @"Participation in the corporate action is mandatory and further instructions from the account owner are required, unless a default option has been specified."
    )]
    MandatoryWithOptions = CorporateActionMandatoryVoluntaryCode.MandatoryWithOptions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participation in the corporate action is voluntary. If the owner wishes to take part in the event, instructions from the account owner are required.
    /// Encoded/decoded by serializers as &quot;VOLU&quot;.
    /// </summary>
    [EnumMember(Value = "VOLU")]
    [IsoId("_bKsU1Np-Ed-ak6NoX_4Aeg_-1751624119")]
    [Description(
        @"Participation in the corporate action is voluntary. If the owner wishes to take part in the event, instructions from the account owner are required."
    )]
    Voluntary = CorporateActionMandatoryVoluntaryCode.Voluntary, // same ordinal as derivation source for type conversions
}
