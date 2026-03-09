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
/// Characteristics of the ownership of an investment account.
/// </summary>
[IsoId("_TTyC-dp-Ed-ak6NoX_4Aeg_-400113795")]
[DisplayName("Investment Account Ownership Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountOwnershipInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccountOwnershipInformation5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccountOwnershipInformation5( Organisation2 reqOrganisation,IndividualPerson10 reqIndividualPerson )
    {
        Organisation = reqOrganisation;
        IndividualPerson = reqIndividualPerson;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_TTyC-tp-Ed-ak6NoX_4Aeg_-399189745")]
    [DisplayName("Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Org")]
    #endif
    [IsoXmlTag("Org")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Organisation2 Organisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Organisation2 Organisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation2 Organisation { get; init; } 
    #else
    public Organisation2 Organisation { get; set; } 
    #endif
    
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_TTyC-9p-Ed-ak6NoX_4Aeg_-557057002")]
    [DisplayName("Individual Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvPrsn")]
    #endif
    [IsoXmlTag("IndvPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IndividualPerson10 IndividualPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IndividualPerson10 IndividualPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson10 IndividualPerson { get; init; } 
    #else
    public IndividualPerson10 IndividualPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TTyC_Np-Ed-ak6NoX_4Aeg_-400113658")]
    [DisplayName("Money Laundering Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyLndrgChck")]
    #endif
    [IsoXmlTag("MnyLndrgChck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MoneyLaunderingCheck1Code? MoneyLaunderingCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyLaunderingCheck1Code? MoneyLaunderingCheck { get; init; } 
    #else
    public MoneyLaunderingCheck1Code? MoneyLaunderingCheck { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TTyC_dp-Ed-ak6NoX_4Aeg_-400113208")]
    [DisplayName("Extended Money Laundering Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedMnyLndrgChck")]
    #endif
    [IsoXmlTag("XtndedMnyLndrgChck")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedMoneyLaunderingCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedMoneyLaunderingCheck { get; init; } 
    #else
    public System.String? ExtendedMoneyLaunderingCheck { get; set; } 
    #endif
    
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    [IsoId("_TTyC_tp-Ed-ak6NoX_4Aeg_-1033915899")]
    [DisplayName("Investor Profile Validation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrPrflVldtn")]
    #endif
    [IsoXmlTag("InvstrPrflVldtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyProfileInformation1? InvestorProfileValidation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyProfileInformation1? InvestorProfileValidation { get; init; } 
    #else
    public PartyProfileInformation1? InvestorProfileValidation { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    [IsoId("_TT7M4Np-Ed-ak6NoX_4Aeg_-400112769")]
    [DisplayName("Ownership Beneficiary Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrshBnfcryRate")]
    #endif
    [IsoXmlTag("OwnrshBnfcryRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OwnershipBeneficiaryRate { get; init; } 
    #else
    public System.Decimal? OwnershipBeneficiaryRate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_TT7M4dp-Ed-ak6NoX_4Aeg_-400112242")]
    [DisplayName("Client Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntId")]
    #endif
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientIdentification { get; init; } 
    #else
    public System.String? ClientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
    /// </summary>
    [IsoId("_TT7M4tp-Ed-ak6NoX_4Aeg_-400111857")]
    [DisplayName("Fiscal Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FsclXmptn")]
    #endif
    [IsoXmlTag("FsclXmptn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FiscalExemption { get; init; } 
    #else
    public System.String? FiscalExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
    /// </summary>
    [IsoId("_TT7M49p-Ed-ak6NoX_4Aeg_-400111737")]
    [DisplayName("Signatory Right Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntryRghtInd")]
    #endif
    [IsoXmlTag("SgntryRghtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SignatoryRightIndicator { get; init; } 
    #else
    public System.String? SignatoryRightIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
