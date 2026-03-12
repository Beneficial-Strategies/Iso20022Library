// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms by means of a code and a period.
/// </summary>
[IsoId("_H54EIRVgEeOrY9qSHVspCA")]
[DisplayName("Payment Period")]
public partial record PaymentPeriod4
{
    #nullable enable
    
    /// <summary>
    /// Code for the payment.
    /// </summary>
    [IsoId("_IRIGgRVgEeOrY9qSHVspCA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PaymentTime4Code Code { get; init; } 
    
    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    [IsoId("_IRIGgxVgEeOrY9qSHVspCA")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDays { get; init; } 
    
    
    #nullable disable
    
}
