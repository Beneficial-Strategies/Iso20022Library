// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the beneficial owner.
/// </summary>
[IsoId("_TUOu5tp-Ed-ak6NoX_4Aeg_768452995")]
[DisplayName("Beneficiary Information")]
public partial record BeneficiaryInformation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the beneficial owner.
    /// </summary>
    [IsoId("_TUOu59p-Ed-ak6NoX_4Aeg_1370588637")]
    [DisplayName("Beneficiary Identification")]
    [IsoXmlTag("BnfcryId")]
    public IndividualPerson15? BeneficiaryIdentification { get; init; } 
    
    /// <summary>
    /// Eligibility to federal Employee Retirement Income Security Act.
    /// </summary>
    [IsoId("_TUOu6Np-Ed-ak6NoX_4Aeg_1168339431")]
    [DisplayName("ERISA Eligibility")]
    [IsoXmlTag("ERISAElgblty")]
    public required ERISAEligibility1Code ERISAEligibility { get; init; } 
    
    /// <summary>
    /// Federal Employee Retirement Income Security Act (ERISA) rate.
    /// </summary>
    [IsoId("_TUOu6dp-Ed-ak6NoX_4Aeg_1168339462")]
    [DisplayName("ERISA Rate")]
    [IsoXmlTag("ERISARate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ERISARate { get; init; } 
    
    /// <summary>
    /// Indicates whether the investor is a benefit plan investor.
    /// </summary>
    [IsoId("_TUOu6tp-Ed-ak6NoX_4Aeg_1168339492")]
    [DisplayName("Benefit Plan Declaration Indicator")]
    [IsoXmlTag("BnftPlanDclrtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BenefitPlanDeclarationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates that there has been no change to the beneficiary&apos;s details, such as domicile, investor status, etc, as represented in the initial subscription document.
    /// </summary>
    [IsoId("_TUX40Np-Ed-ak6NoX_4Aeg_1168339523")]
    [DisplayName("No Change To Beneficiary Details Indicator")]
    [IsoXmlTag("NoChngToBnfcryDtlsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator NoChangeToBeneficiaryDetailsIndicator { get; init; } 
    
    
    #nullable disable
    
}
