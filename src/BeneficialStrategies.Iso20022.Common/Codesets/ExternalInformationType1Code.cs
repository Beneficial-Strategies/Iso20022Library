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
[IsoId("_TRd1lwEcEeCQm6a_G2yO_w_1586827309")]
[Description(@"Specifies the information type, as published in an external information type code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalInformationTypeCode))]
public enum ExternalInformationType1Code
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_uIbmQvRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request processing.")]
    ProcessingInstructions = ExternalInformationTypeCode.ProcessingInstructions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional information not otherwise specified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIbmRfRYEeuLhpyIdtJzwg")]
    [Description(@"Additional information not otherwise specified.")]
    OtherInformation = ExternalInformationTypeCode.OtherInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// Encoded/decoded by serializers as &quot;RELY&quot;.
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_uIbmSPRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RelayInstructions = ExternalInformationTypeCode.RelayInstructions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional shipping information not otherwise specified.
    /// Encoded/decoded by serializers as &quot;SHPG&quot;.
    /// </summary>
    [EnumMember(Value = "SHPG")]
    [IsoId("_uIlXQvRYEeuLhpyIdtJzwg")]
    [Description(@"Additional shipping information not otherwise specified.")]
    ShippingInformation = ExternalInformationTypeCode.ShippingInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification.
    /// Encoded/decoded by serializers as &quot;SHPM&quot;.
    /// </summary>
    [EnumMember(Value = "SHPM")]
    [IsoId("_uIlXRfRYEeuLhpyIdtJzwg")]
    [Description(@"Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification.")]
    ShippingMarks = ExternalInformationTypeCode.ShippingMarks, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information concerning the domicile location of the seller.
    /// Encoded/decoded by serializers as &quot;SLDC&quot;.
    /// </summary>
    [EnumMember(Value = "SLDC")]
    [IsoId("_uIlXSPRYEeuLhpyIdtJzwg")]
    [Description(@"Information concerning the domicile location of the seller.")]
    SellerDomicileLocation = ExternalInformationTypeCode.SellerDomicileLocation, // same ordinal as derivation source for type conversions
    
}
