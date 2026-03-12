// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
/// </summary>
[IsoId("_RdTnAYqNEeSRT5rEzcAHEw")]
[DisplayName("Header")]
public partial record Header21
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_RpheEYqNEeSRT5rEzcAHEw")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required ATMMessageFunction1 MessageFunction { get; init; } 
    
    /// <summary>
    /// Version of the ATM protocol specifications.
    /// </summary>
    [IsoId("_RpheE4qNEeSRT5rEzcAHEw")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; } 
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_RpheFYqNEeSRT5rEzcAHEw")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    
    /// <summary>
    ///  Retransmission counter of this advice, 0 for the first transmission.
    /// </summary>
    [IsoId("_eAcXcIqNEeSRT5rEzcAHEw")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ReTransmissionCounter { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_RpheF4qNEeSRT5rEzcAHEw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_RpheGYqNEeSRT5rEzcAHEw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text InitiatingParty { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_RpheG4qNEeSRT5rEzcAHEw")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RecipientParty { get; init; } 
    
    /// <summary>
    /// State of the sender of the message inside the process flow.
    /// </summary>
    [IsoId("_oThw0IqNEeSRT5rEzcAHEw")]
    [DisplayName("Process State")]
    [IsoXmlTag("PrcStat")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcessState { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_RpheHYqNEeSRT5rEzcAHEw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability4? Traceability { get; init; } 
    
    
    #nullable disable
    
}
