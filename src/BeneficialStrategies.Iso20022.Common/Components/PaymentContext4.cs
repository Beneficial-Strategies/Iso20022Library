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
[IsoId("_MdWikS5yEeKIarvwWcPThw")]
[DisplayName("Payment Context")]
public partial record PaymentContext4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction has been initiated by a card physically present or not.
    /// </summary>
    [IsoId("_MpHGoS5yEeKIarvwWcPThw")]
    [DisplayName("Card Present")]
    [IsoXmlTag("CardPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardPresent { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction has been initiated in presence of the cardholder or not.
    /// </summary>
    [IsoId("_MpHGpS5yEeKIarvwWcPThw")]
    [DisplayName("Cardholder Present")]
    [IsoXmlTag("CrdhldrPres")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardholderPresent { get; init; } 
    
    /// <summary>
    /// On-line or off-line context of the transaction.
    /// </summary>
    [IsoId("_MpHGqS5yEeKIarvwWcPThw")]
    [DisplayName("On Line Context")]
    [IsoXmlTag("OnLineCntxt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OnLineContext { get; init; } 
    
    /// <summary>
    /// Human attendance at the POI location during the transaction.
    /// </summary>
    [IsoId("_MpHGrS5yEeKIarvwWcPThw")]
    [DisplayName("Attendance Context")]
    [IsoXmlTag("AttndncCntxt")]
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_MpHGsS5yEeKIarvwWcPThw")]
    [DisplayName("Transaction Environment")]
    [IsoXmlTag("TxEnvt")]
    public TransactionEnvironment1Code? TransactionEnvironment { get; init; } 
    
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// </summary>
    [IsoId("_MpHGtS5yEeKIarvwWcPThw")]
    [DisplayName("Transaction Channel")]
    [IsoXmlTag("TxChanl")]
    public TransactionChannel1Code? TransactionChannel { get; init; } 
    
    /// <summary>
    /// Indicates whether a message can be sent or not on an attendant display (attendant display present or not).
    /// </summary>
    [IsoId("_MpHGuS5yEeKIarvwWcPThw")]
    [DisplayName("Attendant Message Capable")]
    [IsoXmlTag("AttndntMsgCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AttendantMessageCapable { get; init; } 
    
    /// <summary>
    /// Language used to display messages to the attendant.
    /// </summary>
    [IsoId("_MpHGvS5yEeKIarvwWcPThw")]
    [DisplayName("Attendant Language")]
    [IsoXmlTag("AttndntLang")]
    public ISO2ALanguageCode? AttendantLanguage { get; init; } 
    
    /// <summary>
    /// Entry mode of the card data.
    /// </summary>
    [IsoId("_MpHGwS5yEeKIarvwWcPThw")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading1Code? CardDataEntryMode { get; init; } 
    
    /// <summary>
    /// Indicator of a card entry mode fallback.
    /// </summary>
    [IsoId("_MpHGxS5yEeKIarvwWcPThw")]
    [DisplayName("Fallback Indicator")]
    [IsoXmlTag("FllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FallbackIndicator { get; init; } 
    
    
    #nullable disable
    
}
