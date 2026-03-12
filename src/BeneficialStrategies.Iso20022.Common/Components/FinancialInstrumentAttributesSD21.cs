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
[IsoId("_MlVMgw-qEeuE0Pnt-OcNOA")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD21
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_MlVMhQ-qEeuE0Pnt-OcNOA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_MlVMhA-qEeuE0Pnt-OcNOA")]
    [DisplayName("Originating Security Identification")]
    [IsoXmlTag("OrgtgSctyId")]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    
    /// <summary>
    /// Indicates that the underlying security is a money market instrument.
    /// </summary>
    [IsoId("_S5G3sQ-qEeuE0Pnt-OcNOA")]
    [DisplayName("Money Market Instrument Flag")]
    [IsoXmlTag("MnyMktInstrmFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MoneyMarketInstrumentFlag { get; init; } 
    
    
    #nullable disable
    
}
