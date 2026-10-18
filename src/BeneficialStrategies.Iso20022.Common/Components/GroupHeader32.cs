// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader32"/>
[IsoId("_PzqyMtp-Ed-ak6NoX_4Aeg_21204997")]
[DisplayName("Group Header")]
public partial record GroupHeader32
{
    /// <inheritdoc cref="IGroupHeader32.MessageIdentification"/>
    [IsoId("_PzqyM9p-Ed-ak6NoX_4Aeg_21205245")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader32.CreationDateTime"/>
    [IsoId("_PzqyNNp-Ed-ak6NoX_4Aeg_21205275")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader32.Authorisation"/>
    [IsoId("_PzqyNdp-Ed-ak6NoX_4Aeg_21205306")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader32.NumberOfTransactions"/>
    [IsoId("_PzqyNtp-Ed-ak6NoX_4Aeg_21205391")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader32.ControlSum"/>
    [IsoId("_PzqyN9p-Ed-ak6NoX_4Aeg_21205700")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader32.InitiatingParty"/>
    [IsoId("_PzqyONp-Ed-ak6NoX_4Aeg_21205823")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification32 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader32.ForwardingAgent"/>
    [IsoId("_PzqyOdp-Ed-ak6NoX_4Aeg_21205775")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; init; }
}
