// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the total amount of taxes.
/// </summary>
[IsoId("_U5QL9dp-Ed-ak6NoX_4Aeg_1827324489")]
[DisplayName("Total Taxes")]
public partial record TotalTaxes2
{
    #nullable enable
    
    /// <summary>
    /// Total value of the taxes for a specific order.
    /// </summary>
    [IsoId("_U5QL9tp-Ed-ak6NoX_4Aeg_1827324679")]
    [DisplayName("Total Amount Of Taxes")]
    [IsoXmlTag("TtlAmtOfTaxs")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    [IsoId("_U5QL99p-Ed-ak6NoX_4Aeg_1827325403")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax7> TaxDetails { get; init; } = [];
    // ID for the above is _U5QL99p-Ed-ak6NoX_4Aeg_1827325403
    
    
    #nullable disable
    
}
