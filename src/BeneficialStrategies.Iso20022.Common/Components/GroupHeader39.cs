// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader39"/>
[IsoId("_P9NIsdp-Ed-ak6NoX_4Aeg_1208493683")]
[DisplayName("Group Header")]
public partial record GroupHeader39
{
    /// <inheritdoc cref="IGroupHeader39.MessageIdentification"/>
    [IsoId("_P9NIstp-Ed-ak6NoX_4Aeg_1208493715")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader39.CreationDateTime"/>
    [IsoId("_P9NIs9p-Ed-ak6NoX_4Aeg_1208493744")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader39.Authorisation"/>
    [IsoId("_P9NItNp-Ed-ak6NoX_4Aeg_1208493992")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader39.NumberOfTransactions"/>
    [IsoId("_P9NItdp-Ed-ak6NoX_4Aeg_1208494023")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader39.ControlSum"/>
    [IsoId("_P9NIttp-Ed-ak6NoX_4Aeg_1208494024")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader39.InitiatingParty"/>
    [IsoId("_P9NIt9p-Ed-ak6NoX_4Aeg_1208494116")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification32 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader39.ForwardingAgent"/>
    [IsoId("_P9NIuNp-Ed-ak6NoX_4Aeg_1209414117")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; init; }
}
