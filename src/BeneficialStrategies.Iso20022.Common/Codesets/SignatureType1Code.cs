// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of signature form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPUNQdp-Ed-ak6NoX_4Aeg_1678391514")]
[Description(@"Type of signature form.")]
[DerivedFrom(typeof(SignatureTypeCode))]
public enum SignatureType1Code
{
    /// <summary>
    /// The investor&apos;s written signature is required. Can also be known as physical or wet signature.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_ZPUNQtp-Ed-ak6NoX_4Aeg_1976689877")]
    [Description(
        @"The investor's written signature is required. Can also be known as physical or wet signature."
    )]
    Original = SignatureTypeCode.Original, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_ZPUNQ9p-Ed-ak6NoX_4Aeg_1976689878")]
    [Description(
        @"A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message."
    )]
    Digital = SignatureTypeCode.Digital, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZPUNRNp-Ed-ak6NoX_4Aeg_1976689908")]
    [Description(@"A copy of a physical or original signature in an electronic format.")]
    Electronic = SignatureTypeCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is no signature required in any form.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ZPUNRdp-Ed-ak6NoX_4Aeg_1976689909")]
    [Description(@"There is no signature required in any form.")]
    None = SignatureTypeCode.None, // same ordinal as derivation source for type conversions
}
