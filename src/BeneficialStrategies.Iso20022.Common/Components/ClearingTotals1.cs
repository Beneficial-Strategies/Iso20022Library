// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing totals of the batch file.
/// </summary>
[IsoId("_Ypm1sFA8EeedyPuM0kK2EQ")]
[DisplayName("Clearing Totals")]
public partial record ClearingTotals1
{
    #nullable enable
    
    /// <summary>
    /// Number of transactions to clear.
    /// </summary>
    [IsoId("_hs73YFA8EeedyPuM0kK2EQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    /// <summary>
    /// Gross clearing accumulated amount.
    /// </summary>
    [IsoId("_p3SCoFA8EeedyPuM0kK2EQ")]
    [DisplayName("Accumulated Amount")]
    [IsoXmlTag("AcmltdAmt")]
    public required Amount14 AccumulatedAmount { get; init; } 
    
    
    #nullable disable
    
}
