// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_VScIA9p-Ed-ak6NoX_4Aeg_-1430262467")]
[DisplayName("Tax")]
public partial record Tax6
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_VScIBNp-Ed-ak6NoX_4Aeg_-1422874315")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType1 Type { get; init; } 
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_VScIBdp-Ed-ak6NoX_4Aeg_-1422873792")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_VScIBtp-Ed-ak6NoX_4Aeg_-1422873774")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_VScIB9p-Ed-ak6NoX_4Aeg_-1422873757")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_VScICNp-Ed-ak6NoX_4Aeg_-1422873714")]
    [DisplayName("Exemption Indicator")]
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    
    /// <summary>
    /// Reason for a tax exemption.
    /// </summary>
    [IsoId("_VScICdp-Ed-ak6NoX_4Aeg_-1422873697")]
    [DisplayName("Exemption Reason")]
    [IsoXmlTag("XmptnRsn")]
    public TaxExemptionReason1? ExemptionReason { get; init; } 
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_VSl5ANp-Ed-ak6NoX_4Aeg_210895533")]
    [DisplayName("Tax Calculation Details")]
    [IsoXmlTag("TaxClctnDtls")]
    public TaxCalculationInformation1? TaxCalculationDetails { get; init; } 
    
    
    #nullable disable
    
}
