// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader45"/>
[IsoId("_QmL0Q9p-Ed-ak6NoX_4Aeg_1336812673")]
[DisplayName("Group Header")]
public partial record GroupHeader45
{
    /// <inheritdoc cref="IGroupHeader45.MessageIdentification"/>
    [IsoId("_QmL0RNp-Ed-ak6NoX_4Aeg_-81214479")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader45.CreationDateTime"/>
    [IsoId("_QmL0Rdp-Ed-ak6NoX_4Aeg_1518554624")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader45.NumberOfTransactions"/>
    [IsoId("_QmL0Rtp-Ed-ak6NoX_4Aeg_-1586925513")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader45.ControlSum"/>
    [IsoId("_QmL0R9p-Ed-ak6NoX_4Aeg_92497717")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader45.InitiatingParty"/>
    [IsoId("_QmL0SNp-Ed-ak6NoX_4Aeg_1040246000")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }
}
