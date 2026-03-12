// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Replacement of an existing content by a different one.
/// </summary>
[IsoId("_RbYW4tp-Ed-ak6NoX_4Aeg_65619954")]
[DisplayName("Replacement")]
public partial record Replacement2
{
    #nullable enable
    
    /// <summary>
    /// Content of the current element.
    /// </summary>
    [IsoId("_RbYW49p-Ed-ak6NoX_4Aeg_65620232")]
    [DisplayName("Current Value")]
    [IsoXmlTag("CurVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text CurrentValue { get; init; } 
    
    /// <summary>
    /// Content of the new element.
    /// </summary>
    [IsoId("_RbYW5Np-Ed-ak6NoX_4Aeg_65620263")]
    [DisplayName("Proposed Value")]
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text ProposedValue { get; init; } 
    
    
    #nullable disable
    
}
