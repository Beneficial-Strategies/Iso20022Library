// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment context in which the transaction is performed.
/// </summary>
[IsoId("_9XFDUTJ1EeOqyZqt0rCZLg")]
[DisplayName("Payment Context")]
public partial record PaymentContext7
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_9mGWwTJ1EeOqyZqt0rCZLg")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_9mGWwzJ1EeOqyZqt0rCZLg")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [IsoId("_9mGWxTJ1EeOqyZqt0rCZLg")]
    [DisplayName("On Line Context")]
    [IsoXmlTag("OnLineCntxt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during the transaction.
    /// </summary>
    [IsoId("_9mGWxzJ1EeOqyZqt0rCZLg")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_9mGWyTJ1EeOqyZqt0rCZLg")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_9mGWyzJ1EeOqyZqt0rCZLg")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel1Code? TransactionChannel { get; init; } 
    
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [IsoId("_9mGWzTJ1EeOqyZqt0rCZLg")]
    [DisplayName("Attendant Message Capable")]
    [IsoXmlTag("AttndntMsgCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    
    /// <summary>
    /// Language used to display messages to the attendant.
    /// </summary>
    [IsoId("_9mGWzzJ1EeOqyZqt0rCZLg")]
    [DisplayName("Attendant Language")]
    [IsoXmlTag("AttndntLang")]
    public ISO2ALanguageCode? AttendantLanguage { get; init; } 
    
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_9mGW0TJ1EeOqyZqt0rCZLg")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading1Code? CardDataEntryMode { get; init; } 
    
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_9mGW0zJ1EeOqyZqt0rCZLg")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FallbackIndicator { get; init; } 
    
    /// <summary>
    /// Payment options the card acceptor can support.
    /// </summary>
    [IsoId("_H7GbsDJ2EeOqyZqt0rCZLg")]
    [DisplayName("Supported Option")]
    [IsoXmlTag("SpprtdOptn")]
    public SupportedPaymentOption1Code? SupportedOption { get; init; } 
    
    
    #nullable disable
    
}
