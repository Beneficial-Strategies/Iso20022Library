// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_96iMRHltEeG7BsjMvd1mEw_-1196515553")]
[DisplayName("Document")]
public record Document8
{
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_96iMRXltEeG7BsjMvd1mEw_891740374")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PresentationDocumentFormat1Choice_ Type { get; init; }

    /// <summary>
    /// Wording for document.
    /// </summary>
    [IsoId("_96iMRnltEeG7BsjMvd1mEw_1367698828")]
    [DisplayName("Wording")]
    [IsoXmlTag("Wrdg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? Wording { get; init; }

    /// <summary>
    /// Details related to an electronic presentation.
    /// </summary>
    [IsoId("_96r9QHltEeG7BsjMvd1mEw_-701738172")]
    [DisplayName("Electronic Details")]
    [IsoXmlTag("ElctrncDtls")]
    public Presentation3? ElectronicDetails { get; init; }
}
