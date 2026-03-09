// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Common Reporting Standard (CRS) form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pvUNgENuEeaS-NnwLNvMPg")]
[Description(@"Specifies the type of Common Reporting Standard (CRS) form.")]
[Derivations(typeof(CRSFormType1Code))]
public enum CRSFormTypeCode
{
    /// <summary>
    /// Self certification as a separate document.
    /// Encoded/decoded by serializers as &quot;CER1&quot;.
    /// </summary>
    [EnumMember(Value = "CER1")]
    [IsoId("_vycYIENvEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a separate document.")]
    SelfCertificationSeparateDocument,
    
    /// <summary>
    /// Self certification as a document included into contract of the account opening.
    /// Encoded/decoded by serializers as &quot;CER2&quot;.
    /// </summary>
    [EnumMember(Value = "CER2")]
    [IsoId("_z6-TwENvEeaS-NnwLNvMPg")]
    [Description(@"Self certification as a document included into contract of the account opening.")]
    SelfCertificationWithAccountOpeningContract,
    
    /// <summary>
    /// Certificate of residence.
    /// Encoded/decoded by serializers as &quot;CER3&quot;.
    /// </summary>
    [EnumMember(Value = "CER3")]
    [IsoId("_10rAUENvEeaS-NnwLNvMPg")]
    [Description(@"Certificate of residence.")]
    CertificateOfResidence,
    
    /// <summary>
    /// Certificate of Identification issued by a government.
    /// Encoded/decoded by serializers as &quot;CER4&quot;.
    /// </summary>
    [EnumMember(Value = "CER4")]
    [IsoId("_6LeogENvEeaS-NnwLNvMPg")]
    [Description(@"Certificate of Identification issued by a government.")]
    CertificateIdentificationGovernment,
    
    /// <summary>
    /// Official documentation issued by a government for the entity.
    /// Encoded/decoded by serializers as &quot;CER5&quot;.
    /// </summary>
    [EnumMember(Value = "CER5")]
    [IsoId("_8ZtaoENvEeaS-NnwLNvMPg")]
    [Description(@"Official documentation issued by a government for the entity.")]
    OfficialDocumentGovernmentForEntity,
    
    /// <summary>
    /// Financial statement, third party credit report, bankruptcy filing or a securities regulator report.
    /// Encoded/decoded by serializers as &quot;CER6&quot;.
    /// </summary>
    [EnumMember(Value = "CER6")]
    [IsoId("_-616oENvEeaS-NnwLNvMPg")]
    [Description(@"Financial statement, third party credit report, bankruptcy filing or a securities regulator report.")]
    OtherDocumentOrReport,
    
    /// <summary>
    /// Standardised industry coding system for the entity.
    /// Encoded/decoded by serializers as &quot;CER7&quot;.
    /// </summary>
    [EnumMember(Value = "CER7")]
    [IsoId("_CmzPAENwEeaS-NnwLNvMPg")]
    [Description(@"Standardised industry coding system for the entity.")]
    Standardised,
    
    /// <summary>
    /// Publicly available information for the entity.
    /// Encoded/decoded by serializers as &quot;CER8&quot;.
    /// </summary>
    [EnumMember(Value = "CER8")]
    [IsoId("_H3fFgENwEeaS-NnwLNvMPg")]
    [Description(@"Publicly available information for the entity.")]
    PublicInformationEntity,
    
}
