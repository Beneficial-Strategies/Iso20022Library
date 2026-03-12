// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_EO4_QUmXEeqmSrLQiFB8FA")]
[DisplayName("Security Instrument Description")]
public partial record SecurityInstrumentDescription17
{
    #nullable enable
    
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_EPy-N0mXEeqmSrLQiFB8FA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; } 
    
    /// <summary>
    /// Full name of the financial instrument.
    /// </summary>
    [IsoId("_EPy-OUmXEeqmSrLQiFB8FA")]
    [DisplayName("Full Name")]
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FullName { get; init; } 
    
    /// <summary>
    /// Short name of financial instrument in accordance with ISO 18774.
    /// </summary>
    [IsoId("_EPy-O0mXEeqmSrLQiFB8FA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification.
    /// </summary>
    [IsoId("_EPy-PUmXEeqmSrLQiFB8FA")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_EPy-QUmXEeqmSrLQiFB8FA")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument falls within the definition of commodities derivative under the local regulation.
    /// Usage: when not present, the indicator in not applicable.
    /// </summary>
    [IsoId("_EPy-Q0mXEeqmSrLQiFB8FA")]
    [DisplayName("Commodity Derivative Indicator")]
    [IsoXmlTag("CmmdtyDerivInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CommodityDerivativeIndicator { get; init; } 
    
    
    #nullable disable
    
}
