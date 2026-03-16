// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the date by when the financial institutiion needs to provide a response.
/// </summary>
[IsoId("_AeNGMEcWEeGlWcsEChp7QA")]
[DisplayName("Due Date")]
public record DueDate1
{
    /// <summary>
    /// Specifies the date when the authority needs the response in situations where the response or part of it will not be given electronically but on paper in manual process.
    /// </summary>
    [IsoId("_C31QHEcWEeGlWcsEChp7QA")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Specifies the reason why the authority needs the information on due date.
    /// </summary>
    [IsoId("_pW-2nEcWEeGlWcsEChp7QA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
