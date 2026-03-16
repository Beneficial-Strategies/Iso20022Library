// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document and type of link.
/// </summary>
[IsoId("_Tg5R59p-Ed-ak6NoX_4Aeg_1248673251")]
[DisplayName("Document Identification")]
public record DocumentIdentification15
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_Tg5R6Np-Ed-ak6NoX_4Aeg_1451913237")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies when this document is to be processed relative to an other referred document.
    /// </summary>
    [IsoId("_Tg5R6dp-Ed-ak6NoX_4Aeg_-859310521")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition1Choice_? LinkageType { get; init; }
}
