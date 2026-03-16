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
[IsoId("_Ew7CTYfuEeevKP8c-ilVhA")]
[DisplayName("Receive Information")]
public record ReceiveInformation19
{
    /// <summary>
    /// Party that receives (transferee) securities from the delivering agent (transferor).
    /// </summary>
    [IsoId("_FBueWYfuEeevKP8c-ilVhA")]
    [DisplayName("Transferee")]
    [IsoXmlTag("Trfee")]
    public PartyIdentification113? Transferee { get; init; }

    /// <summary>
    /// Account into which the securities are to be received.
    /// </summary>
    [IsoId("_FBueW4fuEeevKP8c-ilVhA")]
    [DisplayName("Transferee Registered Account")]
    [IsoXmlTag("TrfeeRegdAcct")]
    public Account24? TransfereeRegisteredAccount { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_FBueXYfuEeevKP8c-ilVhA")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary41? IntermediaryInformation { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_FBueX4fuEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }

    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument.
    /// </summary>
    [IsoId("_FBueYYfuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Specifies if whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_FBueY4fuEeevKP8c-ilVhA")]
    [DisplayName("Stamp Duty")]
    [IsoXmlTag("StmpDty")]
    public StampDutyType2Code? StampDuty { get; init; }

    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_FBueZYfuEeevKP8c-ilVhA")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Fee related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_FBueaYfuEeevKP8c-ilVhA")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public Fees1? Fees { get; init; }

    /// <summary>
    /// Tax related to the transfer of the financial instrument.
    /// </summary>
    [IsoId("_5vh9AYjMEeeiYZ2e3mpBRA")]
    [DisplayName("Individual Tax")]
    [IsoXmlTag("IndvTax")]
    public Tax34? IndividualTax { get; init; }

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
    [IsoId("_FBueb4fuEeevKP8c-ilVhA")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of the transaction.
    /// </summary>
    [IsoId("_FBueZ4fuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Parties Details")]
    [IsoXmlTag("SttlmPtiesDtls")]
    public ReceivingPartiesAndAccount17? SettlementPartiesDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_FBuecYfuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer")]
    [IsoXmlTag("PhysTrf")]
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; }

    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_FBuec4fuEeevKP8c-ilVhA")]
    [DisplayName("Physical Transfer Details")]
    [IsoXmlTag("PhysTrfDtls")]
    public DeliveryParameters4? PhysicalTransferDetails { get; init; }

    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_FBuedYfuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; }
}
