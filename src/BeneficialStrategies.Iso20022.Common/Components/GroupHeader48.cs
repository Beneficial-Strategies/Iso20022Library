// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader48"/>
[IsoId("_s4XpAFkyEeGeoaLUQk__nA_671246466")]
[DisplayName("Group Header")]
public partial record GroupHeader48
{
    /// <inheritdoc cref="IGroupHeader48.MessageIdentification"/>
    [IsoId("_s4XpAVkyEeGeoaLUQk__nA_368189951")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader48.CreationDateTime"/>
    [IsoId("_s4XpAlkyEeGeoaLUQk__nA_1420912842")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader48.Authorisation"/>
    [IsoId("_s4haAFkyEeGeoaLUQk__nA_310001423")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader48.NumberOfTransactions"/>
    [IsoId("_s4haAVkyEeGeoaLUQk__nA_1189796739")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader48.ControlSum"/>
    [IsoId("_s4haAlkyEeGeoaLUQk__nA_-1463648235")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader48.InitiatingParty"/>
    [IsoId("_s4rLAFkyEeGeoaLUQk__nA_659055683")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader48.ForwardingAgent"/>
    [IsoId("_s4rLAVkyEeGeoaLUQk__nA_-1878074107")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }
}
