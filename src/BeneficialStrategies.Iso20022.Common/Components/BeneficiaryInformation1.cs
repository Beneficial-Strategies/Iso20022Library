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
/// Information about the beneficial owner.
/// </summary>
[IsoId("_TUOu5tp-Ed-ak6NoX_4Aeg_768452995")]
[DisplayName("Beneficiary Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BeneficiaryInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BeneficiaryInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BeneficiaryInformation1( ERISAEligibility1Code reqERISAEligibility,System.String reqBenefitPlanDeclarationIndicator,System.String reqNoChangeToBeneficiaryDetailsIndicator )
    {
        ERISAEligibility = reqERISAEligibility;
        BenefitPlanDeclarationIndicator = reqBenefitPlanDeclarationIndicator;
        NoChangeToBeneficiaryDetailsIndicator = reqNoChangeToBeneficiaryDetailsIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the beneficial owner.
    /// </summary>
    [IsoId("_TUOu59p-Ed-ak6NoX_4Aeg_1370588637")]
    [DisplayName("Beneficiary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryId")]
    #endif
    [IsoXmlTag("BnfcryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson15? BeneficiaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson15? BeneficiaryIdentification { get; init; } 
    #else
    public IndividualPerson15? BeneficiaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Eligibility to federal Employee Retirement Income Security Act.
    /// </summary>
    [IsoId("_TUOu6Np-Ed-ak6NoX_4Aeg_1168339431")]
    [DisplayName("ERISA Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ERISAElgblty")]
    #endif
    [IsoXmlTag("ERISAElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ERISAEligibility1Code ERISAEligibility { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ERISAEligibility1Code ERISAEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ERISAEligibility1Code ERISAEligibility { get; init; } 
    #else
    public ERISAEligibility1Code ERISAEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Federal Employee Retirement Income Security Act (ERISA) rate.
    /// </summary>
    [IsoId("_TUOu6dp-Ed-ak6NoX_4Aeg_1168339462")]
    [DisplayName("ERISA Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ERISARate")]
    #endif
    [IsoXmlTag("ERISARate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ERISARate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ERISARate { get; init; } 
    #else
    public System.Decimal? ERISARate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the investor is a benefit plan investor.
    /// </summary>
    [IsoId("_TUOu6tp-Ed-ak6NoX_4Aeg_1168339492")]
    [DisplayName("Benefit Plan Declaration Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnftPlanDclrtnInd")]
    #endif
    [IsoXmlTag("BnftPlanDclrtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator BenefitPlanDeclarationIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BenefitPlanDeclarationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BenefitPlanDeclarationIndicator { get; init; } 
    #else
    public System.String BenefitPlanDeclarationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that there has been no change to the beneficiary&apos;s details, such as domicile, investor status, etc, as represented in the initial subscription document.
    /// </summary>
    [IsoId("_TUX40Np-Ed-ak6NoX_4Aeg_1168339523")]
    [DisplayName("No Change To Beneficiary Details Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoChngToBnfcryDtlsInd")]
    #endif
    [IsoXmlTag("NoChngToBnfcryDtlsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator NoChangeToBeneficiaryDetailsIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NoChangeToBeneficiaryDetailsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NoChangeToBeneficiaryDetailsIndicator { get; init; } 
    #else
    public System.String NoChangeToBeneficiaryDetailsIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
