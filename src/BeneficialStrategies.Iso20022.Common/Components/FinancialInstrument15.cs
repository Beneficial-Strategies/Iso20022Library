// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the financial instrument.
/// </summary>
[IsoId("_TBTL1dp-Ed-ak6NoX_4Aeg_1946780155")]
[DisplayName("Financial Instrument")]
public partial record FinancialInstrument15
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using a choice of either ISIN, local code, or a description of the instrument. ISIN is the preferred format.
    /// </summary>
    [IsoId("_TBTL1tp-Ed-ak6NoX_4Aeg_1946780251")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification6Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Provides the ability to describe the instrument through a description and main characteristics.
    /// </summary>
    [IsoId("_TBc80Np-Ed-ak6NoX_4Aeg_1946780178")]
    [DisplayName("Instrument Description")]
    [IsoXmlTag("InstrmDesc")]
    public SecurityInstrumentDescription2? InstrumentDescription { get; init; } 
    
    /// <summary>
    /// Provides details of the underlying financial instrument for which the transaction report is being sent. If there is more than one underlying financial instrument then it is the dominant/ultimate instrument that should be identified here.
    /// </summary>
    [IsoId("_TBc80dp-Ed-ak6NoX_4Aeg_1946780234")]
    [DisplayName("Underlying Instrument Identification")]
    [IsoXmlTag("UndrlygInstrmId")]
    public SecurityIdentification6Choice_? UnderlyingInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
