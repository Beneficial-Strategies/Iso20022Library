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
/// Charges related to a payment obligation contracted between two financial institutions related to the financing of a commercial transaction.
/// </summary>
[IsoId("_D8zW4dP_EeK0PPbKncCqzA")]
[DisplayName("Charges")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charges5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charges5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charges5( BankRole1Code reqChargesPayer,BankRole1Code reqChargesPayee )
    {
        ChargesPayer = reqChargesPayer;
        ChargesPayee = reqChargesPayee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Bank which will pay the charges.
    /// </summary>
    [IsoId("_EaqXm9P_EeK0PPbKncCqzA")]
    [DisplayName("Charges Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsPyer")]
    #endif
    [IsoXmlTag("ChrgsPyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankRole1Code ChargesPayer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankRole1Code ChargesPayer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankRole1Code ChargesPayer { get; init; } 
    #else
    public BankRole1Code ChargesPayer { get; set; } 
    #endif
    
    /// <summary>
    /// Bank which will receive the charges.
    /// </summary>
    [IsoId("_EaqXndP_EeK0PPbKncCqzA")]
    [DisplayName("Charges Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsPyee")]
    #endif
    [IsoXmlTag("ChrgsPyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankRole1Code ChargesPayee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankRole1Code ChargesPayee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankRole1Code ChargesPayee { get; init; } 
    #else
    public BankRole1Code ChargesPayee { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the charges taken by the payer.
    /// </summary>
    [IsoId("_EaqXn9P_EeK0PPbKncCqzA")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? Amount { get; init; } 
    #else
    public CurrencyAndAmount? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the charges expressed as a percentage of the amount paid by the obligor bank.
    /// </summary>
    [IsoId("_EaqXodP_EeK0PPbKncCqzA")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Percentage { get; init; } 
    #else
    public System.Decimal? Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Type of charges. For example: transaction charges, financing charges, deferred payment, interests.
    /// </summary>
    [IsoId("_QeQdoBUsEeOCqpkCrPgk4g")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    
    #nullable disable
    
}
