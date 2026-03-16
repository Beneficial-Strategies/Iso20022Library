// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_P9NIsdp-Ed-ak6NoX_4Aeg_1208493683")]
[DisplayName("Group Header")]
public record GroupHeader39
{
    /// <summary>
    /// Point to point reference, assigned by the instructing party and sent to the next party in the chain, to unambiguously identify the message.||Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_P9NIstp-Ed-ak6NoX_4Aeg_1208493715")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_P9NIs9p-Ed-ak6NoX_4Aeg_1208493744")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    [IsoId("_P9NItNp-Ed-ak6NoX_4Aeg_1208493992")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_P9NItdp-Ed-ak6NoX_4Aeg_1208494023")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_P9NIttp-Ed-ak6NoX_4Aeg_1208494024")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Party that initiates the payment.||Usage: This can either be the creditor or a party that initiates the direct debit on behalf of the creditor.
    /// </summary>
    [IsoId("_P9NIt9p-Ed-ak6NoX_4Aeg_1208494116")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification32 InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    [IsoId("_P9NIuNp-Ed-ak6NoX_4Aeg_1209414117")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; init; }
}
