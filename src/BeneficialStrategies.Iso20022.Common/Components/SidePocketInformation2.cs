// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that identifies a side pocket in investment fund orders.
/// </summary>
[IsoId("_Sd_DYdp-Ed-ak6NoX_4Aeg_-2131868584")]
[DisplayName("Side Pocket Information")]
public partial record SidePocketInformation2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor wants to participate in the optional side pocket.
    /// </summary>
    [IsoId("_Sd_DYtp-Ed-ak6NoX_4Aeg_-2131868562")]
    [DisplayName("Side Pocket Inclusion Indicator")]
    [IsoXmlTag("SdPcktInclsnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SidePocketInclusionIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the side pocket.
    /// </summary>
    [IsoId("_Sd_DY9p-Ed-ak6NoX_4Aeg_-2131868500")]
    [DisplayName("Side Pocket Identification")]
    [IsoXmlTag("SdPcktId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SidePocketIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of the side pocket.
    /// </summary>
    [IsoId("_Sd_DZNp-Ed-ak6NoX_4Aeg_-2089384261")]
    [DisplayName("Side Pocket Quantity")]
    [IsoXmlTag("SdPcktQty")]
    public SidePocketQuantityAndAmount1? SidePocketQuantity { get; init; } 
    
    
    #nullable disable
    
}
