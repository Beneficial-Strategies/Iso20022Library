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
[IsoId("_Rt2m8Np-Ed-ak6NoX_4Aeg_-1889591206")]
[DisplayName("Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charge20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charge20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charge20( ChargeType12Code reqType,System.String reqExtendedType,ActiveOrHistoricCurrencyAndAmount reqAmount )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_Rt2m8dp-Ed-ak6NoX_4Aeg_-1889590821")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType12Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType12Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType12Code Type { get; init; } 
    #else
    public ChargeType12Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_Rt2m8tp-Ed-ak6NoX_4Aeg_-1546039460")]
    [DisplayName("Extended Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTp")]
    #endif
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_Rt2m89p-Ed-ak6NoX_4Aeg_-1889590838")]
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
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_Rt2m9Np-Ed-ak6NoX_4Aeg_-1889590683")]
    [DisplayName("Charge Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBsis")]
    #endif
    [IsoXmlTag("ChrgBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxationBasis2Code? ChargeBasis { get; init; } 
    #else
    public TaxationBasis2Code? ChargeBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate a charge.
    /// </summary>
    [IsoId("_Rt2m9dp-Ed-ak6NoX_4Aeg_-1546039194")]
    [DisplayName("Extended Charge Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedChrgBsis")]
    #endif
    [IsoXmlTag("XtndedChrgBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedChargeBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedChargeBasis { get; init; } 
    #else
    public System.String? ExtendedChargeBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_Rt2m9tp-Ed-ak6NoX_4Aeg_-1889590310")]
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
    [IsoId("_Rt2m99p-Ed-ak6NoX_4Aeg_-1889590328")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? RecipientIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
