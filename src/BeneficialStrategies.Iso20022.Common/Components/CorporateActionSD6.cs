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
/// Details about the lottery.
/// </summary>
[IsoId("_1RIYZTL3EeKU9IrkkToqcw_-395277893")]
[DisplayName("Corporate Action SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSD6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSD6( WorkflowStatus1Code reqLotteryRecordStatus )
    {
        LotteryRecordStatus = reqLotteryRecordStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the fields of lottery record.
    /// </summary>
    [IsoId("_1RSJYDL3EeKU9IrkkToqcw_1163055922")]
    [DisplayName("Lottery Record Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryRcrdSts")]
    #endif
    [IsoXmlTag("LtryRcrdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required WorkflowStatus1Code LotteryRecordStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required WorkflowStatus1Code LotteryRecordStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WorkflowStatus1Code LotteryRecordStatus { get; init; } 
    #else
    public WorkflowStatus1Code LotteryRecordStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
