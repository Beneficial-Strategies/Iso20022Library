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
[IsoId("_nS_4URX-EeOBE-jZfcm4KQ")]
[DisplayName("Investment Account")]
public record InvestmentAccount40
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_nwwyYxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification2Choice_> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nwwyZRX-EeOBE-jZfcm4KQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification1 AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_nwwyZxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_nwwyaRX-EeOBE-jZfcm4KQ")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_nwwyaxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary25> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_nwwybRX-EeOBE-jZfcm4KQ")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, ie, there is no physical document representing the security.
    /// </summary>
    [IsoId("_nwwybxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_nwwycRX-EeOBE-jZfcm4KQ")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_nwwycxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_nwwydRX-EeOBE-jZfcm4KQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_nwwydxX-EeOBE-jZfcm4KQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("_CrIHEBX_EeOBE-jZfcm4KQ")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount1? SubAccountDetails { get; init; }
}
