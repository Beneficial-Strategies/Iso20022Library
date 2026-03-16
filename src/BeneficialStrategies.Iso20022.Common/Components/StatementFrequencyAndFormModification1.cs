// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to statement frequency and form.
/// </summary>
[IsoId("_5U5pQA4rEeK3IMoVvcTkkg")]
[DisplayName("Statement Frequency And Form Modification")]
public record StatementFrequencyAndFormModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_CBMrAA4sEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Specifies the statement frequency, format, delivery address.
    /// </summary>
    [IsoId("_H3PRUA4sEeK3IMoVvcTkkg")]
    [DisplayName("Statement Frequency And Form")]
    [IsoXmlTag("StmtFrqcyAndForm")]
    public required StatementFrequencyAndForm1 StatementFrequencyAndForm { get; init; }
}
