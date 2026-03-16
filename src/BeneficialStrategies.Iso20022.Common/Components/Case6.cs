// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Case6.
/// </summary>
[IsoId("_w5_1MTEyEe6g-ffJsqGiSA")]
[DisplayName("Case6")]
public partial record Case6
{
    #nullable enable

    /// <summary>
    /// Creator.
    /// </summary>
    [DisplayName("Creator")]
    [IsoXmlTag("Cretr")]
    public required Party50Choice_ Creator { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    /// <summary>
    /// Reopen Case Indication.
    /// </summary>
    [DisplayName("Reopen Case Indication")]
    [IsoXmlTag("ReopCaseIndctn")]
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 

    
    #nullable disable
    
}
