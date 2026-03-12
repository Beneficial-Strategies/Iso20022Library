// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Floating rate related information.
/// </summary>
[IsoId("_GPrWwQ1IEeqV4s5SpzR1dQ")]
[DisplayName("Floating Rate")]
public partial record FloatingRate5
{
    #nullable enable
    
    /// <summary>
    /// Indication of the floating rate used.
    /// </summary>
    [IsoId("_GQZvgw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public FloatingRateIdentification3Choice_? Rate { get; init; } 
    
    /// <summary>
    /// Information related to reference period.
    /// </summary>
    [IsoId("_GQZvhQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Reference Period")]
    [IsoXmlTag("RefPrd")]
    public InterestRateContractTerm3? ReferencePeriod { get; init; } 
    
    /// <summary>
    /// Spread expressed as a rate.
    /// </summary>
    [IsoId("_GQZvhw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Spread { get; init; } 
    
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    [IsoId("_GQZviQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
    
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    [IsoId("_GQZviw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Reset Frequency")]
    [IsoXmlTag("RstFrqcy")]
    public InterestRateFrequency2Choice_? ResetFrequency { get; init; } 
    
    
    #nullable disable
    
}
