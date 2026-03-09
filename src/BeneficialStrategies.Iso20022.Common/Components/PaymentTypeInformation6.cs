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
/// Set of elements that further details the information related to the type of payment.
/// </summary>
[IsoId("_TGhDCtp-Ed-ak6NoX_4Aeg_-579871579")]
[DisplayName("Payment Type Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTypeInformation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_TGq0ANp-Ed-ak6NoX_4Aeg_-579871562")]
    [DisplayName("Instruction Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrty")]
    #endif
    [IsoXmlTag("InstrPrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Priority2Code? InstructionPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Priority2Code? InstructionPriority { get; init; } 
    #else
    public Priority2Code? InstructionPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_TGq0Adp-Ed-ak6NoX_4Aeg_-579871448")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel2Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel2Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel2Choice_? ServiceLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_TGq0Atp-Ed-ak6NoX_4Aeg_-579871544")]
    [DisplayName("Clearing Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrChanl")]
    #endif
    [IsoXmlTag("ClrChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingChannel2Code? ClearingChannel { get; init; } 
    #else
    public ClearingChannel2Code? ClearingChannel { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    [IsoId("_TGq0A9p-Ed-ak6NoX_4Aeg_-579871189")]
    [DisplayName("Local Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclInstrm")]
    #endif
    [IsoXmlTag("LclInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalInstrument1Choice_? LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalInstrument1Choice_? LocalInstrument { get; init; } 
    #else
    public LocalInstrument1Choice_? LocalInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the direct debit sequence, eg, first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_TGq0BNp-Ed-ak6NoX_4Aeg_1750627501")]
    [DisplayName("Sequence Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqTp")]
    #endif
    [IsoXmlTag("SeqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SequenceType1Code? SequenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SequenceType1Code? SequenceType { get; init; } 
    #else
    public SequenceType1Code? SequenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_TGq0Bdp-Ed-ak6NoX_4Aeg_-579871509")]
    [DisplayName("Category Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyPurp")]
    #endif
    [IsoXmlTag("CtgyPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; } 
    #else
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; set; } 
    #endif
    
    
    #nullable disable
    
}
