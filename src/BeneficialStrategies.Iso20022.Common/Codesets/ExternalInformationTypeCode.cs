// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the information type, as published in an external information type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EroPkPeZEee0h5ZXun0VTA")]
[Description(
    @"Specifies the information type, as published in an external information type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInformationType1Code))]
public enum ExternalInformationTypeCode
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_uIbmQPRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request processing.")]
    ProcessingInstructions,

    /// <summary>
    /// Additional information not otherwise specified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIbmQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Additional information not otherwise specified.")]
    OtherInformation,

    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// Encoded/decoded by serializers as &quot;RELY&quot;.
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_uIbmRvRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RelayInstructions,

    /// <summary>
    /// Additional shipping information not otherwise specified.
    /// Encoded/decoded by serializers as &quot;SHPG&quot;.
    /// </summary>
    [EnumMember(Value = "SHPG")]
    [IsoId("_uIlXQPRYEeuLhpyIdtJzwg")]
    [Description(@"Additional shipping information not otherwise specified.")]
    ShippingInformation,

    /// <summary>
    /// Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification.
    /// Encoded/decoded by serializers as &quot;SHPM&quot;.
    /// </summary>
    [EnumMember(Value = "SHPM")]
    [IsoId("_uIlXQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification."
    )]
    ShippingMarks,

    /// <summary>
    /// Information concerning the domicile location of the seller.
    /// Encoded/decoded by serializers as &quot;SLDC&quot;.
    /// </summary>
    [EnumMember(Value = "SLDC")]
    [IsoId("_uIlXRvRYEeuLhpyIdtJzwg")]
    [Description(@"Information concerning the domicile location of the seller.")]
    SellerDomicileLocation,
}
