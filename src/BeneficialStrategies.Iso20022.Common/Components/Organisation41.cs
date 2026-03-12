// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant performing the transaction.
/// </summary>
[IsoId("_UhHm4SpPEeuUucRY0yCMTA")]
[DisplayName("Organisation")]
public partial record Organisation41
{
    #nullable enable
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_UwanISpPEeuUucRY0yCMTA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification32? Identification { get; init; } 
    
    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_UwanIypPEeuUucRY0yCMTA")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CommonName { get; init; } 
    
    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_UwanJSpPEeuUucRY0yCMTA")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public LocationCategory4Code? LocationCategory { get; init; } 
    
    /// <summary>
    /// Location and contact information of the merchant performing the transaction.
    /// </summary>
    [IsoId("_UwanJypPEeuUucRY0yCMTA")]
    [DisplayName("Location And Contact")]
    [IsoXmlTag("LctnAndCtct")]
    public CommunicationAddress9? LocationAndContact { get; init; } 
    
    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_UwanKSpPEeuUucRY0yCMTA")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? SchemeData { get; init; } 
    
    
    #nullable disable
    
}
