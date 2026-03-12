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
[IsoId("_q9fuQVWWEeeiG_nL4vgKnQ")]
[DisplayName("Header")]
public partial record Header44
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_rIy_UVWWEeeiG_nL4vgKnQ")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction25Code MessageFunction { get; init; } 
    
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_rIy_U1WWEeeiG_nL4vgKnQ")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public required IsoMax2048Text ProtocolVersion { get; init; } 
    
    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    [IsoId("_rIy_VVWWEeeiG_nL4vgKnQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    [IsoId("_rIy_V1WWEeeiG_nL4vgKnQ")]
    [DisplayName("Retransmission Counter")]
    [IsoXmlTag("RtrnsmssnCntr")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? RetransmissionCounter { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    [IsoId("_rIy_WVWWEeeiG_nL4vgKnQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Information related to the batch and the collection to which the message belongs if any.
    /// </summary>
    [IsoId("_rIy_W1WWEeeiG_nL4vgKnQ")]
    [DisplayName("Batch Management Information")]
    [IsoXmlTag("BtchMgmtInf")]
    public BatchManagementInformation1? BatchManagementInformation { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_rIy_XVWWEeeiG_nL4vgKnQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification172 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_rIy_X1WWEeeiG_nL4vgKnQ")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification172? RecipientParty { get; init; } 
    
    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// ISO 8583:93/2003 bit 59
    /// </summary>
    [IsoId("_rIy_YVWWEeeiG_nL4vgKnQ")]
    [DisplayName("Trace Data")]
    [IsoXmlTag("TracData")]
    public AdditionalData1? TraceData { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_rIy_Y1WWEeeiG_nL4vgKnQ")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability7? Traceability { get; init; } 
    
    
    #nullable disable
    
}
