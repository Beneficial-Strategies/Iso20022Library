// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
[IsoId("_TjIGjtp-Ed-ak6NoX_4Aeg_-593608139")]
[DisplayName("Incentive Premium")]
public partial record IncentivePremium2
{
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    [IsoId("_TjR3gNp-Ed-ak6NoX_4Aeg_-593607912")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; } 
    
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    [IsoId("_TjR3gdp-Ed-ak6NoX_4Aeg_-593607904")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required PriceRateOrAmountChoice_ Amount { get; init; } 
    
    /// <summary>
    /// Number of securities giving right to a premium.
    /// </summary>
    [IsoId("_TjR3gtp-Ed-ak6NoX_4Aeg_-593607879")]
    [DisplayName("Per Security")]
    [IsoXmlTag("PerScty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber PerSecurity { get; init; } 
    
    /// <summary>
    /// Number of votes giving right to a premium.
    /// </summary>
    [IsoId("_TjR3g9p-Ed-ak6NoX_4Aeg_-593607844")]
    [DisplayName("Per Vote")]
    [IsoXmlTag("PerVote")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber PerVote { get; init; } 
    
    /// <summary>
    /// Indicates that the premium is given per attendee.
    /// </summary>
    [IsoId("_TjR3hNp-Ed-ak6NoX_4Aeg_-593607819")]
    [DisplayName("Per Attendee")]
    [IsoXmlTag("PerAttndee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PerAttendee { get; init; } 
    
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    [IsoId("_TjR3hdp-Ed-ak6NoX_4Aeg_-593607802")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat3Choice_? PaymentDate { get; init; } 
    
    
    #nullable disable
    
}
