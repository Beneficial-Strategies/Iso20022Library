// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the individual tax amount(s) per period of the tax record.
/// </summary>
[IsoId("_yv3kC69fEeen6L7OP7lnvg")]
[DisplayName("Tax Record Details")]
public partial record TaxRecordDetails2
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_zCdv4a9fEeen6L7OP7lnvg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod2? Period { get; init; } 
    
    /// <summary>
    /// Underlying tax amount related to the specified period.
    /// </summary>
    [IsoId("_zCdv469fEeen6L7OP7lnvg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
