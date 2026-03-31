// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Command17.
/// </summary>
[IsoId("_gqBxMZ9pEe-nbM0aSPcoiQ")]
[DisplayName("ATM Command17")]
public record ATMCommand17
{
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
    public ATMCommandParameters1Choice_? CommandParameters { get; init; }

    /// <summary>
    /// Date Time.
    /// </summary>
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    public IsoISODateTime? DateTime { get; init; }

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
