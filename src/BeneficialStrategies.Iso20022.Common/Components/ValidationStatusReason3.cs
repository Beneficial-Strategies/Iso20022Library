// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Validation Status Reason3.
/// </summary>
[IsoId("_3D4kmzEyEe6g-ffJsqGiSA")]
[DisplayName("Validation Status Reason3")]
public partial record ValidationStatusReason3
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Originator.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; } 

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; } 

    /// <summary>
    /// Validation Rule.
    /// </summary>
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public ValueList<GenericValidationRuleIdentification1> ValidationRule { get; init; } = [];

    
    #nullable disable
    
}
