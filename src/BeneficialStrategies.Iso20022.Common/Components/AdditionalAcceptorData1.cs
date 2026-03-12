// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional acceptor data
/// </summary>
[IsoId("_ZG0IJfJREeiJn9rM2Znz2w")]
[DisplayName("Additional Acceptor Data")]
public partial record AdditionalAcceptorData1
{
    #nullable enable
    
    /// <summary>
    /// Contains a code that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [IsoId("_ZG0vMfJREeiJn9rM2Znz2w")]
    [DisplayName("Additional Transaction Reference Number")]
    [IsoXmlTag("AddtlTxRefNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; } 
    
    /// <summary>
    /// Identification of the company recognized by the taxation authority.  Used for reporting transaction-related taxes.
    /// </summary>
    [IsoId("__OitIfJREeiJn9rM2Znz2w")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? TaxRegistrationIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the company recognized by the taxation authority.  Used for reporting corporate-related taxes.
    /// </summary>
    [IsoId("_ZG0vMvJREeiJn9rM2Znz2w")]
    [DisplayName("Corporate Tax Identification")]
    [IsoXmlTag("CorpTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CorporateTaxIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the corporate tax identification type.
    /// </summary>
    [IsoId("_AFElwP41Eeix6ug6HlF6IQ")]
    [DisplayName("Corporate Tax Identification Type")]
    [IsoXmlTag("CorpTaxIdTp")]
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; } 
    
    /// <summary>
    /// Contains additional identification information. 
    /// </summary>
    [IsoId("_ZG0vMPJREeiJn9rM2Znz2w")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AdditionalIdentification1? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Contains various classifications of business ownership characteristics.
    /// </summary>
    [IsoId("_0X-5oPJZEeiJn9rM2Znz2w")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public AdditionalCharacteristics1? Characteristics { get; init; } 
    
    /// <summary>
    /// Additional information about the card acceptor.
    /// </summary>
    [IsoId("_aVCxoPJYEeiJn9rM2Znz2w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
