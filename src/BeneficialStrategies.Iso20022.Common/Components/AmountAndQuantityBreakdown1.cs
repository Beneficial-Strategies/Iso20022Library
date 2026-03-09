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
/// Details of breakdown of a an amount or quantity.
/// </summary>
[IsoId("_qHXhcbFMEeqxQ8-YVgMtLw")]
[DisplayName("Amount And Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndQuantityBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_qJ54EbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotNb")]
    #endif
    [IsoXmlTag("LotNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? LotNumber { get; init; } 
    #else
    public GenericIdentification37? LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that is part of the lot described.
    /// </summary>
    [IsoId("_zq6URLFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotAmt")]
    #endif
    [IsoXmlTag("LotAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? LotAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? LotAmount { get; init; } 
    #else
    public AmountAndDirection5? LotAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_qJ54GbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotQty")]
    #endif
    [IsoXmlTag("LotQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_qJ54IbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Cash Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSubBalTp")]
    #endif
    [IsoXmlTag("CshSubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    #else
    public GenericIdentification30? CashSubBalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
