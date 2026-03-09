// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Common Reporting Standard (CRS) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TYFa4ENwEeaS-NnwLNvMPg")]
[Description(@"Specifies the type of Common Reporting Standard (CRS) form.")]
[DerivedFrom(typeof(CRSFormTypeCode))]
public enum CRSFormType1Code
{
    /// <summary>
    /// Certificate of Identification issued by a government.
    /// Encoded/decoded by serializers as &quot;CER4&quot;.
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_VuWHoUNwEeaS-NnwLNvMPg")]
    [Description(@"Certificate of Identification issued by a government.")]
    CertificateIdentificationGovernment = CRSFormTypeCode.CertificateIdentificationGovernment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of residence.
    /// Encoded/decoded by serializers as &quot;CER3&quot;.
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_V4BBAUNwEeaS-NnwLNvMPg")]
    [Description(@"Certificate of residence.")]
    CertificateOfResidence = CRSFormTypeCode.CertificateOfResidence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Official documentation issued by a government for the entity.
    /// Encoded/decoded by serializers as &quot;CER5&quot;.
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_WBshcUNwEeaS-NnwLNvMPg")]
    [Description(@"Official documentation issued by a government for the entity.")]
    OfficialDocumentGovernmentForEntity = CRSFormTypeCode.OfficialDocumentGovernmentForEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial statement, third party credit report, bankruptcy filing or a securities regulator report.
    /// Encoded/decoded by serializers as &quot;CER6&quot;.
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_WE0G4UNwEeaS-NnwLNvMPg")]
    [Description(@"Financial statement, third party credit report, bankruptcy filing or a securities regulator report.")]
    OtherDocumentOrReport = CRSFormTypeCode.OtherDocumentOrReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Publicly available information for the entity.
    /// Encoded/decoded by serializers as &quot;CER8&quot;.
    /// </summary>
    [EnumMember(Value = "CER8")]
    [IsoId("_WUloQUNwEeaS-NnwLNvMPg")]
    [Description(@"Publicly available information for the entity.")]
    PublicInformationEntity = CRSFormTypeCode.PublicInformationEntity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self certification as a separate document.
    /// Encoded/decoded by serializers as &quot;CER1&quot;.
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_WeQhoUNwEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a separate document.")]
    SelfCertificationSeparateDocument = CRSFormTypeCode.SelfCertificationSeparateDocument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self certification as a document included into contract of the account opening.
    /// Encoded/decoded by serializers as &quot;CER2&quot;.
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_WnxqAUNwEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a document included into contract of the account opening.")]
    SelfCertificationWithAccountOpeningContract = CRSFormTypeCode.SelfCertificationWithAccountOpeningContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standardised industry coding system for the entity.
    /// Encoded/decoded by serializers as &quot;CER7&quot;.
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_WxTZcUNwEeaS-NnwLNvMPg")]
    [Description(@"Standardised industry coding system for the entity.")]
    Standardised = CRSFormTypeCode.Standardised, // same ordinal as derivation source for type conversions
    
}
