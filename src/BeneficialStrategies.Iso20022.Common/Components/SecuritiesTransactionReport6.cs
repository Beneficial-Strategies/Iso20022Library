// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities transaction report.
/// </summary>
[IsoId("_XM1TF526Eeuwmdq0KtnICg")]
[DisplayName("Securities Transaction Report")]
public record SecuritiesTransactionReport6
{
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_XjVHgZ26Eeuwmdq0KtnICg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the entity executing the transaction.
    /// </summary>
    [IsoId("_XjVHg526Eeuwmdq0KtnICg")]
    [DisplayName("Executing Party")]
    [IsoXmlTag("ExctgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ExecutingParty { get; init; }

    /// <summary>
    /// Indicates whether the reporting party is defined as an investment firm under the local regulation or not.
    /// </summary>
    [IsoId("_XjVHhZ26Eeuwmdq0KtnICg")]
    [DisplayName("Investment Party Indicator")]
    [IsoXmlTag("InvstmtPtyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator InvestmentPartyIndicator { get; init; }

    /// <summary>
    /// Entity submitting the transaction report to the competent authority.
    /// </summary>
    [IsoId("_XjVHjZ26Eeuwmdq0KtnICg")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier SubmittingParty { get; init; }

    /// <summary>
    /// Identifies the acquirer of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_XjVHj526Eeuwmdq0KtnICg")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification79 Buyer { get; init; }

    /// <summary>
    /// Identifies the seller of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_XjVHkZ26Eeuwmdq0KtnICg")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification79 Seller { get; init; }

    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    [IsoId("_XjVHk526Eeuwmdq0KtnICg")]
    [DisplayName("Order Transmission")]
    [IsoXmlTag("OrdrTrnsmssn")]
    public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; }

    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [IsoId("_XjVHlZ26Eeuwmdq0KtnICg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required SecuritiesTransaction1 Transaction { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_XjVHl526Eeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrumentAttributes4Choice_ FinancialInstrument { get; init; }

    /// <summary>
    /// Identifies the person or algorithm which is responsible within the reporting party for the investment decision.
    /// </summary>
    [IsoId("_XjVHm526Eeuwmdq0KtnICg")]
    [DisplayName("Investment Decision Person")]
    [IsoXmlTag("InvstmtDcsnPrsn")]
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; }

    /// <summary>
    /// Person or algorithm responsible for the execution of the transaction.
    /// </summary>
    [IsoId("_XjVHnZ26Eeuwmdq0KtnICg")]
    [DisplayName("Executing Person")]
    [IsoXmlTag("ExctgPrsn")]
    public required ExecutingParty1Choice_ ExecutingPerson { get; init; }

    /// <summary>
    /// Provides additional indicators on the reported transaction.
    /// </summary>
    [IsoId("_XjVHn526Eeuwmdq0KtnICg")]
    [DisplayName("Additional Attributes")]
    [IsoXmlTag("AddtlAttrbts")]
    public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; }

    /// <summary>
    /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
    /// </summary>
    [IsoId("_XjVHoZ26Eeuwmdq0KtnICg")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public RecordTechnicalData5? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_XjVHo526Eeuwmdq0KtnICg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
