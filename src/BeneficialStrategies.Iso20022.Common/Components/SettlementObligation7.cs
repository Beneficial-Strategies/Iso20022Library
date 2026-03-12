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
[IsoId("_Bu5zUS9aEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation")]
public partial record SettlementObligation7
{
    #nullable enable
    
    /// <summary>
    /// Last reference given by the settlement platform (this is the central securities depository) to the transaction (non settled instruction).
    /// </summary>
    [IsoId("_CATsYS9aEeS94oXWDaBauA")]
    [DisplayName("CSD Transaction Identification")]
    [IsoXmlTag("CSDTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CSDTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference of the transaction (non settled instruction) given by the central counterparty.
    /// </summary>
    [IsoId("_CATsYy9aEeS94oXWDaBauA")]
    [DisplayName("Central Counterparty Transaction Identification")]
    [IsoXmlTag("CntrlCtrPtyTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CentralCounterpartyTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Original buy-in identification number in case an event causes a generation of a new buy-in identification.
    /// </summary>
    [IsoId("_opTggC9cEeS94oXWDaBauA")]
    [DisplayName("Previous Buy In Identification")]
    [IsoXmlTag("PrvsBuyInId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PreviousBuyInIdentification { get; init; } 
    
    /// <summary>
    /// An account opened by the central counterparty in the name of the clearing member within the account structure, for settlement purposes (gives information about the clearing member account at central counterparty).
    /// </summary>
    [IsoId("_CATsZS9aEeS94oXWDaBauA")]
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_GQby4C9cEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Clearing member account at the central securities depository.
    /// </summary>
    [IsoId("_CATsZy9aEeS94oXWDaBauA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_CATsaS9aEeS94oXWDaBauA")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    
    /// <summary>
    /// Provides the identification for the non-clearing member and account.
    /// </summary>
    [IsoId("_CATsay9aEeS94oXWDaBauA")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    /// <summary>
    /// Provides the intended settlement date of the position.
    /// </summary>
    [IsoId("_CATsbS9aEeS94oXWDaBauA")]
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IntendedSettlementDate { get; init; } 
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_CATsby9aEeS94oXWDaBauA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides the trade date.
    /// </summary>
    [IsoId("_CATscS9aEeS94oXWDaBauA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; } 
    
    /// <summary>
    /// Provides the price of the trade.
    /// </summary>
    [IsoId("_CATscy9aEeS94oXWDaBauA")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public Price4? DealPrice { get; init; } 
    
    /// <summary>
    /// Provides the quantity of the trade.
    /// </summary>
    [IsoId("_CATsdS9aEeS94oXWDaBauA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_CATsdy9aEeS94oXWDaBauA")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification34Choice_? Depository { get; init; } 
    
    /// <summary>
    /// Provides the remaining quantity to be settled.
    /// </summary>
    [IsoId("_CATseS9aEeS94oXWDaBauA")]
    [DisplayName("Remaining Quantity To Be Settled")]
    [IsoXmlTag("RmngQtyToBeSttld")]
    public FinancialInstrumentQuantity1Choice_? RemainingQuantityToBeSettled { get; init; } 
    
    /// <summary>
    /// Provides the amount to be settled.
    /// </summary>
    [IsoId("_CATsey9aEeS94oXWDaBauA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Provides the remaining amount to be settled.
    /// </summary>
    [IsoId("_CATsfS9aEeS94oXWDaBauA")]
    [DisplayName("Remaining Amount To Be Settled")]
    [IsoXmlTag("RmngAmtToBeSttld")]
    public AmountAndDirection27? RemainingAmountToBeSettled { get; init; } 
    
    
    #nullable disable
    
}
