// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of a maintenance command performed by the ATM.
/// </summary>
[IsoId("_srliUYryEeSvuOJS0mmL0g")]
[DisplayName("ATM Command")]
public record ATMCommand2
{
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_s5gpkYryEeSvuOJS0mmL0g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand2Code Type { get; init; }

    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    [IsoId("_s5gplYryEeSvuOJS0mmL0g")]
    [DisplayName("Required Date Time")]
    [IsoXmlTag("ReqrdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequiredDateTime { get; init; }

    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    [IsoId("_YjsNsIr3EeSvuOJS0mmL0g")]
    [DisplayName("Processed Date Time")]
    [IsoXmlTag("PrcdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ProcessedDateTime { get; init; }

    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_s5gpl4ryEeSvuOJS0mmL0g")]
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }

    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    [IsoId("_4feN0Ir3EeSvuOJS0mmL0g")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult2Code Result { get; init; }

    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    [IsoId("_-cdJoIr3EeSvuOJS0mmL0g")]
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalErrorInformation { get; init; }
}
