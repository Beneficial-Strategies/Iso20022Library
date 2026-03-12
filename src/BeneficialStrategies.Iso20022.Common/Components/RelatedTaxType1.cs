// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of related tax.
/// </summary>
[IsoId("_UPYvktp-Ed-ak6NoX_4Aeg_1950331335")]
[DisplayName("Related Tax Type")]
public partial record RelatedTaxType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_UPYvk9p-Ed-ak6NoX_4Aeg_1967880045")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    public required TaxType3FormatChoice_ TaxType { get; init; } 
    
    /// <summary>
    /// The value of the related tax expressed as an amount.
    /// </summary>
    [IsoId("_UPYvlNp-Ed-ak6NoX_4Aeg_1981731905")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
