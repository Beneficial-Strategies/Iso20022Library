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
/// Information of a single instalment related to an invoice settlement.
/// </summary>
[IsoId("_Py7LUtp-Ed-ak6NoX_4Aeg_-550302761")]
[DisplayName("Instalment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instalment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Instalment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Instalment1( System.String reqSequenceIdentification,System.DateOnly reqPaymentDueDate,ActiveCurrencyAndAmount reqAmount )
    {
        SequenceIdentification = reqSequenceIdentification;
        PaymentDueDate = reqPaymentDueDate;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the progressive number of the single instalment related to an invoice.
    /// </summary>
    [IsoId("_Py7LU9p-Ed-ak6NoX_4Aeg_-760207226")]
    [DisplayName("Sequence Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqId")]
    #endif
    [IsoXmlTag("SeqId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text SequenceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SequenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SequenceIdentification { get; init; } 
    #else
    public System.String SequenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Due date for the payment of the invoice instalment.
    /// </summary>
    [IsoId("_Py7LVNp-Ed-ak6NoX_4Aeg_-446211991")]
    [DisplayName("Payment Due Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDueDt")]
    #endif
    [IsoXmlTag("PmtDueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PaymentDueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PaymentDueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PaymentDueDate { get; init; } 
    #else
    public System.DateOnly PaymentDueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of a single instalment related to an invoice.
    /// </summary>
    [IsoId("_Py7LVdp-Ed-ak6NoX_4Aeg_-333541102")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
