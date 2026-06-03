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
[IsoId("31c2714f-9856-426b-8901-cd574aa1d268")]
[DisplayName("Investment Account82")]
public record InvestmentAccount82
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("29095624-1d10-4cfe-88ee-38098ec4a0ac")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification139> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("934573e5-dc1c-4ea2-a5b6-bdafab97569e")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("0325889b-028b-4a47-a3b8-a9b7c5d0bf9d")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("3db4c46c-f080-43e0-883e-3d4f977a26bb")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("3f3e2b41-7f45-4c2e-ae1c-6fed1bedf595")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("5dc368e8-8566-4023-b35b-5683e5521bf6")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("ee4a1687-0d7a-44db-9db6-dd42edcf147f")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("d31d0e32-2665-4e68-a6ea-46520284d7d6")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("ac3d5ed0-85d9-4fe7-8721-eaf06b5e346b")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("8c7503ac-b88d-4ef8-990f-2997dd332903")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("f68adad4-c973-4329-b1ca-70921896fca2")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("bde55482-419a-46f1-941f-6f170507c62a")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("c5a5e51e-bfb4-448a-b853-b295502ace99")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("2003f884-2595-4a4d-87fc-8713f24a449c")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters26? SettlementPartiesDetails { get; init; }
}
