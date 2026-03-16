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
[IsoId("_loOlMSR9EeWWV-wpfEW00A")]
[DisplayName("Investment Account")]
public record InvestmentAccount54
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_mE8WYyR9EeWWV-wpfEW00A")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification70Choice_> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_mE8WZSR9EeWWV-wpfEW00A")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_mE8WZyR9EeWWV-wpfEW00A")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_mE8WaSR9EeWWV-wpfEW00A")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_mE8WayR9EeWWV-wpfEW00A")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary34> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_mE8WbSR9EeWWV-wpfEW00A")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("_mE8WbyR9EeWWV-wpfEW00A")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_mE8WcSR9EeWWV-wpfEW00A")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_mE8WcyR9EeWWV-wpfEW00A")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_mE8WdSR9EeWWV-wpfEW00A")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_mE8WdyR9EeWWV-wpfEW00A")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification70Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("_mE8WeSR9EeWWV-wpfEW00A")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_m3aR8ClbEeWFzIDYnva8TQ")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public DeliveringPartiesAndAccount14? SettlementPartiesDetails { get; init; }
}
