// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposited media put in the safe.
/// </summary>
[IsoId("_r3cB8a4QEeWZgJQOa6iKCQ")]
[DisplayName("ATM Deposited Media")]
public record ATMDepositedMedia3
{
    /// <summary>
    /// Type of deposited media.
    /// </summary>
    [IsoId("_sB7as64QEeWZgJQOa6iKCQ")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public required ATMMediaType2Code MediaType { get; init; }

    /// <summary>
    /// Category of deposited media items.
    /// </summary>
    [IsoId("_sB7ata4QEeWZgJQOa6iKCQ")]
    [DisplayName("Media Category")]
    [IsoXmlTag("MdiaCtgy")]
    public ATMMediaType3Code? MediaCategory { get; init; }

    /// <summary>
    /// Media item that are deposited.
    /// </summary>
    [IsoId("_sB7at64QEeWZgJQOa6iKCQ")]
    [DisplayName("Media Items")]
    [IsoXmlTag("MdiaItms")]
    public ValueList<ATMDepositedMedia2> MediaItems { get; init; } = [];
    // ID for the above is _sB7at64QEeWZgJQOa6iKCQ
}
