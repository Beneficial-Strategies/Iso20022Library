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
[IsoId("_U9pdIFBDEeedyPuM0kK2EQ")]
[DisplayName("Clearing Record Data")]
public partial record ClearingRecordData1
{
    #nullable enable
    
    /// <summary>
    /// Originator of the batch.
    /// </summary>
    [IsoId("_picW4FBDEeedyPuM0kK2EQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public Originator1? Originator { get; init; } 
    
    /// <summary>
    /// Institution, final destination of the batch.
    /// </summary>
    [IsoId("_7T93wFBDEeedyPuM0kK2EQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public Destination1? Destination { get; init; } 
    
    /// <summary>
    /// Type of clearing of the transaction.
    /// </summary>
    [IsoId("_DUCssFBEEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Method")]
    [IsoXmlTag("ClrMtd")]
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_b1KSEFBEEeedyPuM0kK2EQ")]
    [DisplayName("Other Clearing Method")]
    [IsoXmlTag("OthrClrMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_hN3cIFBEEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Priority")]
    [IsoXmlTag("ClrPrty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClearingPriority { get; init; } 
    
    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_mnnIAFBEEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Date")]
    [IsoXmlTag("ClrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClearingDate { get; init; } 
    
    /// <summary>
    /// Net amount of clearing.
    /// </summary>
    [IsoId("_wBtD4FBEEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Amount")]
    [IsoXmlTag("ClrAmt")]
    public Amount14? ClearingAmount { get; init; } 
    
    /// <summary>
    /// Interchange reimbursement fee.
    /// </summary>
    [IsoId("_15f9sFBEEeedyPuM0kK2EQ")]
    [DisplayName("Interchange Fee")]
    [IsoXmlTag("IntrchngFee")]
    public Amount14? InterchangeFee { get; init; } 
    
    /// <summary>
    /// Fee pertaining to the agent.
    /// </summary>
    [IsoId("_8vflIFBEEeedyPuM0kK2EQ")]
    [DisplayName("Agent Fee")]
    [IsoXmlTag("AgtFee")]
    public Amount14? AgentFee { get; init; } 
    
    /// <summary>
    /// Other amounts involved in clearing.
    /// </summary>
    [IsoId("_PdT84FBKEeedyPuM0kK2EQ")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public OtherAmount2? OtherAmount { get; init; } 
    
    
    #nullable disable
    
}
