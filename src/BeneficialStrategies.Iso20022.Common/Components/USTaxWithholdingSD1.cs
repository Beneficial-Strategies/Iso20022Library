// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// US tax withholding election details.
/// </summary>
[IsoId("_1QsThTL3EeKU9IrkkToqcw_-215226807")]
[DisplayName("US Tax Withholding SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record USTaxWithholdingSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a USTaxWithholdingSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public USTaxWithholdingSD1( System.String reqPlaceAndName,NRATax1Code reqNRATaxCode,FinancialInstrumentQuantity15Choice_ reqQuantity )
    {
        PlaceAndName = reqPlaceAndName;
        NRATaxCode = reqNRATaxCode;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Q1dcDL3EeKU9IrkkToqcw_1602916505")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Non resident alien (NRA) tax code. Each U.S. tax withholding eligible distribution must have a determination of the tax liability. This code is relevant to tax withholding and U.S. IRS reporting. Foreign securities also have an applicable tax code, but all foreign issues have one standard code.
    /// </summary>
    [IsoId("_1Q1dcTL3EeKU9IrkkToqcw_376906938")]
    [DisplayName("NRA Tax Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NRATaxCd")]
    #endif
    [IsoXmlTag("NRATaxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NRATax1Code NRATaxCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NRATax1Code NRATaxCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NRATax1Code NRATaxCode { get; init; } 
    #else
    public NRATax1Code NRATaxCode { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_1Q1dcjL3EeKU9IrkkToqcw_186825746")]
    [DisplayName("Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRate")]
    #endif
    [IsoXmlTag("WhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateFormat6Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateFormat6Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateFormat6Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Elected quantity per NRA tax code.
    /// </summary>
    [IsoId("_1Q1dczL3EeKU9IrkkToqcw_1269415764")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ Quantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
