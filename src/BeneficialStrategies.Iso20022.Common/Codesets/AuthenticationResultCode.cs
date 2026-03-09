// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the result of authentication done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zg1qsLABEeah1_v59tW6Rg")]
[Description(@"Specifies the result of authentication done.")]
[Derivations(typeof(AuthenticationResult1Code))]
public enum AuthenticationResultCode
{
    /// <summary>
    /// The authentication didn’t succeed.
    /// Encoded/decoded by serializers as &quot;DENY&quot;.
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_pHOwwLABEeah1_v59tW6Rg")]
    [Description(@"The authentication didn’t succeed.")]
    Denial,
    
    /// <summary>
    /// The card does not participate in the authentication programme.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_vTZYELABEeah1_v59tW6Rg")]
    [Description(@"The card does not participate in the authentication programme.")]
    NonParticipation,
    
    /// <summary>
    /// The authentication couldn’t be carried out.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_zS4FYLABEeah1_v59tW6Rg")]
    [Description(@"The authentication couldn’t be carried out.")]
    UnableToAuthenticate,
    
    /// <summary>
    /// Merchant not enrolled in the authentication programme.
    /// Encoded/decoded by serializers as &quot;MRCH&quot;.
    /// </summary>
    [EnumMember(Value = "MRCH")]
    [IsoId("_41PhwLABEeah1_v59tW6Rg")]
    [Description(@"Merchant not enrolled in the authentication programme.")]
    MerchantNotEnroled,
    
    /// <summary>
    /// Authentication succeeded with a cryptogram.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_8GEZULABEeah1_v59tW6Rg")]
    [Description(@"Authentication succeeded with a cryptogram.")]
    WithCryptogram,
    
    /// <summary>
    /// Authentication succeeded without a cryptogram.
    /// Encoded/decoded by serializers as &quot;UCRP&quot;.
    /// </summary>
    [EnumMember(Value = "UCRP")]
    [IsoId("__VGhILABEeah1_v59tW6Rg")]
    [Description(@"Authentication succeeded without a cryptogram.")]
    WithoutCryptogram,
    
}
