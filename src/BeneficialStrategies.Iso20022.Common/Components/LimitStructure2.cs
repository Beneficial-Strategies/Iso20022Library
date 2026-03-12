// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_OJv2AZ-YEee28J7y9KlTWg")]
[DisplayName("Limit Structure")]
public partial record LimitStructure2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_OUjX05-YEee28J7y9KlTWg")]
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification1Choice_ LimitIdentification { get; init; } 
    
    /// <summary>
    /// New limit values.
    /// </summary>
    [IsoId("_OUjX1Z-YEee28J7y9KlTWg")]
    [DisplayName("New Limit Value Set")]
    [IsoXmlTag("NewLmtValSet")]
    public required Limit8 NewLimitValueSet { get; init; } 
    
    
    #nullable disable
    
}
