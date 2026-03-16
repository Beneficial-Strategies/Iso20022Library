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
[IsoId("_DbOakYfuEeevKP8c-ilVhA")]
[DisplayName("Deliver Information")]
public record DeliverInformation19
{
    /// <summary>
    /// Party that delivers (transferor) securities to the receiving agent (transferee).
    /// </summary>
    [IsoId("_Dr4syYfuEeevKP8c-ilVhA")]
    [DisplayName("Transferor")]
    [IsoXmlTag("Trfr")]
    public PartyIdentification113? Transferor { get; init; }

    /// <summary>
    /// Account from which the securities are to be delivered.
    /// </summary>
    [IsoId("_Dr4sy4fuEeevKP8c-ilVhA")]
    [DisplayName("Transferor Registered Account")]
    [IsoXmlTag("TrfrRegdAcct")]
    public Account24? TransferorRegisteredAccount { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Dr4szYfuEeevKP8c-ilVhA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary41> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_Dr4sz4fuEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument.
    /// </summary>
    [IsoId("_Dr4s0YfuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Specifies if the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_Dr4s04fuEeevKP8c-ilVhA")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_Dr4s1YfuEeevKP8c-ilVhA")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_d3UGsojREeeiYZ2e3mpBRA")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<Fees1> Fees { get; init; } = [];

    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_d3UGs4jREeeiYZ2e3mpBRA")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public ValueList<Tax34> IndividualTax { get; init; } = [];

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
    [IsoId("_Dr4s34fuEeevKP8c-ilVhA")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms33> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_Dr4s14fuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public DeliveringPartiesAndAccount17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_Dr4s4YfuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_Dr4s44fuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Dr4s5YfuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; }
}
