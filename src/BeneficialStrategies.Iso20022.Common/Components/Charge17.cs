// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_RuKI_Np-Ed-ak6NoX_4Aeg_389288545")]
[DisplayName("Charge")]
public partial record Charge17
{
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RuKI_dp-Ed-ak6NoX_4Aeg_389288563")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType11Code Type { get; init; } 
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RuTS4Np-Ed-ak6NoX_4Aeg_-1260713645")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_RuTS4dp-Ed-ak6NoX_4Aeg_389288840")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_RuTS4tp-Ed-ak6NoX_4Aeg_-649609118")]
    [DisplayName("Extended Charge Basis")]
    [IsoXmlTag("XtndedChrgBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedChargeBasis { get; init; } 
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RuTS49p-Ed-ak6NoX_4Aeg_389288822")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RuTS5Np-Ed-ak6NoX_4Aeg_389288805")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_RuTS5dp-Ed-ak6NoX_4Aeg_389288857")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    
    #nullable disable
    
}
