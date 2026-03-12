// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where a single, pre defined, financial instrument is sold and repurchased.
/// </summary>
[IsoId("_u1WsobcREeabfchHYoktpA")]
[DisplayName("Specific Collateral")]
public partial record SpecificCollateral2
{
    #nullable enable
    
    /// <summary>
    /// Identification of collateral placed as security for repo.
    /// </summary>
    [IsoId("_u_BmAbcREeabfchHYoktpA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
