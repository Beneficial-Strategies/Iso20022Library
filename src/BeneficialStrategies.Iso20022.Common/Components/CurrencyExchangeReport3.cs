// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on currency exchange information or on a business error.
/// </summary>
[IsoId("_77JeRqMgEeCJ6YNENx4h-w_928566132")]
[DisplayName("Currency Exchange Report")]
public record CurrencyExchangeReport3
{
    /// <summary>
    /// Source and target currencies for which information is request.
    /// </summary>
    [IsoId("_77JeR6MgEeCJ6YNENx4h-w_-360463959")]
    [DisplayName("Currency Reference")]
    [IsoXmlTag("CcyRef")]
    public required CurrencySourceTarget1 CurrencyReference { get; init; }

    /// <summary>
    /// Reports either on currency exchange information or on a business error.
    /// </summary>
    [IsoId("_77TPQKMgEeCJ6YNENx4h-w_-1732232506")]
    [DisplayName("Currency Exchange Or Error")]
    [IsoXmlTag("CcyXchgOrErr")]
    public required ExchangeRateReportOrError2Choice_ CurrencyExchangeOrError { get; init; }
}
