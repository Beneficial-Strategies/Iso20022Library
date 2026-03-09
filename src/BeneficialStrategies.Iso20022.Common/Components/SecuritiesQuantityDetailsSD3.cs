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
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_Hnr6scVJEeeWeZMpNX1JUQ")]
[DisplayName("Securities Quantity Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesQuantityDetailsSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_H4NC88VJEeeWeZMpNX1JUQ")]
    [DisplayName("Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptQty")]
    #endif
    [IsoXmlTag("OvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_dvHr4MVJEeeWeZMpNX1JUQ")]
    [DisplayName("Total Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlOvrsbcptQty")]
    #endif
    [IsoXmlTag("TtlOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_X-KicMVgEeeprYdSN88o0Q")]
    [DisplayName("Instruction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrQty")]
    #endif
    [IsoXmlTag("InstrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
