// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conditions applicable when the investor is not covered by the &quot;de minimis&quot; exemption.
/// </summary>
[IsoId("_RSI7WNp-Ed-ak6NoX_4Aeg_88957855")]
[DisplayName("De Minimus Not Applicable")]
public partial record DeMinimusNotApplicable1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the restricted person.
    /// </summary>
    [IsoId("_RSI7Wdp-Ed-ak6NoX_4Aeg_491616181")]
    [DisplayName("Restricted Person Reason")]
    [IsoXmlTag("RstrctdPrsnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text RestrictedPersonReason { get; init; } 
    
    
    #nullable disable
    
}
