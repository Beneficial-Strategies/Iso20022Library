// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
/// </summary>
[IsoId("_IJeUYa42EeWpsoxRhdX-8A")]
[DisplayName("Header")]
public record Header33
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_IUDMsa42EeWpsoxRhdX-8A")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required ATMMessageFunction2 MessageFunction { get; init; }

    /// <summary>
    /// Version of the ATM protocol specifications.
    /// </summary>
    [IsoId("_IUDMs642EeWpsoxRhdX-8A")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text ProtocolVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_IUDMta42EeWpsoxRhdX-8A")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_IUDMt642EeWpsoxRhdX-8A")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_IUDMua42EeWpsoxRhdX-8A")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_IUDMu642EeWpsoxRhdX-8A")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientParty { get; init; }

    /// <summary>
    /// State of the sender of the message inside the process flow.
    /// </summary>
    [IsoId("_IUDMva42EeWpsoxRhdX-8A")]
    [DisplayName("Process State")]
    [IsoXmlTag("PrcStat")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessState { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_IUDMv642EeWpsoxRhdX-8A")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability4> Traceability { get; init; } = [];
}
