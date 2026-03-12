// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// US tax withholding election details.
/// </summary>
[IsoId("_1QsThTL3EeKU9IrkkToqcw_-215226807")]
[DisplayName("US Tax Withholding SD")]
public partial record USTaxWithholdingSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Q1dcDL3EeKU9IrkkToqcw_1602916505")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Non resident alien (NRA) tax code. Each U.S. tax withholding eligible distribution must have a determination of the tax liability. This code is relevant to tax withholding and U.S. IRS reporting. Foreign securities also have an applicable tax code, but all foreign issues have one standard code.
    /// </summary>
    [IsoId("_1Q1dcTL3EeKU9IrkkToqcw_376906938")]
    [DisplayName("NRA Tax Code")]
    [IsoXmlTag("NRATaxCd")]
    public required NRATax1Code NRATaxCode { get; init; } 
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_1Q1dcjL3EeKU9IrkkToqcw_186825746")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public RateFormat6Choice_? WithholdingTaxRate { get; init; } 
    
    /// <summary>
    /// Elected quantity per NRA tax code.
    /// </summary>
    [IsoId("_1Q1dczL3EeKU9IrkkToqcw_1269415764")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
