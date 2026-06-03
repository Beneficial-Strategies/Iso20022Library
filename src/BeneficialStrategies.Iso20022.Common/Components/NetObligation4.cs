// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the amount, direction and parties involved in a payment obligation between two participants of a netting service.
/// </summary>
[IsoId("d6ff5721-5e8e-447f-8f29-ec05a1a04ae2")]
[DisplayName("Net Obligation4")]
public record NetObligation4
{
    /// <summary>
    /// Unique identification for the obligation.
    /// </summary>
    [IsoId("b00c0dee-d055-4a03-93b5-8d8d03304ded")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    public required IsoMax35Text ObligationIdentification { get; init; }

    /// <summary>
    /// Indicates whether the net obligation is a result of a previously split obligation.
    /// </summary>
    [IsoId("4922d0a3-c10e-492a-814a-53ec74cdeedf")]
    [DisplayName("Previous Split Indicator")]
    [IsoXmlTag("PrvsSpltInd")]
    public IsoTrueFalseIndicator? PreviousSplitIndicator { get; init; }

    /// <summary>
    /// Amount of the obligation.
    /// </summary>
    [IsoId("81f36371-905e-494a-a2c4-64b3659fe942")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Describes the party or netting group (of the participant receiving the report) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("747e3953-9e48-4643-b3b6-43399842a608")]
    [DisplayName("Participant Netting Identification")]
    [IsoXmlTag("PtcptNetgId")]
    public required NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; }

    /// <summary>
    /// Specifies the direction of the obligation.
    /// </summary>
    [IsoId("6f1f3685-ab2d-4272-86f2-2debe59bd292")]
    [DisplayName("Obligation Direction")]
    [IsoXmlTag("OblgtnDrctn")]
    public required PaymentReceipt1Code ObligationDirection { get; init; }

    /// <summary>
    /// Describes the party or netting group (of the counterparty in the obligation) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("e9bee192-7b18-4902-9650-5ab9f80fa759")]
    [DisplayName("Counterparty Netting Identification")]
    [IsoXmlTag("CtrPtyNetgId")]
    public required NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; }

    /// <summary>
    /// Describes the counterparty participant involved in the obligation.
    /// </summary>
    [IsoId("a0940013-0e26-4c0a-9e83-19d95dd52efc")]
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; }

    /// <summary>
    /// Specifies the standard settlement instructions used to issue a payment to the counterparty in order to settle the obligation.
    /// </summary>
    [IsoId("6cbc64b9-0fb1-44dc-8ad9-64f41ddb9a7e")]
    [DisplayName("Counterparty Settlement Instructions")]
    [IsoXmlTag("CtrPtySttlmInstrs")]
    public SettlementParties120? CounterpartySettlementInstructions { get; init; }

    /// <summary>
    /// Specifies the place of clearing for offshore currency trades.
    /// </summary>
    [IsoId("fa8a1029-ae97-4736-806b-a47cd062e3f8")]
    [DisplayName("Payment Clearing Centre")]
    [IsoXmlTag("PmtClrCentr")]
    public CountryCode? PaymentClearingCentre { get; init; }

    /// <summary>
    /// Specifies the settlement method for the net obligation.
    /// </summary>
    [IsoId("_rjfaEHguEfCdoODv2ypKfw")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public ExternalObligationSettlementMethod1Code? SettlementMethod { get; init; }

    /// <summary>
    /// Number of transactions used to calculate the obligation.
    /// </summary>
    [IsoId("6ccf662a-3c32-47f6-b306-42d36e364299")]
    [DisplayName("Transactions Number")]
    [IsoXmlTag("TxsNb")]
    public IsoMax10NumericText? TransactionsNumber { get; init; }

    /// <summary>
    /// Indicates whether the net obligation is split into multiple child obligations.
    /// </summary>
    [IsoId("ed713914-12e6-4523-84a9-d2b480e4b878")]
    [DisplayName("Split Indicator")]
    [IsoXmlTag("SpltInd")]
    public IsoTrueFalseIndicator? SplitIndicator { get; init; }

    /// <summary>
    /// Number of splits for the net obligation.
    /// </summary>
    [IsoId("510ec1b6-5ce0-43d8-9b6c-b77d410daf36")]
    [DisplayName("Total Number Of Splits")]
    [IsoXmlTag("TtlNbOfSplts")]
    public IsoMax15NumericText? TotalNumberOfSplits { get; init; }

    /// <summary>
    /// Details of the split.
    /// </summary>
    [IsoId("2847f29f-7399-4ae4-9f49-10bb9fb84e66")]
    [DisplayName("Split Obligation Data")]
    [IsoXmlTag("SpltOblgtnData")]
    public ValueList<SplitObligationAttributes1> SplitObligationData { get; init; } = [];
}
