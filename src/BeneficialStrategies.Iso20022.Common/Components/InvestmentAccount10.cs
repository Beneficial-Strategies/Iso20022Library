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
[IsoId("_U8-1ZNp-Ed-ak6NoX_4Aeg_1336807406")]
[DisplayName("Investment Account")]
public record InvestmentAccount10
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_U8-1Zdp-Ed-ak6NoX_4Aeg_433269377")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification1Choice_> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_U8-1Ztp-Ed-ak6NoX_4Aeg_433268902")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification1 AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_U8-1Z9p-Ed-ak6NoX_4Aeg_432348480")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_U8-1aNp-Ed-ak6NoX_4Aeg_432348836")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_U9ImYNp-Ed-ak6NoX_4Aeg_433269040")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary1> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_U9ImYdp-Ed-ak6NoX_4Aeg_433270359")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    [IsoId("_U9ImYtp-Ed-ak6NoX_4Aeg_238056455")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_U9ImY9p-Ed-ak6NoX_4Aeg_1777316854")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Indicates whether the beneficial ownership certification has been sent, certifying that the beneficial owner is eligible to own a specific investment fund or investment fund class.
    /// </summary>
    [IsoId("_U9ImZNp-Ed-ak6NoX_4Aeg_-471390939")]
    [DisplayName("Beneficiary Certification Indicator")]
    [IsoXmlTag("BnfcryCertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BeneficiaryCertificationIndicator { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_U9ImZdp-Ed-ak6NoX_4Aeg_-809158432")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public PartyIdentification1Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Party related to an account that is not the legal account owner, eg, the power of attorney.
    /// </summary>
    [IsoId("_U9ImZtp-Ed-ak6NoX_4Aeg_621294269")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification1Choice_? AccountServicer { get; init; }
}
