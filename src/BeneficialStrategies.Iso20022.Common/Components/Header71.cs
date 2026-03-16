// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Header71.
/// </summary>
[IsoId("_6rd9wWxjEe6wzr2RagRERg")]
[DisplayName("Header71")]
public record Header71
{
    /// <summary>
    /// Batch Management Information.
    /// </summary>
    [DisplayName("Batch Management Information")]
    [IsoXmlTag("BtchMgmtInf")]
    public BatchManagementInformation1? BatchManagementInformation { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Exchange Identification.
    /// </summary>
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public IsoMax35Text? ExchangeIdentification { get; init; }

    /// <summary>
    /// Initiating Party.
    /// </summary>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification183 InitiatingParty { get; init; }

    /// <summary>
    /// Message Function.
    /// </summary>
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required ExternalMessageFunction1Code MessageFunction { get; init; }

    /// <summary>
    /// Protocol Version.
    /// </summary>
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    public required IsoMax2048Text ProtocolVersion { get; init; }

    /// <summary>
    /// Recipient Party.
    /// </summary>
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification183? RecipientParty { get; init; }

    /// <summary>
    /// Re Transmission Counter.
    /// </summary>
    [DisplayName("Re Transmission Counter")]
    [IsoXmlTag("ReTrnsmssnCntr")]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; }

    /// <summary>
    /// Traceability.
    /// </summary>
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability10> Traceability { get; init; } = [];

    /// <summary>
    /// Trace Data.
    /// </summary>
    [DisplayName("Trace Data")]
    [IsoXmlTag("TracData")]
    public ValueList<AdditionalData1> TraceData { get; init; } = [];
}
