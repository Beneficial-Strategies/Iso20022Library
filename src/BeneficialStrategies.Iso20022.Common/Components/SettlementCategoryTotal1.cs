// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement totals
/// </summary>
[IsoId("_Dvqc4FdDEeeFltjJxERUxw")]
[DisplayName("Settlement Category Total")]
public partial record SettlementCategoryTotal1
{
    #nullable enable
    
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_RhhqQFdDEeeFltjJxERUxw")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Count { get; init; } 
    
    /// <summary>
    /// Gross amount.
    /// </summary>
    [IsoId("_pDwlgFdDEeeFltjJxERUxw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount14 Amount { get; init; } 
    
    /// <summary>
    /// Interchange fee amount.
    /// </summary>
    [IsoId("_clMWkFdEEeeFltjJxERUxw")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount14? InterchangeFee { get; init; } 
    
    /// <summary>
    /// Processing fee.
    /// </summary>
    [IsoId("_iVT7EFdEEeeFltjJxERUxw")]
    [DisplayName("Processing Fee")]
    [IsoXmlTag("PrcgFee")]
    public Amount14? ProcessingFee { get; init; } 
    
    
    #nullable disable
    
}
