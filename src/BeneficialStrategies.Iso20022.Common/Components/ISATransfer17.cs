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
[IsoId("_gYsfwS8EEeO59oUFO5eLvw")]
[DisplayName("ISA Transfer")]
public partial record ISATransfer17
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_DjufkS8EEeO59oUFO5eLvw")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_sFyZAS8EEeO59oUFO5eLvw")]
    [DisplayName("Product Transfer")]
    [IsoXmlTag("PdctTrf")]
    public ValueList<ISATransfer16> ProductTransfer { get; init; } = [];
    // ID for the above is _sFyZAS8EEeO59oUFO5eLvw
    
    
    #nullable disable
    
}
