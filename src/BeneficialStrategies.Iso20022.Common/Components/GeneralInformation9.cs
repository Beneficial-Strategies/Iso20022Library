// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General Information9.
/// </summary>
[IsoId("_nhBqoUj4Ee-KhcStGV4xTg")]
[DisplayName("General Information9")]
public record GeneralInformation9
{
    /// <summary>
    /// Agreement Details.
    /// </summary>
    [DisplayName("Agreement Details")]
    [IsoXmlTag("AgrmtDtls")]
    public AgreementConditions1? AgreementDetails { get; init; }

    /// <summary>
    /// Block Indicator.
    /// </summary>
    [DisplayName("Block Indicator")]
    [IsoXmlTag("BlckInd")]
    public IsoYesNoIndicator? BlockIndicator { get; init; }

    /// <summary>
    /// Broker Identification.
    /// </summary>
    [DisplayName("Broker Identification")]
    [IsoXmlTag("BrkrId")]
    public PartyIdentification242Choice_? BrokerIdentification { get; init; }

    /// <summary>
    /// Brokers Commission.
    /// </summary>
    [DisplayName("Brokers Commission")]
    [IsoXmlTag("BrkrsComssn")]
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; }

    /// <summary>
    /// Brokers Reference.
    /// </summary>
    [DisplayName("Brokers Reference")]
    [IsoXmlTag("BrkrsRef")]
    public IsoMax35Text? BrokersReference { get; init; }

    /// <summary>
    /// Calculation Agent.
    /// </summary>
    [DisplayName("Calculation Agent")]
    [IsoXmlTag("ClctnAgt")]
    public CalculationAgent1Choice_? CalculationAgent { get; init; }

    /// <summary>
    /// Contact Information.
    /// </summary>
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactInformation1? ContactInformation { get; init; }

    /// <summary>
    /// Counterparty Reference.
    /// </summary>
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public IsoMax35Text? CounterpartyReference { get; init; }

    /// <summary>
    /// Dealing Branch Counterparty Side.
    /// </summary>
    [DisplayName("Dealing Branch Counterparty Side")]
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    public PartyIdentification242Choice_? DealingBranchCounterpartySide { get; init; }

    /// <summary>
    /// Dealing Branch Trading Side.
    /// </summary>
    [DisplayName("Dealing Branch Trading Side")]
    [IsoXmlTag("DealgBrnchTradgSd")]
    public PartyIdentification242Choice_? DealingBranchTradingSide { get; init; }

    /// <summary>
    /// Dealing Method.
    /// </summary>
    [DisplayName("Dealing Method")]
    [IsoXmlTag("DealgMtd")]
    public Trading1MethodCode? DealingMethod { get; init; }

    /// <summary>
    /// Definitions Year.
    /// </summary>
    [DisplayName("Definitions Year")]
    [IsoXmlTag("DefsYr")]
    public IsoISOYear? DefinitionsYear { get; init; }

    /// <summary>
    /// Payment Clearing Centre.
    /// </summary>
    [DisplayName("Payment Clearing Centre")]
    [IsoXmlTag("PmtClrCentr")]
    public CountryCode? PaymentClearingCentre { get; init; }

    /// <summary>
    /// Related Trade Reference.
    /// </summary>
    [DisplayName("Related Trade Reference")]
    [IsoXmlTag("RltdTradRef")]
    public IsoMax35Text? RelatedTradeReference { get; init; }

    /// <summary>
    /// Sender To Receiver Information.
    /// </summary>
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    public IsoMax210Text? SenderToReceiverInformation { get; init; }
}
