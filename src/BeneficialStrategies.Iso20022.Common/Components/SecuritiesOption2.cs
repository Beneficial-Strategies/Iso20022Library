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
[IsoId("_UGTFC9p-Ed-ak6NoX_4Aeg_1927466067")]
[DisplayName("Securities Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOption2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOption2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOption2( InstructedOrQuantityToReceive1Choice_ reqInstructedOrQuantityToReceive )
    {
        InstructedOrQuantityToReceive = reqInstructedOrQuantityToReceive;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_UGcO8Np-Ed-ak6NoX_4Aeg_1927466137")]
    [DisplayName("Conditional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlQty")]
    #endif
    [IsoXmlTag("CondlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ConditionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity instructed to be received over and above normal ensured entitlement.
    /// </summary>
    [IsoId("_UGcO8dp-Ed-ak6NoX_4Aeg_1927466379")]
    [DisplayName("Over And Above Normal Ensured Entitlement Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverAndAbovNrmlNsrdEntitlmntQty")]
    #endif
    [IsoXmlTag("OverAndAbovNrmlNsrdEntitlmntQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? OverAndAboveNormalEnsuredEntitlementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? OverAndAboveNormalEnsuredEntitlementQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? OverAndAboveNormalEnsuredEntitlementQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is a quantity of securities instructed or a quantity to receive.
    /// </summary>
    [IsoId("_UGcO8tp-Ed-ak6NoX_4Aeg_-1537787480")]
    [DisplayName("Instructed Or Quantity To Receive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdOrQtyToRcv")]
    #endif
    [IsoXmlTag("InstdOrQtyToRcv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #else
    public InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; set; } 
    #endif
    
    
    #nullable disable
    
}
