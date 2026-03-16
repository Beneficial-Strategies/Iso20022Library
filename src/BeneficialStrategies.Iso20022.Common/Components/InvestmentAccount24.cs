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
[IsoId("_Rw1ph9p-Ed-ak6NoX_4Aeg_-1507060862")]
[DisplayName("Investment Account")]
public record InvestmentAccount24
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Rw1piNp-Ed-ak6NoX_4Aeg_-1507060836")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification2Choice_> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Rw-zcNp-Ed-ak6NoX_4Aeg_-1507060819")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_Rw-zcdp-Ed-ak6NoX_4Aeg_-1507060784")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_Rw-zctp-Ed-ak6NoX_4Aeg_-1507060542")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_Rw-zc9p-Ed-ak6NoX_4Aeg_-1824466073")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary10> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_Rw-zdNp-Ed-ak6NoX_4Aeg_-1507060490")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    [IsoId("_Rw-zddp-Ed-ak6NoX_4Aeg_-1507060447")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_Rw-zdtp-Ed-ak6NoX_4Aeg_-1507060412")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_Rw-zd9p-Ed-ak6NoX_4Aeg_-1507060387")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Party related to an account that is not the legal account owner, eg, the power of attorney.
    /// </summary>
    [IsoId("_Rw-zeNp-Ed-ak6NoX_4Aeg_-1507060370")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_RxIkcNp-Ed-ak6NoX_4Aeg_84532035")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount1? SubAccountDetails { get; init; }
}
