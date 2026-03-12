// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Gross clearing control totals.
/// </summary>
[IsoId("_7vrLEFA9EeedyPuM0kK2EQ")]
[DisplayName("Clearing Control Totals")]
public partial record ClearingControlTotals1
{
    #nullable enable
    
    /// <summary>
    /// Number of clearing transactions. To be used for control purpose.
    /// </summary>
    [IsoId("_MMGhQFA-EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Count")]
    [IsoXmlTag("ClrCtrlCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ClearingControlCount { get; init; } 
    
    /// <summary>
    /// Gross accumulated amount of clearing. To be used for control purpose.
    /// </summary>
    [IsoId("_VGpaYFA-EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Amount")]
    [IsoXmlTag("ClrCtrlAmt")]
    public required Amount14 ClearingControlAmount { get; init; } 
    
    
    #nullable disable
    
}
