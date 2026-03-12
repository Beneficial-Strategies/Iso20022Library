// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The discount amount that is attached to an item as a rebate.
/// </summary>
[IsoId("_ifYlkNxOEeioifFt1dhnJA")]
[DisplayName("Sale Item Rebate")]
public partial record SaleItemRebate1
{
    #nullable enable
    
    /// <summary>
    /// Data of the Sale item.
    /// </summary>
    [IsoId("_qEsKENxOEeioifFt1dhnJA")]
    [DisplayName("Sale Item")]
    [IsoXmlTag("SaleItm")]
    public required Product6 SaleItem { get; init; } 
    
    /// <summary>
    /// Short text to qualify a rebate on an line item.
    /// </summary>
    [IsoId("_uhRqINxOEeioifFt1dhnJA")]
    [DisplayName("Rebate Label")]
    [IsoXmlTag("RbtLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RebateLabel { get; init; } 
    
    
    #nullable disable
    
}
