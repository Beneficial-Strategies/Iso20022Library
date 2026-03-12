// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary vote type and quantity voted.
/// </summary>
[IsoId("_v_P28K-XEemJ1NnLPsTFaw")]
[DisplayName("Proprietary Vote")]
public partial record ProprietaryVote1
{
    #nullable enable
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_A8QxsK-YEemJ1NnLPsTFaw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required GenericIdentification30 Code { get; init; } 
    
    /// <summary>
    /// Quantity of securities voted.
    /// </summary>
    [IsoId("_EKdzEK-YEemJ1NnLPsTFaw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required QuantityOrCode1Choice_ Quantity { get; init; } 
    
    
    #nullable disable
    
}
