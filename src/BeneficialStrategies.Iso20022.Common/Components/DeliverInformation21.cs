// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_MbYlEZEHEem7fvtoGpNpow")]
[DisplayName("Deliver Information")]
public record DeliverInformation21
{
    /// <summary>
    /// Party that delivers (transferor) securities to the receiving agent (transferee).
    /// </summary>
    [IsoId("_MwNlmZEHEem7fvtoGpNpow")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public PartyIdentification139? Transferor { get; init; }

    /// <summary>
    /// Account from which the securities are to be delivered.
    /// </summary>
    [IsoId("_MwNlm5EHEem7fvtoGpNpow")]
    [DisplayName("Transferor Registered Account")]
    [IsoXmlTag("TrfrRegdAcct")]
    public Account31? TransferorRegisteredAccount { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_MwNlnZEHEem7fvtoGpNpow")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary43> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    [IsoId("_A2ytkrHiEem4X-SfagDa8w")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    [IsoId("_A2ytk7HiEem4X-SfagDa8w")]
    [DisplayName("Dematerialised Indicator")]
    [IsoXmlTag("DmtrlsdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_lJvHNpGhEem-9Y6mq5ZH3Q")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_lJvHN5GhEem-9Y6mq5ZH3Q")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Date to be used as the trade date when securities are settled through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_RUh5YZM4EemKz5EOjv82iQ")]
    [DisplayName("Requested Trade Date")]
    [IsoXmlTag("ReqdTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedTradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_MwNln5EHEem7fvtoGpNpow")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument.
    /// </summary>
    [IsoId("_MwNloZEHEem7fvtoGpNpow")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Specifies if the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_MwNlo5EHEem7fvtoGpNpow")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_MwNlpZEHEem7fvtoGpNpow")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_MwNlp5EHEem7fvtoGpNpow")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<Fees2> Fees { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_MwNlqZEHEem7fvtoGpNpow")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax38> IndividualTax { get; init; } = [];

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    [IsoId("_MwNlq5EHEem7fvtoGpNpow")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms37> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_MwNlrZEHEem7fvtoGpNpow")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public FundSettlementParameters15? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_MwNlr5EHEem7fvtoGpNpow")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_MwNlsZEHEem7fvtoGpNpow")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_MwNls5EHEem7fvtoGpNpow")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }
}
