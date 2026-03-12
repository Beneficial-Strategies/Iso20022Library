// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax identification information.
/// </summary>
[IsoId("_ZEtY8QhGEeSUPbC7DbLJpQ")]
[DisplayName("Tax Identification")]
public partial record TaxIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Tax identification number or identifier.
    /// </summary>
    [IsoId("_hD6rMQhGEeSUPbC7DbLJpQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of tax identification number or identifier.
    /// </summary>
    [IsoId("_ooC5EQhIEeSUPbC7DbLJpQ")]
    [DisplayName("Tax Identification Type")]
    [IsoXmlTag("TaxIdTp")]
    public required TaxIdentificationType1Choice_ TaxIdentificationType { get; init; } 
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_BpuDRAhIEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Date at which the identification was issued.
    /// </summary>
    [IsoId("_BpuDRQhIEeSUPbC7DbLJpQ")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; } 
    
    /// <summary>
    /// Date at which the identification expires.
    /// </summary>
    [IsoId("_BpuDRghIEeSUPbC7DbLJpQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Country that issued the tax identification.
    /// </summary>
    [IsoId("_Zg-eNQhGEeSUPbC7DbLJpQ")]
    [DisplayName("Issuer Country")]
    [IsoXmlTag("IssrCtry")]
    public required CountryCode IssuerCountry { get; init; } 
    
    
    #nullable disable
    
}
