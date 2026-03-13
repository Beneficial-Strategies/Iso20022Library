// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_9MFBtSPvEeWQjryFgN2ITg")]
[DisplayName("ISA Transfer")]
public partial record ISATransfer25
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_9pFtsyPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_9pFttSPvEeWQjryFgN2ITg")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public ValueList<ISATransfer22> ProductTransfer { get; init; } = [];
    // ID for the above is _9pFttSPvEeWQjryFgN2ITg
    
    
    #nullable disable
    
}
