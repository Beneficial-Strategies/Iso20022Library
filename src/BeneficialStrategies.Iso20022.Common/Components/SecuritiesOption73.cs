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
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_qY_3sffREeiNZp_PtLohLw")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption73
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption73 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption73( Quantity40Choice_ reqInstructedQuantity )
    {
        InstructedQuantity = reqInstructedQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_qY_3s_fREeiNZp_PtLohLw")]
    [DisplayName("Conditional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlQty")]
    #endif
    [IsoXmlTag("CondlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_qY_3u_fREeiNZp_PtLohLw")]
    [DisplayName("Instructed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdQty")]
    #endif
    [IsoXmlTag("InstdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity40Choice_ InstructedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity40Choice_ InstructedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity40Choice_ InstructedQuantity { get; init; } 
    #else
    public Quantity40Choice_ InstructedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
    /// </summary>
    [IsoId("_qY_3vffREeiNZp_PtLohLw")]
    [DisplayName("Additional Round Up Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRndUpQty")]
    #endif
    [IsoXmlTag("AddtlRndUpQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AdditionalRoundUpQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AdditionalRoundUpQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AdditionalRoundUpQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
