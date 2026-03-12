// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common identification of a service to be billed.
/// </summary>
[IsoId("_6PNc1ZqlEeGSON8vddiWzQ_-1466437811")]
[DisplayName("Billing Service Common Identification")]
public partial record BillingServiceCommonIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Defines the issuer of the common code, such as &quot;AFP&quot;.
    /// </summary>
    [IsoId("_6PNc1pqlEeGSON8vddiWzQ_-1580276877")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text Issuer { get; init; } 
    
    /// <summary>
    /// Standard reference code used to uniquely identify this service across financial institutions. This is not the financial institution’s internal bank service identification.
    /// </summary>
    [IsoId("_6PNc15qlEeGSON8vddiWzQ_1717618066")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public required IsoMax8Text Identification { get; init; } 
    
    
    #nullable disable
    
}
