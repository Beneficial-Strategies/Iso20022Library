// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
[IsoId("_LJERUXuxEeS2Z_kGi7H1VQ")]
[DisplayName("Header")]
public partial record Header18
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_LXE4IXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction6Code MessageFunction { get; init; } 
    
    /// <summary>
    /// Identifies the type of process related to the message which has to be reversed.
    /// </summary>
    [IsoId("_ZrQIYHuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Original Message Function")]
    [IsoXmlTag("OrgnlMsgFctn")]
    public required MessageFunction6Code OriginalMessageFunction { get; init; } 
    
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_LXE4I3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; } 
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_LXE4JXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Number of retransmission of the message. Incremented by 1 for each retransmission.
    /// </summary>
    [IsoId("_LXE4J3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_LXE4KXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_LXE4K3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification73 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_LXE4LXuxEeS2Z_kGi7H1VQ")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification73? RecipientParty { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_LXE4L3uxEeS2Z_kGi7H1VQ")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability3? Traceability { get; init; } 
    
    
    #nullable disable
    
}
