// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_icipEdP6EeK0PPbKncCqzA")]
[DisplayName("Payment Terms")]
public partial record PaymentTerms4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the payment terms using a code or other means.
    /// </summary>
    [IsoId("_cXvtsNP9EeK0PPbKncCqzA")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public required PaymentCodeOrOther1Choice_ PaymentTerms { get; init; } 
    
    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    [IsoId("_YNessNP9EeK0PPbKncCqzA")]
    [DisplayName("Amount Or Percentage")]
    [IsoXmlTag("AmtOrPctg")]
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
    
    #nullable disable
    
}
