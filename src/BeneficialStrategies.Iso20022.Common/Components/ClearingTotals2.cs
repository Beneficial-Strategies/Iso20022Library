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
[IsoId("_vMomEZMwEeuleeHpFMMhmQ")]
[DisplayName("Clearing Totals")]
public partial record ClearingTotals2
{
    #nullable enable
    
    /// <summary>
    /// Number of transactions to clear.
    /// </summary>
    [IsoId("_vRLu4ZMwEeuleeHpFMMhmQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    /// <summary>
    /// Gross clearing accumulated amount.
    /// </summary>
    [IsoId("_vRLu45MwEeuleeHpFMMhmQ")]
    [DisplayName("Accumulated Amount")]
    [IsoXmlTag("AcmltdAmt")]
    public required Amount17 AccumulatedAmount { get; init; } 
    
    
    #nullable disable
    
}
