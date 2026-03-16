// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Command15.
/// </summary>
[IsoId("_-Us8QZ9nEe-nbM0aSPcoiQ")]
[DisplayName("ATM Command15")]
public record ATMCommand15
{
    /// <summary>
    /// Additional Error Information.
    /// </summary>
    [DisplayName("Additional Error Information")]
    [IsoXmlTag("AddtlErrInf")]
    public IsoMax140Text? AdditionalErrorInformation { get; init; }

    /// <summary>
    /// Command Identification.
    /// </summary>
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }

    /// <summary>
    /// Processed Date Time.
    /// </summary>
    [DisplayName("Processed Date Time")]
    [IsoXmlTag("PrcdDtTm")]
    public required IsoISODateTime ProcessedDateTime { get; init; }

    /// <summary>
    /// Required Date Time.
    /// </summary>
    [DisplayName("Required Date Time")]
    [IsoXmlTag("ReqrdDtTm")]
    public IsoISODateTime? RequiredDateTime { get; init; }

    /// <summary>
    /// Result.
    /// </summary>
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required TerminalManagementActionResult2Code Result { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand7Code Type { get; init; }
}
