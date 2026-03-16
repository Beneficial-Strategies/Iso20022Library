// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary information about the sale
/// </summary>
[IsoId("_rYJ6FvJoEeiJn9rM2Znz2w")]
[DisplayName("Sale Summary")]
public record SaleSummary1
{
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_rYJ6G_JoEeiJn9rM2Znz2w")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains loyalty programme information.
    /// </summary>
    [IsoId("_WbrOMPJqEeiJn9rM2Znz2w")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Contains adjustment details of the transaction (for example, percentage, adjustment amount, etc.).
    /// </summary>
    [IsoId("_rYJ6GfJoEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment9? Adjustment { get; init; }
}
