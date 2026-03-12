// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_Dr4s54fuEeevKP8c-ilVhA")]
[DisplayName("Transfer")]
public partial record Transfer35
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_D9Jb6YfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_D9Jb64fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_D9Jb7YfuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_D9Jb74fuEeevKP8c-ilVhA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference7? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_D9Jb8YfuEeevKP8c-ilVhA")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_D9Jb9YfuEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_D9Jb84fuEeevKP8c-ilVhA")]
    [DisplayName("Effective Transfer Date")]
    [IsoXmlTag("FctvTrfDt")]
    public required DateAndDateTime2Choice_ EffectiveTransferDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_D9Jb94fuEeevKP8c-ilVhA")]
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveSettlementDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the transaction is completed and cleared, that is, securities are delivered.
    /// </summary>
    [IsoId("_D9Jb-YfuEeevKP8c-ilVhA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public DateAndDateTime2Choice_? TradeDate { get; init; } 
    
    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("_D9Jb-4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; } 
    
    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    [IsoId("_D9Jb_YfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice_? TransferReason { get; init; } 
    
    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("_D9Jb_4fuEeevKP8c-ilVhA")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = new SimpleValueList<HoldingsPlanType1Code>(){};
    
    /// <summary>
    /// Information related to the financial instrument transferred.
    /// </summary>
    [IsoId("_D9JcAYfuEeevKP8c-ilVhA")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument63 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Number of units transferred.
    /// </summary>
    [IsoId("_D9JcA4fuEeevKP8c-ilVhA")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Quantity of securities transferred as a percentage of the holding.
    /// </summary>
    [IsoId("_D9JcB4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Rate")]
    [IsoXmlTag("TrfRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TransferRate { get; init; } 
    
    /// <summary>
    /// Breakdown of units transferred.
    /// </summary>
    [IsoId("_D9JcBYfuEeevKP8c-ilVhA")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit8? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_D9JcCYfuEeevKP8c-ilVhA")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Weighted average price of the units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_D9JcC4fuEeevKP8c-ilVhA")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    /// <summary>
    /// Weighted average price of the units in the account after the transfer was executed.
    /// </summary>
    [IsoId("_D9JcDYfuEeevKP8c-ilVhA")]
    [DisplayName("New Average Price")]
    [IsoXmlTag("NewAvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? NewAveragePrice { get; init; } 
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account before the transfer was executed.
    /// </summary>
    [IsoId("_D9JcD4fuEeevKP8c-ilVhA")]
    [DisplayName("Average Date")]
    [IsoXmlTag("AvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AverageDate { get; init; } 
    
    /// <summary>
    /// Trade date of the average weighted data of units in the account after the transfer was executed.
    /// </summary>
    [IsoId("_D9JcEYfuEeevKP8c-ilVhA")]
    [DisplayName("New Average Date")]
    [IsoXmlTag("NewAvrgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewAverageDate { get; init; } 
    
    /// <summary>
    /// Currency used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_D9JcE4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_D9JcFYfuEeevKP8c-ilVhA")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_D9JcF4fuEeevKP8c-ilVhA")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_D9JcGYfuEeevKP8c-ilVhA")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount156? ReceivingAgentDetails { get; init; } 
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_D9JcG4fuEeevKP8c-ilVhA")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; } 
    
    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_D9JcHYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    
    
    #nullable disable
    
}
