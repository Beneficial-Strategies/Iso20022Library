// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Formal document used to record a fact and used as proof of the fact, in the context of a commercial trade transaction.
/// </summary>
[IsoId("_Tncl2dp-Ed-ak6NoX_4Aeg_-105876723")]
[DisplayName("Other Certificate Data Set")]
public partial record OtherCertificateDataSet1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the certificate data set.
    /// </summary>
    [IsoId("_TnmW0Np-Ed-ak6NoX_4Aeg_629308440")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_TnmW0dp-Ed-ak6NoX_4Aeg_1312675433")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CertificateIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_TnmW0tp-Ed-ak6NoX_4Aeg_212738392")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required TradeCertificateType2Code CertificateType { get; init; } 
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_TnmW09p-Ed-ak6NoX_4Aeg_224743278")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; } 
    
    /// <summary>
    /// Issuer of the certificate, typically the inspection company or its agent.
    /// </summary>
    [IsoId("_TnmW1Np-Ed-ak6NoX_4Aeg_722520574")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification26 Issuer { get; init; } 
    
    /// <summary>
    /// Additional and important information that could not be captured by structured fields.
    /// </summary>
    [IsoId("_TnmW1dp-Ed-ak6NoX_4Aeg_237674436")]
    [DisplayName("Certificate Information")]
    [IsoXmlTag("CertInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? CertificateInformation { get; init; } 
    
    
    #nullable disable
    
}
