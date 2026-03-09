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
/// Provides information about a movement that failed the settlement.
/// </summary>
[IsoId("_UIrqo9p-Ed-ak6NoX_4Aeg_2140472900")]
[DisplayName("Failed Movement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FailedMovement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FailedMovement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FailedMovement1( ActiveCurrencyAndAmount reqCashAmount,UnitOrFaceAmount1Choice_ reqSecuritiesQuantity,FailedSettlementReason1FormatChoice_ reqReason )
    {
        CashAmount = reqCashAmount;
        SecuritiesQuantity = reqSecuritiesQuantity;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of cash.
    /// </summary>
    [IsoId("_UIrqpNp-Ed-ak6NoX_4Aeg_389375421")]
    [DisplayName("Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmt")]
    #endif
    [IsoXmlTag("CshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the financial instrument.
    /// </summary>
    [IsoId("_UIrqpdp-Ed-ak6NoX_4Aeg_-613888276")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIrqptp-Ed-ak6NoX_4Aeg_-647134478")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7? SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7? SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// The reason for the settlement failure.
    /// </summary>
    [IsoId("_UIrqp9p-Ed-ak6NoX_4Aeg_-124106569")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailedSettlementReason1FormatChoice_ Reason { get; init; } 
    #else
    public FailedSettlementReason1FormatChoice_ Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
