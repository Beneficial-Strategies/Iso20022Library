// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7pMMNp-Ed-ak6NoX_4Aeg_-767017324")]
[Description(@"Identifies the type of certificate.")]
[DerivedFrom(typeof(CertificateTypeCode))]
public enum CertificateType1Code
{
    /// <summary>
    /// Certification of due formation and organisation.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_a7pMMdp-Ed-ak6NoX_4Aeg_-767017088")]
    [Description(@"Certification of due formation and organisation.")]
    DueFormationAndOrganisation = CertificateTypeCode.DueFormationAndOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of good standing.
    /// Encoded/decoded by serializers as &quot;GOST&quot;.
    /// </summary>
    [EnumMember(Value = "GOST")]
    [IsoId("_a7pMMtp-Ed-ak6NoX_4Aeg_-767017064")]
    [Description(@"Certificate of good standing.")]
    GoodStanding = CertificateTypeCode.GoodStanding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Letter of reference.
    /// Encoded/decoded by serializers as &quot;LREF&quot;.
    /// </summary>
    [EnumMember(Value = "LREF")]
    [IsoId("_a7pMM9p-Ed-ak6NoX_4Aeg_-767017029")]
    [Description(@"Letter of reference.")]
    LetterOfReference = CertificateTypeCode.LetterOfReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Anti-money laundering certification form.
    /// Encoded/decoded by serializers as &quot;AMLC&quot;.
    /// </summary>
    [EnumMember(Value = "AMLC")]
    [IsoId("_a7pMNNp-Ed-ak6NoX_4Aeg_-767017012")]
    [Description(@"Anti-money laundering certification form.")]
    AntiMoneyLaundering = CertificateTypeCode.AntiMoneyLaundering, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification of incumbency.
    /// Encoded/decoded by serializers as &quot;INCU&quot;.
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_a7pMNdp-Ed-ak6NoX_4Aeg_-767016994")]
    [Description(@"Certification of incumbency.")]
    Incumbency = CertificateTypeCode.Incumbency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_a7pMNtp-Ed-ak6NoX_4Aeg_-767016969")]
    [Description(@"Government issued form of picture identification - passport.")]
    Passport = CertificateTypeCode.Passport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - driving license.
    /// Encoded/decoded by serializers as &quot;DVLC&quot;.
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_a7pMN9p-Ed-ak6NoX_4Aeg_-767016934")]
    [Description(@"Government issued form of picture identification - driving license.")]
    DrivingLicense = CertificateTypeCode.DrivingLicense, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - identity card.
    /// Encoded/decoded by serializers as &quot;IDEN&quot;.
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_a7pMONp-Ed-ak6NoX_4Aeg_-767016661")]
    [Description(@"Government issued form of picture identification - identity card.")]
    IdentityCard = CertificateTypeCode.IdentityCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proof of the address, such as a utility bill.
    /// Encoded/decoded by serializers as &quot;PRAD&quot;.
    /// </summary>
    [EnumMember(Value = "PRAD")]
    [IsoId("_a7pMOdp-Ed-ak6NoX_4Aeg_-767016644")]
    [Description(@"Proof of the address, such as a utility bill.")]
    ProofOfAddress = CertificateTypeCode.ProofOfAddress, // same ordinal as derivation source for type conversions
    
}
