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
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_LWX6EckIEem3UrxZgQhVAw")]
[DisplayName("Limit Structure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitStructure4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitStructure4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitStructure4( LimitIdentification5 reqLimitIdentification,Amount2Choice_ reqAmount )
    {
        LimitIdentification = reqLimitIdentification;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_Lmziw8kIEem3UrxZgQhVAw")]
    [DisplayName("Limit Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LmtId")]
    #endif
    [IsoXmlTag("LmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitIdentification5 LimitIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LimitIdentification5 LimitIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitIdentification5 LimitIdentification { get; init; } 
    #else
    public LimitIdentification5 LimitIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the limit becomes effective.
    /// </summary>
    [IsoId("_SKFpk8kIEem3UrxZgQhVAw")]
    [DisplayName("Start Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDtTm")]
    #endif
    [IsoXmlTag("StartDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? StartDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? StartDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? StartDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_SKFplMkIEem3UrxZgQhVAw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ Amount { get; init; } 
    #else
    public Amount2Choice_ Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [IsoId("_SKFplckIEem3UrxZgQhVAw")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
