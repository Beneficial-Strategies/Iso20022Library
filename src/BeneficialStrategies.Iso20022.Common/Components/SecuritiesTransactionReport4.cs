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
[IsoId("_J-kCF4G-EeaalK9UbuVGFw")]
[DisplayName("Securities Transaction Report")]
public record SecuritiesTransactionReport4
{
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_KJ36MYG-EeaalK9UbuVGFw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the entity executing the transaction.
    /// </summary>
    [IsoId("_KJ36M4G-EeaalK9UbuVGFw")]
    [DisplayName("Executing Party")]
    [IsoXmlTag("ExctgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ExecutingParty { get; init; }

    /// <summary>
    /// Indicates whether the reporting party is defined as an investment firm under the local regulation or not.
    /// </summary>
    [IsoId("_KJ36NYG-EeaalK9UbuVGFw")]
    [DisplayName("Investment Party Indicator")]
    [IsoXmlTag("InvstmtPtyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator InvestmentPartyIndicator { get; init; }

    /// <summary>
    /// Entity submitting the transaction report to the competent authority.
    /// </summary>
    [IsoId("_KJ36PYG-EeaalK9UbuVGFw")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier SubmittingParty { get; init; }

    /// <summary>
    /// Identifies the acquirer of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_KJ36P4G-EeaalK9UbuVGFw")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification79 Buyer { get; init; }

    /// <summary>
    /// Identifies the seller of the legal title to the financial instrument.
    /// </summary>
    [IsoId("_KJ36QYG-EeaalK9UbuVGFw")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification79 Seller { get; init; }

    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    [IsoId("_KJ36Q4G-EeaalK9UbuVGFw")]
    [DisplayName("Order Transmission")]
    [IsoXmlTag("OrdrTrnsmssn")]
    public required SecuritiesTransactionTransmission2 OrderTransmission { get; init; }

    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [IsoId("_KJ36RYG-EeaalK9UbuVGFw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required SecuritiesTransaction1 Transaction { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_KJ36R4G-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrumentAttributes3Choice_ FinancialInstrument { get; init; }

    /// <summary>
    /// Identifies the person or algorithm which is responsible within the reporting party for the investment decision.
    /// </summary>
    [IsoId("_KJ36S4G-EeaalK9UbuVGFw")]
    [DisplayName("Investment Decision Person")]
    [IsoXmlTag("InvstmtDcsnPrsn")]
    public InvestmentParty1Choice_? InvestmentDecisionPerson { get; init; }

    /// <summary>
    /// Person or algorithm responsible for the execution of the transaction.
    /// </summary>
    [IsoId("_KJ36TYG-EeaalK9UbuVGFw")]
    [DisplayName("Executing Person")]
    [IsoXmlTag("ExctgPrsn")]
    public required ExecutingParty1Choice_ ExecutingPerson { get; init; }

    /// <summary>
    /// Provides additional indicators on the reported transaction.
    /// </summary>
    [IsoId("_KJ36T4G-EeaalK9UbuVGFw")]
    [DisplayName("Additional Attributes")]
    [IsoXmlTag("AddtlAttrbts")]
    public required SecuritiesTransactionIndicator2 AdditionalAttributes { get; init; }

    /// <summary>
    /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
    /// </summary>
    [IsoId("_KJ36UYG-EeaalK9UbuVGFw")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public RecordTechnicalData1? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_KJ36U4G-EeaalK9UbuVGFw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
