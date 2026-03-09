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
/// Information on the occurred settlement time(s) of the payment transaction.
/// </summary>
[IsoId("_QIYeB9p-Ed-ak6NoX_4Aeg_-498720410")]
[DisplayName("Settlement Date Time Indication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDateTimeIndication1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which a payment has been debited at the transaction administrator. In the case of TARGET, the date and time at which the payment has been debited at the central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIhn4Np-Ed-ak6NoX_4Aeg_-425762310")]
    [DisplayName("Debit Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtDtTm")]
    #endif
    [IsoXmlTag("DbtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DebitDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DebitDateTime { get; init; } 
    #else
    public System.DateTime? DebitDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a payment has been credited at the transaction administrator. In the case of TARGET, the date and time at which the payment has been credited at the receiving central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIhn4dp-Ed-ak6NoX_4Aeg_-356497199")]
    [DisplayName("Credit Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDtTm")]
    #endif
    [IsoXmlTag("CdtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CreditDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CreditDateTime { get; init; } 
    #else
    public System.DateTime? CreditDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
