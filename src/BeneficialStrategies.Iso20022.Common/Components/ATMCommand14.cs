// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Command14.
/// </summary>
[IsoId("_mzk7cZ8_Ee-nbM0aSPcoiQ")]
[DisplayName("ATM Command14")]
public record ATMCommand14
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax70Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Command Identification.
    /// </summary>
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; }

    /// <summary>
    /// Command Parameters.
    /// </summary>
    [DisplayName("Command Parameters")]
    [IsoXmlTag("CmdParams")]
    public ATMCommandParameters3Choice_? CommandParameters { get; init; }

    /// <summary>
    /// Date Time.
    /// </summary>
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ATMCommandReason1Code? Reason { get; init; }

    /// <summary>
    /// Trace Reason.
    /// </summary>
    [DisplayName("Trace Reason")]
    [IsoXmlTag("TracRsn")]
    public ValueList<ATMCommandReason1Code> TraceReason { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand7Code Type { get; init; }

    /// <summary>
    /// Urgency.
    /// </summary>
    [DisplayName("Urgency")]
    [IsoXmlTag("Urgcy")]
    public required TMSContactLevel2Code Urgency { get; init; }
}
