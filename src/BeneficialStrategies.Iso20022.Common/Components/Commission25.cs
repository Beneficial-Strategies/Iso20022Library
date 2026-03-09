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
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_6apuIwauEe2phaVG0lYKTw")]
[DisplayName("Commission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commission25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Commission25 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Commission25( CommissionType6Choice_ reqType,AmountOrRate2Choice_ reqCommission )
    {
        Type = reqType;
        Commission = reqCommission;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specification of the commission type.
    /// </summary>
    [IsoId("_6sPMmQauEe2phaVG0lYKTw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommissionType6Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommissionType6Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommissionType6Choice_ Type { get; init; } 
    #else
    public CommissionType6Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_6sPMoQauEe2phaVG0lYKTw")]
    [DisplayName("Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Comssn")]
    #endif
    [IsoXmlTag("Comssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrRate2Choice_ Commission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrRate2Choice_ Commission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate2Choice_ Commission { get; init; } 
    #else
    public AmountOrRate2Choice_ Commission { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [IsoId("_6sPMrwauEe2phaVG0lYKTw")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification267? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification267? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification267? RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which an operation is triggered to calculate, for instance, a commission, fee, asset values, etc.
    /// </summary>
    [IsoId("_6sPMtwauEe2phaVG0lYKTw")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CalculationDate { get; init; } 
    #else
    public System.DateOnly? CalculationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the commissions for a specific trade.
    /// </summary>
    [IsoId("_6sPMuQauEe2phaVG0lYKTw")]
    [DisplayName("Total Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlComssn")]
    #endif
    [IsoXmlTag("TtlComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? TotalCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? TotalCommission { get; init; } 
    #else
    public AmountAndDirection29? TotalCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that results of the calculation of VAT on net fees, according to the transaction current tariffs.
    /// </summary>
    [IsoId("_6sPMuwauEe2phaVG0lYKTw")]
    [DisplayName("Total VAT Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVATAmt")]
    #endif
    [IsoXmlTag("TtlVATAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalVATAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalVATAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalVATAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the VAT rate.
    /// </summary>
    [IsoId("_6sPMvQauEe2phaVG0lYKTw")]
    [DisplayName("VAT Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VATRate")]
    #endif
    [IsoXmlTag("VATRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? VATRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? VATRate { get; init; } 
    #else
    public System.Decimal? VATRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
