// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card acceptor performing the transaction.
/// </summary>
[IsoId("_OjAMIXuyEeS2Z_kGi7H1VQ")]
[DisplayName("Organisation")]
public partial record Organisation19
{
    #nullable enable
    
    /// <summary>
    /// Identification of the card acceptor.
    /// </summary>
    [IsoId("_OvX0MXuyEeS2Z_kGi7H1VQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; } 
    
    /// <summary>
    /// Name of the card acceptor as appearing on the receipt or the statement of account of the cardholder.
    /// It correspond to the ISO 8583, field number 43.
    /// </summary>
    [IsoId("_OvX0M3uyEeS2Z_kGi7H1VQ")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text CommonName { get; init; } 
    
    /// <summary>
    /// Selected language of the card acceptor. Reference ISO 639-1 (alpha-2) and ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_OvX0N3uyEeS2Z_kGi7H1VQ")]
    [DisplayName("Selected Language")]
    [IsoXmlTag("SelctdLang")]
    public LanguageCode? SelectedLanguage { get; init; } 
    
    /// <summary>
    /// Additional card acceptor data required by a card scheme.
    /// </summary>
    [IsoId("_OvX0OXuyEeS2Z_kGi7H1VQ")]
    [DisplayName("Scheme Data")]
    [IsoXmlTag("SchmeData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? SchemeData { get; init; } 
    
    
    #nullable disable
    
}
