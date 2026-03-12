// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to fully identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_T3sBSNp-Ed-ak6NoX_4Aeg_402190265")]
[DisplayName("Referred Document Information")]
public partial record ReferredDocumentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Provides the type of the referred document.
    /// </summary>
    [IsoId("_T3sBSdp-Ed-ak6NoX_4Aeg_1319309617")]
    [DisplayName("Referred Document Type")]
    [IsoXmlTag("RfrdDocTp")]
    public ReferredDocumentType1? ReferredDocumentType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification number of the referred document.
    /// </summary>
    [IsoId("_T31yQNp-Ed-ak6NoX_4Aeg_402190318")]
    [DisplayName("Referred Document Number")]
    [IsoXmlTag("RfrdDocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReferredDocumentNumber { get; init; } 
    
    
    #nullable disable
    
}
