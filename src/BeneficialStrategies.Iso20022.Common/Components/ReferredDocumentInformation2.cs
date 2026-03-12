// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information related to the invoice to be financed.
/// </summary>
[IsoId("_ThfHx9p-Ed-ak6NoX_4Aeg_415673992")]
[DisplayName("Referred Document Information")]
public partial record ReferredDocumentInformation2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_ThfHyNp-Ed-ak6NoX_4Aeg_1244134096")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType1? Type { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification number of the referred document.
    /// </summary>
    [IsoId("_Tho4wNp-Ed-ak6NoX_4Aeg_785144500")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DocumentNumber { get; init; } 
    
    /// <summary>
    /// Date associated with the referred document, eg, date of issue.
    /// </summary>
    [IsoId("_Tho4wdp-Ed-ak6NoX_4Aeg_1357727086")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; } 
    
    /// <summary>
    /// Amount of money and currency of a document referred to invoice to be financed.
    /// </summary>
    [IsoId("_Tho4wtp-Ed-ak6NoX_4Aeg_1784392308")]
    [DisplayName("Document Amount")]
    [IsoXmlTag("DocAmt")]
    public ActiveCurrencyAndAmount? DocumentAmount { get; init; } 
    
    
    #nullable disable
    
}
