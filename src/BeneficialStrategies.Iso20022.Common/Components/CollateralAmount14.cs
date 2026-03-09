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
/// Deal amount details.
/// </summary>
[IsoId("_k9T14RIlEeyLzJfz3xPQNA")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    [IsoId("_lUQWQRIlEeyLzJfz3xPQNA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Transaction { get; init; } 
    #else
    public AmountAndDirection49? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    [IsoId("_lUQWQxIlEeyLzJfz3xPQNA")]
    [DisplayName("Termination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Termntn")]
    #endif
    [IsoXmlTag("Termntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Termination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Termination { get; init; } 
    #else
    public AmountAndDirection49? Termination { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    [IsoId("_lUQWRRIlEeyLzJfz3xPQNA")]
    [DisplayName("Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acrd")]
    #endif
    [IsoXmlTag("Acrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? Accrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? Accrued { get; init; } 
    #else
    public AmountAndDirection49? Accrued { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral offered or sought. 
    /// </summary>
    [IsoId("_lUQWRxIlEeyLzJfz3xPQNA")]
    [DisplayName("Value Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSght")]
    #endif
    [IsoXmlTag("ValSght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? ValueSought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? ValueSought { get; init; } 
    #else
    public AmountAndDirection49? ValueSought { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction amount effectively processed by the TPA taking into account the matching tolerance threshold.
    /// </summary>
    [IsoId("_lUQWSRIlEeyLzJfz3xPQNA")]
    [DisplayName("Undisputed Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdsptdTx")]
    #endif
    [IsoXmlTag("UdsptdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? UndisputedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? UndisputedTransaction { get; init; } 
    #else
    public AmountAndDirection49? UndisputedTransaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
