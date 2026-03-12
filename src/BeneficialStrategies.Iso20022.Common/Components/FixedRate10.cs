// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fixed rate related information.
/// </summary>
[IsoId("_7j19V1fREeqqKf65rDYWYw")]
[DisplayName("Fixed Rate")]
public partial record FixedRate10
{
    #nullable enable
    
    /// <summary>
    /// Indicates the per annum rate of the fixed leg(s) of an interest rate contract.
    /// </summary>
    [IsoId("_71ixU1fREeqqKf65rDYWYw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public SecuritiesTransactionPrice14Choice_? Rate { get; init; } 
    
    /// <summary>
    /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
    /// </summary>
    [IsoId("_71ixVVfREeqqKf65rDYWYw")]
    [DisplayName("Day Count")]
    [IsoXmlTag("DayCnt")]
    public InterestComputationMethodFormat7? DayCount { get; init; } 
    
    /// <summary>
    /// Specifies the time unit associated with the frequency of payments.
    /// </summary>
    [IsoId("_71ixV1fREeqqKf65rDYWYw")]
    [DisplayName("Payment Frequency")]
    [IsoXmlTag("PmtFrqcy")]
    public InterestRateFrequency3Choice_? PaymentFrequency { get; init; } 
    
    
    #nullable disable
    
}
