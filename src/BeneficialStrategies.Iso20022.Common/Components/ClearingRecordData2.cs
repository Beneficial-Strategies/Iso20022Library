// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used with financial types of messages when third-party clearing is involved.
/// </summary>
[IsoId("_YNv3MZMqEeuleeHpFMMhmQ")]
[DisplayName("Clearing Record Data")]
public partial record ClearingRecordData2
{
    #nullable enable
    
    /// <summary>
    /// Originator of the batch.
    /// </summary>
    [IsoId("_YUL2YZMqEeuleeHpFMMhmQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public Originator1? Originator { get; init; } 
    
    /// <summary>
    /// Institution, final destination of the batch.
    /// </summary>
    [IsoId("_YUL2Y5MqEeuleeHpFMMhmQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public Destination1? Destination { get; init; } 
    
    /// <summary>
    /// Type of clearing of the transaction.
    /// </summary>
    [IsoId("_YUL2ZZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_YUL2Z5MqEeuleeHpFMMhmQ")]
    [DisplayName("Other Clearing Method")]
    [IsoXmlTag("OthrClrMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_YUL2aZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClearingPriority { get; init; } 
    
    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_YUL2a5MqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClearingDate { get; init; } 
    
    /// <summary>
    /// Net amount of clearing.
    /// </summary>
    [IsoId("_YUL2bZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public Amount17? ClearingAmount { get; init; } 
    
    /// <summary>
    /// Interchange reimbursement fee.
    /// </summary>
    [IsoId("_YUL2b5MqEeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount17? InterchangeFee { get; init; } 
    
    /// <summary>
    /// Fee pertaining to the agent.
    /// </summary>
    [IsoId("_YUL2cZMqEeuleeHpFMMhmQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount17? AgentFee { get; init; } 
    
    /// <summary>
    /// Other amounts involved in clearing.
    /// </summary>
    [IsoId("_YUL2c5MqEeuleeHpFMMhmQ")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public OtherAmount4? OtherAmount { get; init; } 
    
    
    #nullable disable
    
}
