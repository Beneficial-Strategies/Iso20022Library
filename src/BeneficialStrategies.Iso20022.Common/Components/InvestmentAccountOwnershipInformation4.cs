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
[IsoId("_TT7M6tp-Ed-ak6NoX_4Aeg_2021205061")]
[DisplayName("Investment Account Ownership Information")]
public partial record InvestmentAccountOwnershipInformation4
{
    #nullable enable
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_TT7M69p-Ed-ak6NoX_4Aeg_2027671707")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation3 Organisation { get; init; } 
    
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_TT7M7Np-Ed-ak6NoX_4Aeg_2035058276")]
    [DisplayName("Individual Person")]
    [IsoXmlTag("IndvPrsn")]
    public required IndividualPerson11 IndividualPerson { get; init; } 
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TT7M7dp-Ed-ak6NoX_4Aeg_2023977489")]
    [DisplayName("Money Laundering Check")]
    [IsoXmlTag("MnyLndrgChck")]
    public MoneyLaunderingCheck1Code? MoneyLaunderingCheck { get; init; } 
    
    /// <summary>
    /// Status of an identity check to prevent money laundering. This includes the counter-terrorism check.
    /// </summary>
    [IsoId("_TUE94Np-Ed-ak6NoX_4Aeg_2024900244")]
    [DisplayName("Extended Money Laundering Check")]
    [IsoXmlTag("XtndedMnyLndrgChck")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedMoneyLaunderingCheck { get; init; } 
    
    /// <summary>
    /// Percentage of ownership or beneficiary ownership of the shares/units in the account. All subsequent subscriptions and or redemptions will be allocated using the same percentage.
    /// </summary>
    [IsoId("_TUE94dp-Ed-ak6NoX_4Aeg_2024901192")]
    [DisplayName("Ownership Beneficiary Rate")]
    [IsoXmlTag("OwnrshBnfcryRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OwnershipBeneficiaryRate { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_TUE94tp-Ed-ak6NoX_4Aeg_2025822759")]
    [DisplayName("Client Identification")]
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether an owner of an investment account may benefit from a fiscal exemption or amnesty for instance for declaring overseas investments.
    /// </summary>
    [IsoId("_TUE949p-Ed-ak6NoX_4Aeg_2026746126")]
    [DisplayName("Fiscal Exemption")]
    [IsoXmlTag("FsclXmptn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FiscalExemption { get; init; } 
    
    /// <summary>
    /// Indicates whether the account owner signature is required to authorise transactions on the account.
    /// </summary>
    [IsoId("_TUE95Np-Ed-ak6NoX_4Aeg_2026747073")]
    [DisplayName("Signatory Right Indicator")]
    [IsoXmlTag("SgntryRghtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SignatoryRightIndicator { get; init; } 
    
    /// <summary>
    /// Information related to the party profile to be inserted or deleted.
    /// </summary>
    [IsoId("_TUE95dp-Ed-ak6NoX_4Aeg_1886110107")]
    [DisplayName("Modified Investor Profile Validation")]
    [IsoXmlTag("ModfdInvstrPrflVldtn")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope11> ModifiedInvestorProfileValidation { get; init; } = [];
    
    
    #nullable disable
    
}
