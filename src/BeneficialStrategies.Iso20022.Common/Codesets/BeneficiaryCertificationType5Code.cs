// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certification required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zJAQsQE6EeG43uL-ROUO3A")]
[Description(@"Specifies the type of certification required.")]
[DerivedFrom(typeof(BeneficiaryCertificationTypeCode))]
public enum BeneficiaryCertificationType5Code
{
    /// <summary>
    /// The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D.
    /// Encoded/decoded by serializers as &quot;ACCI&quot;.
    /// </summary>
    [EnumMember(Value = "ACCI")]
    [IsoId("_zJKBtQE6EeG43uL-ROUO3A")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is an Accredited Investor as defined in US Securities and Exchange Commission Regulation D."
    )]
    AccreditedInvestor = BeneficiaryCertificationTypeCode.AccreditedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to certify he is an Non-Company related person.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_zJKBuQE6EeG43uL-ROUO3A")]
    [Description(@"The holder of the security has to certify he is an Non-Company related person.")]
    NonCompany = BeneficiaryCertificationTypeCode.NonCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A.
    /// Encoded/decoded by serializers as &quot;QIBB&quot;.
    /// </summary>
    [EnumMember(Value = "QIBB")]
    [IsoId("_zJKBvQE6EeG43uL-ROUO3A")]
    [Description(
        @"The holder of the security has to irrevocably certify that it is a Qualified Institutional Buyer as defined in US Securities and Exchange Commission Rule 144A."
    )]
    QIBCertification = BeneficiaryCertificationTypeCode.QIBCertification, // same ordinal as derivation source for type conversions
}
