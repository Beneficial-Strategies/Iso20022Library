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
[IsoId("_s4XpAFkyEeGeoaLUQk__nA_671246466")]
[DisplayName("Group Header")]
public record GroupHeader48
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_s4XpAVkyEeGeoaLUQk__nA_368189951")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s4XpAlkyEeGeoaLUQk__nA_1420912842")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_s4haAFkyEeGeoaLUQk__nA_310001423")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_s4haAVkyEeGeoaLUQk__nA_1189796739")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_s4haAlkyEeGeoaLUQk__nA_-1463648235")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Party that initiates the payment.||Usage: This can either be the debtor or the party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_s4rLAFkyEeGeoaLUQk__nA_659055683")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    [IsoId("_s4rLAVkyEeGeoaLUQk__nA_-1878074107")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }
}
