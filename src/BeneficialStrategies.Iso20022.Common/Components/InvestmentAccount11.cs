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
[IsoId("_U81EZdp-Ed-ak6NoX_4Aeg_1839205783")]
[DisplayName("Investment Account")]
public record InvestmentAccount11
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_U81EZtp-Ed-ak6NoX_4Aeg_1749624511")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public PartyIdentification1Choice_? OwnerIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_U81EZ9p-Ed-ak6NoX_4Aeg_1749624199")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification1 AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_U81EaNp-Ed-ak6NoX_4Aeg_1749624096")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_U81Eadp-Ed-ak6NoX_4Aeg_1749624156")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_U81Eatp-Ed-ak6NoX_4Aeg_1749624251")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary1? IntermediaryInformation { get; init; }

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_U81Ea9p-Ed-ak6NoX_4Aeg_-22152956")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    [IsoId("_U8-1YNp-Ed-ak6NoX_4Aeg_637939435")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_U8-1Ydp-Ed-ak6NoX_4Aeg_120849888")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Indicates whether the beneficial ownership certification has been sent, certifying that the beneficial owner is eligible to own a specific investment fund or investment fund class.
    /// </summary>
    [IsoId("_U8-1Ytp-Ed-ak6NoX_4Aeg_-1148005916")]
    [DisplayName("Beneficiary Certification Indicator")]
    [IsoXmlTag("BnfcryCertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BeneficiaryCertificationIndicator { get; init; }

    /// <summary>
    /// Party related to an account that is not the legal account owner, eg, the power of attorney.
    /// </summary>
    [IsoId("_U8-1Y9p-Ed-ak6NoX_4Aeg_624989270")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification1Choice_? AccountServicer { get; init; }
}
