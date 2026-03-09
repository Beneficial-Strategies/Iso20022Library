// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used with financial types of messages when third-party clearing is involved.
/// </summary>
[IsoId("_YNv3MZMqEeuleeHpFMMhmQ")]
[DisplayName("Clearing Record Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingRecordData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingRecordData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingRecordData2( ClearingMethod2Code reqClearingMethod )
    {
        ClearingMethod = reqClearingMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Originator of the batch.
    /// </summary>
    [IsoId("_YUL2YZMqEeuleeHpFMMhmQ")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Originator1? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Originator1? Originator { get; init; } 
    #else
    public Originator1? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Institution, final destination of the batch.
    /// </summary>
    [IsoId("_YUL2Y5MqEeuleeHpFMMhmQ")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Destination1? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Destination1? Destination { get; init; } 
    #else
    public Destination1? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Type of clearing of the transaction.
    /// </summary>
    [IsoId("_YUL2ZZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMtd")]
    #endif
    [IsoXmlTag("ClrMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingMethod2Code ClearingMethod { get; init; } 
    #else
    public ClearingMethod2Code ClearingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_YUL2Z5MqEeuleeHpFMMhmQ")]
    [DisplayName("Other Clearing Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrClrMtd")]
    #endif
    [IsoXmlTag("OthrClrMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherClearingMethod { get; init; } 
    #else
    public System.String? OtherClearingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("_YUL2aZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrPrty")]
    #endif
    [IsoXmlTag("ClrPrty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClearingPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingPriority { get; init; } 
    #else
    public System.String? ClearingPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_YUL2a5MqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDt")]
    #endif
    [IsoXmlTag("ClrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClearingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClearingDate { get; init; } 
    #else
    public System.DateOnly? ClearingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount of clearing.
    /// </summary>
    [IsoId("_YUL2bZMqEeuleeHpFMMhmQ")]
    [DisplayName("Clearing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAmt")]
    #endif
    [IsoXmlTag("ClrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount17? ClearingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17? ClearingAmount { get; init; } 
    #else
    public Amount17? ClearingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange reimbursement fee.
    /// </summary>
    [IsoId("_YUL2b5MqEeuleeHpFMMhmQ")]
    [DisplayName("Interchange Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrchngFee")]
    #endif
    [IsoXmlTag("IntrchngFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount17? InterchangeFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17? InterchangeFee { get; init; } 
    #else
    public Amount17? InterchangeFee { get; set; } 
    #endif
    
    /// <summary>
    /// Fee pertaining to the agent.
    /// </summary>
    [IsoId("_YUL2cZMqEeuleeHpFMMhmQ")]
    [DisplayName("Agent Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtFee")]
    #endif
    [IsoXmlTag("AgtFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount17? AgentFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17? AgentFee { get; init; } 
    #else
    public Amount17? AgentFee { get; set; } 
    #endif
    
    /// <summary>
    /// Other amounts involved in clearing.
    /// </summary>
    [IsoId("_YUL2c5MqEeuleeHpFMMhmQ")]
    [DisplayName("Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmt")]
    #endif
    [IsoXmlTag("OthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmount4? OtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmount4? OtherAmount { get; init; } 
    #else
    public OtherAmount4? OtherAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
