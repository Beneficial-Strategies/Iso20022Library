// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the ownership of an investment account.
/// </summary>
[IsoId("_TTyC-dp-Ed-ak6NoX_4Aeg_-400113795")]
[DisplayName("Investment Account Ownership Information")]
public partial record InvestmentAccountOwnershipInformation5
{
    #nullable enable
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_TTyC-tp-Ed-ak6NoX_4Aeg_-399189745")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation2 Organisation { get; init; } 
    
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_TTyC-9p-Ed-ak6NoX_4Aeg_-557057002")]
    [DisplayName("Individual Person")]
    [IsoXmlTag("IndvPrsn")]
    public required IndividualPerson10 IndividualPerson { get; init; } 
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TTyC_Np-Ed-ak6NoX_4Aeg_-400113658")]
    [DisplayName("Money Laundering Check")]
    [IsoXmlTag("MnyLndrgChck")]
    public MoneyLaunderingCheck1Code? MoneyLaunderingCheck { get; init; } 
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TTyC_dp-Ed-ak6NoX_4Aeg_-400113208")]
    [DisplayName("Extended Money Laundering Check")]
    [IsoXmlTag("XtndedMnyLndrgChck")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedMoneyLaunderingCheck { get; init; } 
    
    /// <summary>
    /// Information to support Know Your Customer processes.
    /// </summary>
    [IsoId("_TTyC_tp-Ed-ak6NoX_4Aeg_-1033915899")]
    [DisplayName("Investor Profile Validation")]
    [IsoXmlTag("InvstrPrflVldtn")]
    public PartyProfileInformation1? InvestorProfileValidation { get; init; } 
    
    /// <summary>
    /// Percentage of ownership or of beneficial ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    [IsoId("_TT7M4Np-Ed-ak6NoX_4Aeg_-400112769")]
    [DisplayName("Ownership Beneficiary Rate")]
    [IsoXmlTag("OwnrshBnfcryRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_TT7M4dp-Ed-ak6NoX_4Aeg_-400112242")]
    [DisplayName("Client Identification")]
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
    /// </summary>
    [IsoId("_TT7M4tp-Ed-ak6NoX_4Aeg_-400111857")]
    [DisplayName("Fiscal Exemption")]
    [IsoXmlTag("FsclXmptn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    
    /// <summary>
    /// Indicates whether the signature of the account owner is required to authorise transactions on the account.
    /// </summary>
    [IsoId("_TT7M49p-Ed-ak6NoX_4Aeg_-400111737")]
    [DisplayName("Signatory Right Indicator")]
    [IsoXmlTag("SgntryRghtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    
    
    #nullable disable
    
}
