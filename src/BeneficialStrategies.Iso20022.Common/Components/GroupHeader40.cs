// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader40"/>
[IsoId("_PzqyOtp-Ed-ak6NoX_4Aeg_836274708")]
[DisplayName("Group Header")]
public partial record GroupHeader40
{
    /// <inheritdoc cref="IGroupHeader40.MessageIdentification"/>
    [IsoId("_Pzz8INp-Ed-ak6NoX_4Aeg_836274710")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader40.CreationDateTime"/>
    [IsoId("_Pzz8Idp-Ed-ak6NoX_4Aeg_836274739")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader40.Authorisation"/>
    [IsoId("_Pzz8Itp-Ed-ak6NoX_4Aeg_836274986")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader40.BatchBooking"/>
    [IsoId("_Pzz8I9p-Ed-ak6NoX_4Aeg_836275017")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IGroupHeader40.NumberOfTransactions"/>
    [IsoId("_Pzz8JNp-Ed-ak6NoX_4Aeg_836275048")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader40.ControlSum"/>
    [IsoId("_Pzz8Jdp-Ed-ak6NoX_4Aeg_836275078")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader40.GroupReversal"/>
    [IsoId("_Pzz8Jtp-Ed-ak6NoX_4Aeg_836275109")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader40.InitiatingParty"/>
    [IsoId("_Pzz8J9p-Ed-ak6NoX_4Aeg_836275473")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader40.ForwardingAgent"/>
    [IsoId("_Pzz8KNp-Ed-ak6NoX_4Aeg_836275504")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader40.DebtorAgent"/>
    [IsoId("_Pz9tINp-Ed-ak6NoX_4Aeg_836275419")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader40.CreditorAgent"/>
    [IsoId("_Pz9tIdp-Ed-ak6NoX_4Aeg_836275403")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }
}
