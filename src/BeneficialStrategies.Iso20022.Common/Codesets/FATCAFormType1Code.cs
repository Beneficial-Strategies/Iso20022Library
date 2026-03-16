// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kZxV0AjMEeS5F6qHcKOrew")]
[Description(@"Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.")]
[DerivedFrom(typeof(FATCAFormTypeCode))]
public enum FATCAFormType1Code
{
    /// <summary>
    /// Certificate of foreign intermediary (also known as IRS form W-8IMY).
    /// Encoded/decoded by serializers as &quot;CER5&quot;.
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_nSQl4QjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of foreign intermediary (also known as IRS form W-8IMY).")]
    CertificateForeignIntermediary = FATCAFormTypeCode.CertificateForeignIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate of foreign person&apos;s claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E).
    /// Encoded/decoded by serializers as &quot;CER7&quot;.
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_nc-BEQjMEeS5F6qHcKOrew")]
    [Description(
        @"Certificate of foreign person's claim that income is effectively connected with the conduct of a trade or business in the United States (also known as IRS form W-8BEN-E)."
    )]
    CertificateForeignPersonsClaim = FATCAFormTypeCode.CertificateForeignPersonsClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN).
    /// Encoded/decoded by serializers as &quot;CER1&quot;.
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_nfphoQjMEeS5F6qHcKOrew")]
    [Description(
        @"Certificate of foreign status of beneficial owner (also known as IRS form W-8BEN)."
    )]
    CertificateForeignStatusBeneficialOwner =
        FATCAFormTypeCode.CertificateForeignStatusBeneficialOwner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate of loss of nationality.
    /// Encoded/decoded by serializers as &quot;CER2&quot;.
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_ntVYUQjMEeS5F6qHcKOrew")]
    [Description(@"Certificate of loss of nationality.")]
    CertificateLossNationality = FATCAFormTypeCode.CertificateLossNationality, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Self certification.
    /// Encoded/decoded by serializers as &quot;CER3&quot;.
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_nwKC0QjMEeS5F6qHcKOrew")]
    [Description(@"Self certification.")]
    SelfCertification = FATCAFormTypeCode.SelfCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Self certificate of loss of nationality (also known as IRS form I-407).
    /// Encoded/decoded by serializers as &quot;CER4&quot;.
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_n4ffcQjMEeS5F6qHcKOrew")]
    [Description(@"Self certificate of loss of nationality (also known as IRS form I-407).")]
    SelfCertificationLossNationality = FATCAFormTypeCode.SelfCertificationLossNationality, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form is a request for taxpayer identification number and certification (also known as IRS form W9).
    /// Encoded/decoded by serializers as &quot;CER6&quot;.
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_oA08EQjMEeS5F6qHcKOrew")]
    [Description(
        @"Form is a request for taxpayer identification number and certification (also known as IRS form W9)."
    )]
    TaxpayerIdentificationNumberRequest = FATCAFormTypeCode.TaxpayerIdentificationNumberRequest, // same ordinal as derivation source for type conversions
}
