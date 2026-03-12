// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides selected corporate action events message details extracted from the related custodian messages received.
/// </summary>
[IsoId("_1WNFoTL3EeKU9IrkkToqcw_735116614")]
[DisplayName("Related Custodian Message Details SD")]
public partial record RelatedCustodianMessageDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// Reference the CAEV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFojL3EeKU9IrkkToqcw_1873449067")]
    [DisplayName("Received Event Type")]
    [IsoXmlTag("RcvdEvtTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ReceivedEventType { get; init; } 
    
    /// <summary>
    /// Reference the CAMV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFozL3EeKU9IrkkToqcw_-948266421")]
    [DisplayName("Received Mandatory Voluntary Event Type")]
    [IsoXmlTag("RcvdMndtryVlntryEvtTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ReceivedMandatoryVoluntaryEventType { get; init; } 
    
    /// <summary>
    /// Reference the CORP value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFpDL3EeKU9IrkkToqcw_1342648125")]
    [DisplayName("Received Corporate Action Event Identification")]
    [IsoXmlTag("RcvdCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text ReceivedCorporateActionEventIdentification { get; init; } 
    
    /// <summary>
    /// Rate that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFpTL3EeKU9IrkkToqcw_1703993481")]
    [DisplayName("Received Date")]
    [IsoXmlTag("RcvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReceivedDate { get; init; } 
    
    /// <summary>
    /// Time of day that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkDL3EeKU9IrkkToqcw_-1439843261")]
    [DisplayName("Received Time")]
    [IsoXmlTag("RcvdTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ReceivedTime { get; init; } 
    
    /// <summary>
    /// Reference of the ISO15022 MT message type received from the custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkTL3EeKU9IrkkToqcw_519445599")]
    [DisplayName("Inbound ISO Message Type")]
    [IsoXmlTag("InbndISOMT")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText InboundISOMessageType { get; init; } 
    
    /// <summary>
    /// BIC Code of the recipient of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkjL3EeKU9IrkkToqcw_1590634510")]
    [DisplayName("Inbound ISO Message Receiver BIC")]
    [IsoXmlTag("InbndISOMsgRcvrBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier InboundISOMessageReceiverBIC { get; init; } 
    
    /// <summary>
    /// Sender related reference from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkzL3EeKU9IrkkToqcw_-2146269993")]
    [DisplayName("Received Related Reference")]
    [IsoXmlTag("RcvdRltdRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text ReceivedRelatedReference { get; init; } 
    
    /// <summary>
    /// Sender SEME from received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPlDL3EeKU9IrkkToqcw_-1013529054")]
    [DisplayName("Received Sender Message Reference")]
    [IsoXmlTag("RcvdSndrMsgRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text ReceivedSenderMessageReference { get; init; } 
    
    /// <summary>
    /// BIC Code of the sender of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPlTL3EeKU9IrkkToqcw_1794390087")]
    [DisplayName("Inbound ISO Message Sender BIC")]
    [IsoXmlTag("InbndISOMsgSndrBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier InboundISOMessageSenderBIC { get; init; } 
    
    
    #nullable disable
    
}
