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
/// Provides details specific to the individual settlement instruction(s) included in the message.
/// </summary>
[IsoId("_I5-6EQcZEeyTDbUIoCmuCw")]
[DisplayName("Multilateral Settlement Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MultilateralSettlementRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MultilateralSettlementRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MultilateralSettlementRequest2( System.String reqInstructionIdentification )
    {
        InstructionIdentification = reqInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_I-zvsQcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructionIdentification { get; init; } 
    #else
    public System.String InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvswcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrty")]
    #endif
    [IsoXmlTag("InstrPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority3Code? InstructionPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority3Code? InstructionPriority { get; init; } 
    #else
    public Priority3Code? InstructionPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the requested settlement time(s) of the instruction.
    /// </summary>
    [IsoId("_I-zvtwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Time Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTmReq")]
    #endif
    [IsoXmlTag("SttlmTmReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    #else
    public SettlementTimeRequest2? SettlementTimeRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the settlement instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvuQcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrty")]
    #endif
    [IsoXmlTag("SttlmPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority3Code? SettlementPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority3Code? SettlementPriority { get; init; } 
    #else
    public Priority3Code? SettlementPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the settlement cycle in the settlement service.
    /// Usage: The SettlementCycle is used to differentiate this multilateral settlement from other multilateral settlements where more than one occurs within a given time period.
    /// </summary>
    [IsoId("_I-zvuwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCycl")]
    #endif
    [IsoXmlTag("SttlmCycl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SettlementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementCycle { get; init; } 
    #else
    public System.String? SettlementCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of the number of movement records contained in an individual settlement request.
    /// </summary>
    [IsoId("_I-zvvQcZEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Movement Records")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfMvmntRcrds")]
    #endif
    [IsoXmlTag("NbOfMvmntRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfMovementRecords { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfMovementRecords { get; init; } 
    #else
    public System.UInt64? NumberOfMovementRecords { get; set; } 
    #endif
    
    /// <summary>
    /// Credit or debit transaction contained in an individual settlement request.
    /// Usage: Number of occurrences of MovementRecord shall always be even.
    /// </summary>
    [IsoId("_I-zvvwcZEeyTDbUIoCmuCw")]
    [DisplayName("Movement Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntRcrd")]
    #endif
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord1> MovementRecord { get; init; } = new ValueList<MovementRecord1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _I-zvvwcZEeyTDbUIoCmuCw
    
    
    #nullable disable
    
}
