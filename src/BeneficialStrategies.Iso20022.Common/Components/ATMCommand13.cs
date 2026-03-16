// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command to perform on an ATM.
/// </summary>
[IsoId("_YH7bkLV_Eee9tu0oJrSx7A")]
[DisplayName("ATM Command")]
public record ATMCommand13
{
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_YSgT4bV_Eee9tu0oJrSx7A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand6Code Type { get; init; }

    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_YSgT47V_Eee9tu0oJrSx7A")]
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; }

    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_YSgT5bV_Eee9tu0oJrSx7A")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_YSgT57V_Eee9tu0oJrSx7A")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }

    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_YSgT6bV_Eee9tu0oJrSx7A")]
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters1Choice_? CommandParameters { get; init; }
}
