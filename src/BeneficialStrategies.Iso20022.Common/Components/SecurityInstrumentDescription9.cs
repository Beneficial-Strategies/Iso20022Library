// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_TGvncWXuEeWIGZvepIG8Mg")]
[DisplayName("Security Instrument Description")]
public record SecurityInstrumentDescription9
{
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_TST-QWXuEeWIGZvepIG8Mg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Full name of the financial instrument.
    /// </summary>
    [IsoId("_TST-Q2XuEeWIGZvepIG8Mg")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullName { get; init; }

    /// <summary>
    /// Short name of financial instrument in accordance with ISO 18774.
    /// </summary>
    [IsoId("_TST-RWXuEeWIGZvepIG8Mg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_TST-R2XuEeWIGZvepIG8Mg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public required IsoCFIOct2015Identifier ClassificationType { get; init; }

    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_TST-S2XuEeWIGZvepIG8Mg")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument falls within the definition of commodities derivative under the local regulation.
    /// </summary>
    [IsoId("_TST-TWXuEeWIGZvepIG8Mg")]
    [DisplayName("Commodity Derivative Indicator")]
    [IsoXmlTag("CmmdtyDerivInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator CommodityDerivativeIndicator { get; init; }
}
