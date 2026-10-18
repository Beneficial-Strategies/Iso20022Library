// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader1"/>
[IsoId("_PvMh4tp-Ed-ak6NoX_4Aeg_-279444335")]
[DisplayName("Group Header")]
public partial record GroupHeader1
{
    /// <inheritdoc cref="IGroupHeader1.MessageIdentification"/>
    [IsoId("_PvMh49p-Ed-ak6NoX_4Aeg_907204266")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader1.CreationDateTime"/>
    [IsoId("_PvMh5Np-Ed-ak6NoX_4Aeg_907205059")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader1.Authorisation"/>
    [IsoId("_PvMh5dp-Ed-ak6NoX_4Aeg_907205214")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader1.BatchBooking"/>
    [IsoId("_PvMh5tp-Ed-ak6NoX_4Aeg_908125661")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader1.NumberOfTransactions"/>
    [IsoId("_PvMh59p-Ed-ak6NoX_4Aeg_908127633")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader1.ControlSum"/>
    [IsoId("_PvMh6Np-Ed-ak6NoX_4Aeg_908128667")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader1.Grouping"/>
    [IsoId("_PvMh6dp-Ed-ak6NoX_4Aeg_-279443776")]
    [DisplayName("Grouping")]
    [IsoXmlTag("Grpg")]
    public required Grouping1Code Grouping { get; init; }

    /// <inheritdoc cref="IGroupHeader1.InitiatingParty"/>
    [IsoId("_PvMh6tp-Ed-ak6NoX_4Aeg_-279443740")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification8 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader1.ForwardingAgent"/>
    [IsoId("_PvWS4Np-Ed-ak6NoX_4Aeg_-279443698")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; }
}
