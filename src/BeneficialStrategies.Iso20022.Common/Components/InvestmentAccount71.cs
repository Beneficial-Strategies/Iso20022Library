// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_EAoRMZEFEem7fvtoGpNpow")]
[DisplayName("Investment Account")]
public record InvestmentAccount71
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_EUtq05EFEem7fvtoGpNpow")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public PartyIdentification139? OwnerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_EUtq1ZEFEem7fvtoGpNpow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_EUtq15EFEem7fvtoGpNpow")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_EUtq2ZEFEem7fvtoGpNpow")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_EUtq55EFEem7fvtoGpNpow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_EUtq6ZEFEem7fvtoGpNpow")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_EUtq25EFEem7fvtoGpNpow")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary43? IntermediaryInformation { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_vvhqobHhEem4X-SfagDa8w")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("_2isAgbHhEem4X-SfagDa8w")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_EUtq4ZEFEem7fvtoGpNpow")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_EUtq45EFEem7fvtoGpNpow")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_EUtq5ZEFEem7fvtoGpNpow")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("_EUtq65EFEem7fvtoGpNpow")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters16? SettlementPartiesDetails { get; init; }
}
