// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Case Assignment6.
/// </summary>
[IsoId("_voTj0DEyEe6g-ffJsqGiSA")]
[DisplayName("Case Assignment6")]
public partial record CaseAssignment6
{
    #nullable enable

    /// <summary>
    /// Assignee.
    /// </summary>
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    public required Party50Choice_ Assignee { get; init; } 

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public required Party50Choice_ Assigner { get; init; } 

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; } 

    
    #nullable disable
    
}
