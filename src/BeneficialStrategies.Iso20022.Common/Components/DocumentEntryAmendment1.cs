// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the document entry amendment.
/// </summary>
[IsoId("_rOYIcLP4Eeud-ZmjZVm7MA")]
[DisplayName("Document Entry Amendment")]
public partial record DocumentEntryAmendment1
{
    #nullable enable
    
    /// <summary>
    /// Number of correcting entry.
    /// </summary>
    [IsoId("_DlxxILP5Eeud-ZmjZVm7MA")]
    [DisplayName("Correcting Entry Number")]
    [IsoXmlTag("CrrctgNtryNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber CorrectingEntryNumber { get; init; } 
    
    /// <summary>
    /// Data related to an original document.
    /// </summary>
    [IsoId("_MnAhELP5Eeud-ZmjZVm7MA")]
    [DisplayName("Original Document")]
    [IsoXmlTag("OrgnlDoc")]
    public required DocumentIdentification28 OriginalDocument { get; init; } 
    
    
    #nullable disable
    
}
