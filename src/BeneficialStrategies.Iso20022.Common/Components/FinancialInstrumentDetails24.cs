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
[IsoId("_Enc3UW-SEeaxWKxOD2aB-w")]
[DisplayName("Financial Instrument Details")]
public partial record FinancialInstrumentDetails24
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_E_aEU2-SEeaxWKxOD2aB-w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_E_aEW2-SEeaxWKxOD2aB-w")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes63? FinancialInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_E_aEY2-SEeaxWKxOD2aB-w")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails40> SubBalance { get; init; } = [];
    // ID for the above is _E_aEY2-SEeaxWKxOD2aB-w
    
    
    #nullable disable
    
}
