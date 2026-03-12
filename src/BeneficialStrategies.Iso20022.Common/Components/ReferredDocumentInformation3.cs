// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_ThMM2tp-Ed-ak6NoX_4Aeg_-882800583")]
[DisplayName("Referred Document Information")]
public partial record ReferredDocumentInformation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_ThV90Np-Ed-ak6NoX_4Aeg_-882800242")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType2? Type { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_ThV90dp-Ed-ak6NoX_4Aeg_-882800304")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; } 
    
    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_ThV90tp-Ed-ak6NoX_4Aeg_1205279992")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; } 
    
    
    #nullable disable
    
}
