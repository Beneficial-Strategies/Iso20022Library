// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[IsoId("_ccnyqTi8Eeydid5dcNPKvg")]
[DisplayName("Financial Instrument Details")]
public partial record FinancialInstrumentDetails44
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_ccnyrTi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_ccnytTi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes119? FinancialInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_ccnyvTi8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails63> SubBalance { get; init; } = [];
    // ID for the above is _ccnyvTi8Eeydid5dcNPKvg
    
    
    #nullable disable
    
}
