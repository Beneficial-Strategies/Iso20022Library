// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command the ATM must perform.
/// </summary>
[IsoId("_j2e5wV_SEeeD0NpJQPACzA")]
[DisplayName("ATM Command")]
public record ATMCommand10
{
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_j_HRUV_SEeeD0NpJQPACzA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand6Code Type { get; init; }

    /// <summary>
    /// Urgency of the command.
    /// </summary>
    [IsoId("_j_HRU1_SEeeD0NpJQPACzA")]
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; }

    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    [IsoId("_j_HRVV_SEeeD0NpJQPACzA")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_j_HRV1_SEeeD0NpJQPACzA")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }

    /// <summary>
    /// Reason for sending the command.
    /// </summary>
    [IsoId("_j_HRWV_SEeeD0NpJQPACzA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ATMCommandReason1Code? Reason { get; init; }

    /// <summary>
    /// Trace of reasons by the entities in the path from the origin of the command to the ATM.
    /// </summary>
    [IsoId("_j_HRW1_SEeeD0NpJQPACzA")]
    [DisplayName("Trace Reason")]
    [IsoXmlTag("TracRsn")]
    public ATMCommandReason1Code? TraceReason { get; init; }

    /// <summary>
    /// Additional information about the reason to request this command.
    /// </summary>
    [IsoId("_j_HRXV_SEeeD0NpJQPACzA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    [IsoId("_j_HRX1_SEeeD0NpJQPACzA")]
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters3Choice_? CommandParameters { get; init; }
}
