// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7y9MNp-Ed-ak6NoX_4Aeg_1668840941")]
[Description(@"Identifies the type of certificate.")]
[Derivations(typeof(CertificateType1Code), typeof(CertificateType2Code))]
public enum CertificateTypeCode
{
    /// <summary>
    /// Certification of due formation and organisation.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_a7y9Mdp-Ed-ak6NoX_4Aeg_309481135")]
    [Description(@"Certification of due formation and organisation.")]
    DueFormationAndOrganisation,

    /// <summary>
    /// Certificate of good standing.
    /// Encoded/decoded by serializers as &quot;GOST&quot;.
    /// </summary>
    [EnumMember(Value = "GOST")]
    [IsoId("_a7y9Mtp-Ed-ak6NoX_4Aeg_319638733")]
    [Description(@"Certificate of good standing.")]
    GoodStanding,

    /// <summary>
    /// Letter of reference.
    /// Encoded/decoded by serializers as &quot;LREF&quot;.
    /// </summary>
    [EnumMember(Value = "LREF")]
    [IsoId("_a7y9M9p-Ed-ak6NoX_4Aeg_320563756")]
    [Description(@"Letter of reference.")]
    LetterOfReference,

    /// <summary>
    /// Anti-money laundering certification form.
    /// Encoded/decoded by serializers as &quot;AMLC&quot;.
    /// </summary>
    [EnumMember(Value = "AMLC")]
    [IsoId("_a7y9NNp-Ed-ak6NoX_4Aeg_322408395")]
    [Description(@"Anti-money laundering certification form.")]
    AntiMoneyLaundering,

    /// <summary>
    /// Certification of incumbency.
    /// Encoded/decoded by serializers as &quot;INCU&quot;.
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_a7y9Ndp-Ed-ak6NoX_4Aeg_324257379")]
    [Description(@"Certification of incumbency.")]
    Incumbency,

    /// <summary>
    /// Government issued form of picture identification - passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_a7y9Ntp-Ed-ak6NoX_4Aeg_339032888")]
    [Description(@"Government issued form of picture identification - passport.")]
    Passport,

    /// <summary>
    /// Government issued form of picture identification - driving license.
    /// Encoded/decoded by serializers as &quot;DVLC&quot;.
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_a7y9N9p-Ed-ak6NoX_4Aeg_340880828")]
    [Description(@"Government issued form of picture identification - driving license.")]
    DrivingLicense,

    /// <summary>
    /// Government issued form of picture identification - identity card.
    /// Encoded/decoded by serializers as &quot;IDEN&quot;.
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_a7y9ONp-Ed-ak6NoX_4Aeg_349191927")]
    [Description(@"Government issued form of picture identification - identity card.")]
    IdentityCard,

    /// <summary>
    /// Proof of the address, such as a utility bill.
    /// Encoded/decoded by serializers as &quot;PRAD&quot;.
    /// </summary>
    [EnumMember(Value = "PRAD")]
    [IsoId("_a7y9Odp-Ed-ak6NoX_4Aeg_-1022831792")]
    [Description(@"Proof of the address, such as a utility bill.")]
    ProofOfAddress,

    /// <summary>
    /// Public key infrastructure certificate.
    /// Encoded/decoded by serializers as &quot;PKIC&quot;.
    /// </summary>
    [EnumMember(Value = "PKIC")]
    [IsoId("_rxZaQFAREeKdE_ZuDLMHLA_554416812")]
    [Description(@"Public key infrastructure certificate.")]
    PublicKeyInfrastructureCertificate,
}
