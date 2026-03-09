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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_YSR7ESSBEeWWV-wpfEW00A")]
[DisplayName("Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charge29
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charge29 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charge29( ChargeType4Choice_ reqType,ActiveOrHistoricCurrencyAndAmount reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_Yu_sIySBEeWWV-wpfEW00A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType4Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType4Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType4Choice_ Type { get; init; } 
    #else
    public ChargeType4Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_Yu_sJSSBEeWWV-wpfEW00A")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate the charge.
    /// </summary>
    [IsoId("_Yu_sJySBEeWWV-wpfEW00A")]
    [DisplayName("Charge Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBsis")]
    #endif
    [IsoXmlTag("ChrgBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBasisType1Choice_? ChargeBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBasisType1Choice_? ChargeBasis { get; init; } 
    #else
    public ChargeBasisType1Choice_? ChargeBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_Yu_sKSSBEeWWV-wpfEW00A")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearer1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_Yu_sKySBEeWWV-wpfEW00A")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification70Choice_? RecipientIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
