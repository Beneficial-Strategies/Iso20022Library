// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details to identify an investigation case.
/// </summary>
[IsoId("_mm8A4bTREeeyuKckOGlwuA")]
[DisplayName("Case")]
public partial record Case4
{
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_mvnbwbTREeeyuKckOGlwuA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party that created the investigation case.
    /// </summary>
    [IsoId("_mvnbw7TREeeyuKckOGlwuA")]
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public required Party35Choice_ Creator { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    [IsoId("_mvnbxbTREeeyuKckOGlwuA")]
    [DisplayName("Reopen Case Indication")]
    [IsoXmlTag("ReopCaseIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
    
    
    #nullable disable
    
}
