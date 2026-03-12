// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing data at batch level. Allows clearing in different currencies.
/// </summary>
[IsoId("_oY5L8ZMxEeuleeHpFMMhmQ")]
[DisplayName("Clearing Batch Data")]
public partial record ClearingBatchData2
{
    #nullable enable
    
    /// <summary>
    /// Type of clearing method used.
    /// </summary>
    [IsoId("_odNEMZMxEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_odNEM5MxEeuleeHpFMMhmQ")]
    [DisplayName("Other Clearing Method")]
    [IsoXmlTag("OthrClrMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_odNENZMxEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClearingPriority { get; init; } 
    
    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_odNEN5MxEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClearingDate { get; init; } 
    
    /// <summary>
    /// Clearing totals of the batch file.
    /// </summary>
    [IsoId("_odNEOZMxEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Totals")]
    [IsoXmlTag("ClrTtls")]
    public ClearingTotals2? ClearingTotals { get; init; } 
    
    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_odNEO5MxEeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount17? InterchangeFee { get; init; } 
    
    /// <summary>
    /// Fee of the agent.
    /// </summary>
    [IsoId("_odNEPZMxEeuleeHpFMMhmQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount17? AgentFee { get; init; } 
    
    
    #nullable disable
    
}
