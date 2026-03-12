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
[IsoId("_Sd15dtp-Ed-ak6NoX_4Aeg_-47444681")]
[DisplayName("Side Pocket Information")]
public partial record SidePocketInformation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor wants to participate in the optional side pocket.
    /// </summary>
    [IsoId("_Sd15d9p-Ed-ak6NoX_4Aeg_-890846613")]
    [DisplayName("Side Pocket Inclusion Indicator")]
    [IsoXmlTag("SdPcktInclsnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SidePocketInclusionIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the side pocket.
    /// </summary>
    [IsoId("_Sd15eNp-Ed-ak6NoX_4Aeg_1426393911")]
    [DisplayName("Side Pocket Identification")]
    [IsoXmlTag("SdPcktId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SidePocketIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of the side pocket.
    /// </summary>
    [IsoId("_Sd_DYNp-Ed-ak6NoX_4Aeg_-1013251518")]
    [DisplayName("Side Pocket Quantity")]
    [IsoXmlTag("SdPcktQty")]
    public SidePocketUnitsOrAmountOrRate1Choice_? SidePocketQuantity { get; init; } 
    
    
    #nullable disable
    
}
