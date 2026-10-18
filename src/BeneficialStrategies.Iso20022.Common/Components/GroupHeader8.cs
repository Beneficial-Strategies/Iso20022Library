// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader8"/>
[IsoId("_PtjjLNp-Ed-ak6NoX_4Aeg_1192802893")]
[DisplayName("Group Header")]
public partial record GroupHeader8
{
    /// <inheritdoc cref="IGroupHeader8.MessageIdentification"/>
    [IsoId("_PtjjLdp-Ed-ak6NoX_4Aeg_1192802937")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader8.CreationDateTime"/>
    [IsoId("_PtjjLtp-Ed-ak6NoX_4Aeg_1192802971")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader8.Authorisation"/>
    [IsoId("_PttUINp-Ed-ak6NoX_4Aeg_1192803013")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<string> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader8.BatchBooking"/>
    [IsoId("_PttUIdp-Ed-ak6NoX_4Aeg_1192803048")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader8.NumberOfTransactions"/>
    [IsoId("_PttUItp-Ed-ak6NoX_4Aeg_1192803066")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader8.ControlSum"/>
    [IsoId("_PttUI9p-Ed-ak6NoX_4Aeg_1192803108")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader8.GroupReversal"/>
    [IsoId("_PttUJNp-Ed-ak6NoX_4Aeg_1192803126")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader8.InitiatingParty"/>
    [IsoId("_Pt2eENp-Ed-ak6NoX_4Aeg_-1175099776")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader8.ForwardingAgent"/>
    [IsoId("_Pt2eEdp-Ed-ak6NoX_4Aeg_-1175100054")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader8.DebtorAgent"/>
    [IsoId("_Pt2eEtp-Ed-ak6NoX_4Aeg_-1906141875")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader8.CreditorAgent"/>
    [IsoId("_Pt2eE9p-Ed-ak6NoX_4Aeg_2021264130")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }
}
