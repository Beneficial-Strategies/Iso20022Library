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
[IsoId("286df046-f268-4433-9e5f-f8e5278f6a22")]
[DisplayName("Investment Account83")]
public record InvestmentAccount83
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("324281ac-b115-4edb-858f-1a6b5599c4b2")]
    [DisplayName("Owner Identification")]
    [IsoXmlTag("OwnrId")]
    public ValueList<PartyIdentification139> OwnerIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("f91a8845-b5ec-44de-9a43-4d4ff061bd74")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required IsoMax35Text AccountIdentification { get; init; }

    /// <summary>
    /// Name of the account.
    /// </summary>
    [IsoId("c3a753a2-8548-408f-a605-cbb66886f529")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax35Text? AccountName { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes.
    /// </summary>
    [IsoId("281b3217-8bb8-489f-8ef1-4abf17871231")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    public IsoMax35Text? AccountDesignation { get; init; }

    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("38d356c2-55c5-4f1c-b739-b2bf94481ab2")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("1e9c2774-4d45-48b7-ace6-f193b720861f")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Digital account where digital assets or digital tokens can be stored and where an entry is made.
    /// </summary>
    [IsoId("03746e27-d8f6-4acd-a5c1-852f450f7fbb")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Party that provides services relating to financial products to investors.
    /// </summary>
    [IsoId("18d85b67-f95f-4700-bcaa-d78a3587f18d")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("a909a0a8-b041-4fbb-a1ce-e70734a2c737")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("132609e2-bff9-45cd-a51c-b7e30034e418")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("63d3d9da-bbee-49f2-b914-456bb56da9b6")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("b7b61d3b-3271-4066-b6a7-51634c701f19")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("e8f11206-b476-445b-a49f-01e68471a544")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("274becbe-bc60-4f51-b463-1af5389893f1")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters25? SettlementPartiesDetails { get; init; }
}
