// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about an amended election instruction.
/// </summary>
[IsoId("_UJuMftp-Ed-ak6NoX_4Aeg_599123828")]
[DisplayName("Corporate Action Election")]
public partial record CorporateActionElection1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJuMf9p-Ed-ak6NoX_4Aeg_873409748")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UJuMgNp-Ed-ak6NoX_4Aeg_873409749")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; } 
    
    /// <summary>
    /// Quantity of the securities that was instructed in the original election advice.
    /// </summary>
    [IsoId("_UJ39cNp-Ed-ak6NoX_4Aeg_886341399")]
    [DisplayName("Original Instructed Quantity")]
    [IsoXmlTag("OrgnlInstdQty")]
    public required UnitOrFaceAmount1Choice_ OriginalInstructedQuantity { get; init; } 
    
    /// <summary>
    /// Remaining instructed securities quantity after the amendment of the election.
    /// </summary>
    [IsoId("_UJ39cdp-Ed-ak6NoX_4Aeg_-1298580646")]
    [DisplayName("Remaining Quantity")]
    [IsoXmlTag("RmngQty")]
    public required UnitOrFaceAmount1Choice_ RemainingQuantity { get; init; } 
    
    
    #nullable disable
    
}
