// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the settlement obligation.
/// </summary>
[IsoId("_71U0BS9dEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation")]
public partial record SettlementObligation8
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the settlement obligation.
    /// </summary>
    [IsoId("_8GvUIS9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Obligation Identification")]
    [IsoXmlTag("SttlmOblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SettlementObligationIdentification { get; init; } 
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_8GvUIy9dEeS94oXWDaBauA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Intended settlement date of the position.
    /// </summary>
    [IsoId("_8GvUJS9dEeS94oXWDaBauA")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public required DateFormat11Choice_ IntendedSettlementDate { get; init; } 
    
    /// <summary>
    /// Specifies the quantity related to the settlement obligation.
    /// </summary>
    [IsoId("_8GvUJy9dEeS94oXWDaBauA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Provides the total amount to be settled.
    /// </summary>
    [IsoId("_8GvUKS9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_8GvUKy9dEeS94oXWDaBauA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Provides the trade date.
    /// </summary>
    [IsoId("_8G4eES9dEeS94oXWDaBauA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate3Choice_? TradeDate { get; init; } 
    
    /// <summary>
    /// Identifies the trading capacity of seller.
    /// </summary>
    [IsoId("_8G4eEy9dEeS94oXWDaBauA")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    
    /// <summary>
    /// Specifies the clearing account type.
    /// </summary>
    [IsoId("_8G4eFS9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Account Type")]
    [IsoXmlTag("ClrAcctTp")]
    public ClearingAccountType1Code? ClearingAccountType { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_HYJ-AC9eEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Clearing member account at the central securities depository.
    /// </summary>
    [IsoId("_gQ1HwC9eEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Indicates if the obligation will result in a receive or a delivery of securities.
    /// </summary>
    [IsoId("_8G4eFy9dEeS94oXWDaBauA")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public ReceiveDelivery1Code? SecuritiesMovementType { get; init; } 
    
    /// <summary>
    /// Specifies the amount to be paid under a specific obligation.
    /// </summary>
    [IsoId("_8G4eGS9dEeS94oXWDaBauA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    
    /// <summary>
    /// Provides details on the parties that are part of the settlement chain.
    /// </summary>
    [IsoId("_8G4eGy9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties4Choice_? SettlementParties { get; init; } 
    
    /// <summary>
    /// Provides additional information about the settlement obligation details.
    /// </summary>
    [IsoId("_8G4eHS9dEeS94oXWDaBauA")]
    [DisplayName("Additional Settlement Obligation Details")]
    [IsoXmlTag("AddtlSttlmOblgtnDtls")]
    public SettlementObligation5? AdditionalSettlementObligationDetails { get; init; } 
    
    
    #nullable disable
    
}
