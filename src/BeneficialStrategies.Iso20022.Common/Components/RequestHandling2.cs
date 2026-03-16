// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Explains the status of the related request.
/// </summary>
[IsoId("_prPCsVhAEeiv7OYKCzUSAg")]
[DisplayName("Request Handling")]
public record RequestHandling2
{
    /// <summary>
    /// Specifies the status of the request, for example the result of the schema validation or a business processing result/error.
    /// </summary>
    [IsoId("_p2eCUVhAEeiv7OYKCzUSAg")]
    [DisplayName("Status Code")]
    [IsoXmlTag("StsCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText StatusCode { get; init; }

    /// <summary>
    /// Date and time when the status was generated.
    /// </summary>
    [IsoId("_lOq7UFhBEeiv7OYKCzUSAg")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; }

    /// <summary>
    /// Description of the status, in free format text.
    /// </summary>
    [IsoId("_p2eCU1hAEeiv7OYKCzUSAg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }
}
