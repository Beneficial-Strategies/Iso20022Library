// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader95"/>
[IsoId("_I9mVkcQKEemsic1bQcEtLA")]
[DisplayName("Group Header")]
public partial record GroupHeader95
{
    /// <inheritdoc cref="IGroupHeader95.MessageIdentification"/>
    [IsoId("_JKkakcQKEemsic1bQcEtLA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader95.CreationDateTime"/>
    [IsoId("_JKkak8QKEemsic1bQcEtLA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader95.Authorisation"/>
    [IsoId("_JKkalcQKEemsic1bQcEtLA")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader95.NumberOfTransactions"/>
    [IsoId("_JKkal8QKEemsic1bQcEtLA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader95.ControlSum"/>
    [IsoId("_JKkamcQKEemsic1bQcEtLA")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader95.InitiatingParty"/>
    [IsoId("_JKkam8QKEemsic1bQcEtLA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification135 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader95.ForwardingAgent"/>
    [IsoId("_JKkancQKEemsic1bQcEtLA")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader95.InitiationSource"/>
    [IsoId("_RS7BwMQKEemsic1bQcEtLA")]
    [DisplayName("Initiation Source")]
    [IsoXmlTag("InitnSrc")]
    public PaymentInitiationSource1? InitiationSource { get; init; }
}
