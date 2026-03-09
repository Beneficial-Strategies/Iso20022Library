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
/// Specifies the details on the settlement fails split per intra-CSD and cross-CSD instructions.
/// </summary>
[IsoId("_MTNhaTOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily CSD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsDailyCSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsDailyCSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsDailyCSD3( SettlementFailsDailyInstructionType1Choice_ reqIntraCSD,SettlementFailsDailyInstructionType1Choice_ reqCrossCSD )
    {
        IntraCSD = reqIntraCSD;
        CrossCSD = reqCrossCSD;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Intra-CSD settlement instructions data.
    /// </summary>
    [IsoId("_MUG5QTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Intra CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraCSD")]
    #endif
    [IsoXmlTag("IntraCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; init; } 
    #else
    public SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; set; } 
    #endif
    
    /// <summary>
    /// Cross-CSD settlement instructions data.
    /// </summary>
    [IsoId("_MUG5QzOmEeqX8uoQQ3KffQ")]
    [DisplayName("Cross CSD")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrossCSD")]
    #endif
    [IsoXmlTag("CrossCSD")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; init; } 
    #else
    public SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; set; } 
    #endif
    
    
    #nullable disable
    
}
