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
[IsoId("_s2M5UZEBEem7fvtoGpNpow")]
[DisplayName("Transfer")]
public partial record Transfer36
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_tKSS9ZEBEem7fvtoGpNpow")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_tKSS95EBEem7fvtoGpNpow")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_tKSS-ZEBEem7fvtoGpNpow")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Identifies the business process in which the actors are involved. This is important to trigger the right business process, according to the market business model, which may require matching instructions in a CSD environment (double leg process) or not (single leg process).
    /// </summary>
    [IsoId("_tKSS-5EBEem7fvtoGpNpow")]
    [DisplayName("Business Flow Type")]
    [IsoXmlTag("BizFlowTp")]
    public BusinessFlowType1Code? BusinessFlowType { get; init; } 
    
    /// <summary>
    /// Date for which the instructing party requests the transfer.
    /// </summary>
    [IsoId("_tKSS_ZEBEem7fvtoGpNpow")]
    [DisplayName("Requested Transfer Date")]
    [IsoXmlTag("ReqdTrfDt")]
    public DateFormat1Choice_? RequestedTransferDate { get; init; } 
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_tKSS_5EBEem7fvtoGpNpow")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    
    /// <summary>
    /// Date on which the investor signed the transfer order form.
    /// </summary>
    [IsoId("_tKSTAZEBEem7fvtoGpNpow")]
    [DisplayName("Transfer Order Date Form")]
    [IsoXmlTag("TrfOrdrDtForm")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransferOrderDateForm { get; init; } 
    
    /// <summary>
    /// Reason for the transfer.
    /// </summary>
    [IsoId("_tKSTA5EBEem7fvtoGpNpow")]
    [DisplayName("Transfer Reason")]
    [IsoXmlTag("TrfRsn")]
    public TransferReason1Choice_? TransferReason { get; init; } 
    
    /// <summary>
    /// Specifies information about investment plans included in the holding.
    /// </summary>
    [IsoId("_tKSTBZEBEem7fvtoGpNpow")]
    [DisplayName("Holdings Plan Type")]
    [IsoXmlTag("HldgsPlanTp")]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    
    /// <summary>
    /// Information related to the financial instrument to be transferred.
    /// </summary>
    [IsoId("_tKSTB5EBEem7fvtoGpNpow")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument88 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Total quantity of securities to be transferred, expressed as a number of units or a percentage rate.
    /// </summary>
    [IsoId("_tKSTCZEBEem7fvtoGpNpow")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity42Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_tKSTC5EBEem7fvtoGpNpow")]
    [DisplayName("Units Details")]
    [IsoXmlTag("UnitsDtls")]
    public Unit12? UnitsDetails { get; init; } 
    
    /// <summary>
    /// Rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_tKSTDZEBEem7fvtoGpNpow")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; } 
    
    /// <summary>
    /// Original amount paid for the asset at the point of purchase. May also be known as the book cost.
    /// </summary>
    [IsoId("_zVFNoZM4EemKz5EOjv82iQ")]
    [DisplayName("Original Cost")]
    [IsoXmlTag("OrgnlCost")]
    public ActiveCurrencyAnd13DecimalAmount? OriginalCost { get; init; } 
    
    /// <summary>
    /// Value of the security, as booked in the account. Book value is often different from the current market value of the security.
    /// </summary>
    [IsoId("_tKSTD5EBEem7fvtoGpNpow")]
    [DisplayName("Average Price")]
    [IsoXmlTag("AvrgPric")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_tKSTEZEBEem7fvtoGpNpow")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_tKSTE5EBEem7fvtoGpNpow")]
    [DisplayName("Own Account Transfer Indicator")]
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    
    /// <summary>
    /// Additional specific settlement information for the fund.
    /// </summary>
    [IsoId("_tKSTFZEBEem7fvtoGpNpow")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
    /// <summary>
    /// Specifies how the payment of fees and taxes as a result of the transfer is covered, that is, whether by cash or the redemption of units.
    /// </summary>
    [IsoId("_tKSTG5EBEem7fvtoGpNpow")]
    [DisplayName("Transfer Expenses Payment Type")]
    [IsoXmlTag("TrfExpnssPmtTp")]
    public ChargePaymentMethod1Choice_? TransferExpensesPaymentType { get; init; } 
    
    
    #nullable disable
    
}
