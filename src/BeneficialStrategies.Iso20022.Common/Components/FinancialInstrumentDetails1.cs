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
[IsoId("_TwGLiNp-Ed-ak6NoX_4Aeg_2107692738")]
[DisplayName("Financial Instrument Details")]
public partial record FinancialInstrumentDetails1
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_TwGLidp-Ed-ak6NoX_4Aeg_-1836335674")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_TwGLitp-Ed-ak6NoX_4Aeg_517351545")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes4? FinancialInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_TwGLi9p-Ed-ak6NoX_4Aeg_1052099294")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails3> SubBalance { get; init; } = [];
    // ID for the above is _TwGLi9p-Ed-ak6NoX_4Aeg_1052099294
    
    
    #nullable disable
    
}
