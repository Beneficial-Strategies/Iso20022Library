// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_1esTQDL3EeKU9IrkkToqcw_-24344462")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD7
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1esTQTL3EeKU9IrkkToqcw_1068806572")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Name of the issuer.
    /// </summary>
    [IsoId("_1esTQjL3EeKU9IrkkToqcw_-811499068")]
    [DisplayName("Issuer Description")]
    [IsoXmlTag("IssrDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IssuerDescription { get; init; } 
    
    /// <summary>
    /// Country of incorporation of the issuer.
    /// </summary>
    [IsoId("_1esTQzL3EeKU9IrkkToqcw_88402598")]
    [DisplayName("Country Of Incorporation")]
    [IsoXmlTag("CtryOfIncorprtn")]
    public CountryCode? CountryOfIncorporation { get; init; } 
    
    /// <summary>
    /// Indicates if the stock exchange associated to place of listing code is primary.
    /// </summary>
    [IsoId("_1esTRDL3EeKU9IrkkToqcw_-88358462")]
    [DisplayName("Primary Exchange Flag")]
    [IsoXmlTag("PmryXchgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PrimaryExchangeFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the event has been registered with US Securities Exchange Commission (SEC).
    /// </summary>
    [IsoId("_1esTRTL3EeKU9IrkkToqcw_-809173124")]
    [DisplayName("SEC Registered Flag")]
    [IsoXmlTag("SECRegdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SECRegisteredFlag { get; init; } 
    
    
    #nullable disable
    
}
