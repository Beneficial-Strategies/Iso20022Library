// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of signature form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPUNRtp-Ed-ak6NoX_4Aeg_1133516215")]
[Description(@"Type of signature form.")]
[Derivations(typeof(SignatureType1Code))]
public enum SignatureTypeCode
{
    /// <summary>
    /// The investor&apos;s written signature is required. Can also be known as physical or wet signature.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_ZPUNR9p-Ed-ak6NoX_4Aeg_1551868331")]
    [Description(@"The investor's written signature is required. Can also be known as physical or wet signature.")]
    Original,
    
    /// <summary>
    /// A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// Encoded/decoded by serializers as &quot;DIGI&quot;.
    /// </summary>
    [EnumMember(Value = "DIGI")]
    [IsoId("_ZPUNSNp-Ed-ak6NoX_4Aeg_1551868361")]
    [Description(@"A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    Digital,
    
    /// <summary>
    /// A copy of a physical or original signature in an electronic format.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZPdXMNp-Ed-ak6NoX_4Aeg_1551868392")]
    [Description(@"A copy of a physical or original signature in an electronic format.")]
    Electronic,
    
    /// <summary>
    /// There is no signature required in any form.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ZPdXMdp-Ed-ak6NoX_4Aeg_1551868393")]
    [Description(@"There is no signature required in any form.")]
    None,
    
}
