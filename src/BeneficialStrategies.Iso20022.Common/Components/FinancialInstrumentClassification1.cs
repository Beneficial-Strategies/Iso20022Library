// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The classification type of the financial instrument, eg, common share with voting right, fully paid and registered etc.
/// </summary>
[IsoId("_TuJqxdp-Ed-ak6NoX_4Aeg_1114148307")]
[DisplayName("Financial Instrument Classification")]
public partial record FinancialInstrumentClassification1
{
    #nullable enable
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_TuJqxtp-Ed-ak6NoX_4Aeg_1140931613")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public required SecurityClassificationType1Choice_ ClassificationType { get; init; } 
    
    
    #nullable disable
    
}
