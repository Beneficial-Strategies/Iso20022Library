// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Form of protection where a third party guarantees the performance of a financial obligation.
/// </summary>
[IsoId("_-3_WEK_7EeaE9YROwd69hA")]
[DisplayName("Guarantee")]
public partial record Guarantee1
{
    #nullable enable
    
    /// <summary>
    /// Identification of guarantee provider.
    /// </summary>
    [IsoId("_S3vCAK_8EeaE9YROwd69hA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public required PartyIdentification118Choice_ Provider { get; init; } 
    
    /// <summary>
    /// Value of the collateral guarantee.
    /// </summary>
    [IsoId("_WWJpoK_8EeaE9YROwd69hA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
