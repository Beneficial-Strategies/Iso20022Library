// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a subscription multiple order.
/// </summary>
[IsoId("_UzJj-tp-Ed-ak6NoX_4Aeg_-563586890")]
[DisplayName("Subscription Multiple Order Instruction")]
public partial record SubscriptionMultipleOrderInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_UzSt4Np-Ed-ak6NoX_4Aeg_2068096907")]
    [DisplayName("Multiple Order Details")]
    [IsoXmlTag("MltplOrdrDtls")]
    public required SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_UzSt4dp-Ed-ak6NoX_4Aeg_37627214")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_UzSt4tp-Ed-ak6NoX_4Aeg_-35333257")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UzSt49p-Ed-ak6NoX_4Aeg_979070629")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
