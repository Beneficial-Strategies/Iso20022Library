// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader55"/>
[IsoId("_s8ZNYFkyEeGeoaLUQk__nA_1169801670")]
[DisplayName("Group Header")]
public partial record GroupHeader55
{
    /// <inheritdoc cref="IGroupHeader55.MessageIdentification"/>
    [IsoId("_s8ZNYVkyEeGeoaLUQk__nA_1202961439")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader55.CreationDateTime"/>
    [IsoId("_s8ZNYlkyEeGeoaLUQk__nA_2095996899")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader55.Authorisation"/>
    [IsoId("_s8ZNY1kyEeGeoaLUQk__nA_215691259")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader55.NumberOfTransactions"/>
    [IsoId("_s8ZNZFkyEeGeoaLUQk__nA_-895220160")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader55.ControlSum"/>
    [IsoId("_s8i-YFkyEeGeoaLUQk__nA_588344194")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader55.InitiatingParty"/>
    [IsoId("_s8i-YVkyEeGeoaLUQk__nA_-1583919184")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader55.ForwardingAgent"/>
    [IsoId("_s8i-YlkyEeGeoaLUQk__nA_491173507")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }
}
