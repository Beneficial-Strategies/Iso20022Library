// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeFG7iEeKo25nLKvGr8w_-1970285811")]
[Description(
    @"Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.|"
)]
[DerivedFrom(typeof(ExternalModelFormIdentificationCode))]
public enum ExternalModelFormIdentification1Code
{
    /// <summary>
    /// ISP98 model form for standby incorporating annexed form of payment demand with statement.
    /// Encoded/decoded by serializers as &quot;ISP1&quot;.
    /// </summary>
    [EnumMember(Value = "ISP1")]
    [IsoId("_uPScNfRYEeuLhpyIdtJzwg")]
    [Description(
        @"ISP98 model form for standby incorporating annexed form of payment demand with statement."
    )]
    ISP98ModelForm1 = ExternalModelFormIdentificationCode.ISP98ModelForm1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form or standby providing for extension and incorporating annexed form of payment demand with alternative non-extension statement.
    /// Encoded/decoded by serializers as &quot;ISP2&quot;.
    /// </summary>
    [EnumMember(Value = "ISP2")]
    [IsoId("_uPScOPRYEeuLhpyIdtJzwg")]
    [Description(
        @"ISP98 model form or standby providing for extension and incorporating annexed form of payment demand with alternative non-extension statement."
    )]
    ISP98ModelForm2 = ExternalModelFormIdentificationCode.ISP98ModelForm2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form or standby providing for reduction and incorporating annexed form of reduction demand.
    /// Encoded/decoded by serializers as &quot;ISP3&quot;.
    /// </summary>
    [EnumMember(Value = "ISP3")]
    [IsoId("_uPbmIvRYEeuLhpyIdtJzwg")]
    [Description(
        @"ISP98 model form or standby providing for reduction and incorporating annexed form of reduction demand. "
    )]
    ISP98ModelForm3 = ExternalModelFormIdentificationCode.ISP98ModelForm3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form for standby providing for transfer and incorporating annexed form of transfer demand.
    /// Encoded/decoded by serializers as &quot;ISP4&quot;.
    /// </summary>
    [EnumMember(Value = "ISP4")]
    [IsoId("_uPbmJfRYEeuLhpyIdtJzwg")]
    [Description(
        @"ISP98 model form for standby providing for transfer and incorporating annexed form of transfer demand."
    )]
    ISP98ModelForm4 = ExternalModelFormIdentificationCode.ISP98ModelForm4, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form for simplified demand only standby.
    /// Encoded/decoded by serializers as &quot;ISP5&quot;.
    /// </summary>
    [EnumMember(Value = "ISP5")]
    [IsoId("_uPbmKPRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for simplified demand only standby.")]
    ISP98ModelForm5 = ExternalModelFormIdentificationCode.ISP98ModelForm5, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form for counter standby with annexed form of local bank undertaking.
    /// Encoded/decoded by serializers as &quot;ISP6&quot;.
    /// </summary>
    [EnumMember(Value = "ISP6")]
    [IsoId("_uPbmK_RYEeuLhpyIdtJzwg")]
    [Description(
        @"ISP98 model form for counter standby with annexed form of local bank undertaking."
    )]
    ISP98ModelForm6 = ExternalModelFormIdentificationCode.ISP98ModelForm6, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form for standby requiring confirmation.
    /// Encoded/decoded by serializers as &quot;ISP7&quot;.
    /// </summary>
    [EnumMember(Value = "ISP7")]
    [IsoId("_uPlXIvRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for standby requiring confirmation.")]
    ISP98ModelForm7 = ExternalModelFormIdentificationCode.ISP98ModelForm7, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISP98 model form for confirmation of standby.
    /// Encoded/decoded by serializers as &quot;ISP8&quot;.
    /// </summary>
    [EnumMember(Value = "ISP8")]
    [IsoId("_uPlXJfRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for confirmation of standby.")]
    ISP98ModelForm8 = ExternalModelFormIdentificationCode.ISP98ModelForm8, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Model form for demand guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).
    /// Encoded/decoded by serializers as &quot;UDG1&quot;.
    /// </summary>
    [EnumMember(Value = "UDG1")]
    [IsoId("_uPlXKPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Model form for demand guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG)."
    )]
    URDGDemandGuarantee = ExternalModelFormIdentificationCode.URDGDemandGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Model form for counter-guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).
    /// Encoded/decoded by serializers as &quot;UDG2&quot;.
    /// </summary>
    [EnumMember(Value = "UDG2")]
    [IsoId("_uPvIIvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Model form for counter-guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG)."
    )]
    URDGCounterGuarantee = ExternalModelFormIdentificationCode.URDGCounterGuarantee, // same ordinal as derivation source for type conversions
}
