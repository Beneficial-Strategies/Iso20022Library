// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the list of key types that may be exchanged
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uPcTB_8bEeic54G0fOJNMg")]
[Description(@"Contains the list of key types that may be exchanged")]
[Derivations(typeof(KeyType1Code))]
public enum KeyTypeCode
{
    /// <summary>
    /// PIN translation key applicable to the issuer
    /// Encoded/decoded by serializers as &quot;PTKI&quot;.
    /// </summary>
    [EnumMember(Value = "PTKI")]
    [IsoId("_uPcTDf8bEeic54G0fOJNMg")]
    [Description(@"PIN translation key applicable to the issuer")]
    PINTranslationKeyIssuer,

    /// <summary>
    /// PIN translation key applicable to the acquirer
    /// Encoded/decoded by serializers as &quot;PTKA&quot;.
    /// </summary>
    [EnumMember(Value = "PTKA")]
    [IsoId("_uPcTCv8bEeic54G0fOJNMg")]
    [Description(@"PIN translation key applicable to the acquirer")]
    PINTranslationKeyAcquirer,

    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_uPcTCf8bEeic54G0fOJNMg")]
    [Description(@"Other national")]
    OtherNational,

    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_uPcTDP8bEeic54G0fOJNMg")]
    [Description(@"Other private")]
    OtherPrivate,
}
