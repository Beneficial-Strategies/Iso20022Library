// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of travel document used for identification and/or authentication of the customer.
/// </summary>
[IsoId("_nTBeERyvEey6gI8SKlv7rg")]
[DisplayName("Travel Document")]
public partial record TravelDocument2
{
    #nullable enable
    
    /// <summary>
    /// Type of travel document.
    /// </summary>
    [IsoId("_nYcwoRyvEey6gI8SKlv7rg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OfficialDocumentType1Code Type { get; init; } 
    
    /// <summary>
    /// Form of travel document.
    /// </summary>
    [IsoId("_nYcwoxyvEey6gI8SKlv7rg")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; } 
    
    /// <summary>
    /// Identification of travel document (for example, passport number).
    /// </summary>
    [IsoId("_nYdXsRyvEey6gI8SKlv7rg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; } 
    
    /// <summary>
    /// Party assigning the travel document.
    /// </summary>
    [IsoId("_nYdXsxyvEey6gI8SKlv7rg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Assigner { get; init; } 
    
    /// <summary>
    /// Issuance date of travel document.
    /// </summary>
    [IsoId("_nYdXtRyvEey6gI8SKlv7rg")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssuanceDate { get; init; } 
    
    /// <summary>
    /// Expiration date of travel document (if and when relevant).
    /// </summary>
    [IsoId("_nYdXtxyvEey6gI8SKlv7rg")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; } 
    
    /// <summary>
    /// Country issuing the travel document.
    /// </summary>
    [IsoId("_nYdXuRyvEey6gI8SKlv7rg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
