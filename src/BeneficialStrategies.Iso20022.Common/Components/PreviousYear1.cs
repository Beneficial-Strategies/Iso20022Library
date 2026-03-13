// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
/// </summary>
[IsoId("_SvkiqNp-Ed-ak6NoX_4Aeg_-248329088")]
[DisplayName("Previous Year")]
public partial record PreviousYear1
{
    #nullable enable
    
    /// <summary>
    /// Selection ot the entirety of the investment plans.
    /// </summary>
    [IsoId("_Svkiqdp-Ed-ak6NoX_4Aeg_-248329010")]
    [DisplayName("All Previous Years")]
    [IsoXmlTag("AllPrvsYrs")]
    [IsoSimpleType(IsoSimpleType.PreviousAll)]
    public required IsoPreviousAll AllPreviousYears { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Svkiqtp-Ed-ak6NoX_4Aeg_-248328915")]
    [DisplayName("Specific Previous Years")]
    [IsoXmlTag("SpcfcPrvsYrs")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public SimpleValueList<System.UInt16> SpecificPreviousYears { get; init; } = [];
    // ID for the above is _Svkiqtp-Ed-ak6NoX_4Aeg_-248328915
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_Svkiq9p-Ed-ak6NoX_4Aeg_306709098")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    
    #nullable disable
    
}
