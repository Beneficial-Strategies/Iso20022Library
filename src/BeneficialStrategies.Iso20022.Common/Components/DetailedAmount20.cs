// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_1juMQUS7EeiTBYbU3rWV0A")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount20
{
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_1wqcEUS7EeiTBYbU3rWV0A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DetailAmount2Code Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_1wqcE0S7EeiTBYbU3rWV0A")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    [IsoId("_1wqcFUS7EeiTBYbU3rWV0A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount5 Amount { get; init; } 
    
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("_1wqcF0S7EeiTBYbU3rWV0A")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Label { get; init; } 
    
    
    #nullable disable
    
}
