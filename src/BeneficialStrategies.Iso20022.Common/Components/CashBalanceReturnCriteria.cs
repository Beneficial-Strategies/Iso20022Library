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
/// Defines the criteria used to report on the cash balance.
/// </summary>
[IsoId("_RGqrKtp-Ed-ak6NoX_4Aeg_-1267402961")]
[DisplayName("Cash Balance Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalanceReturnCriteria
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalanceReturnCriteria instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalanceReturnCriteria( System.String reqTypeIndicator,System.String reqStatusIndicator,System.String reqValueDateIndicator,System.String reqNumberOfPaymentsIndicator )
    {
        TypeIndicator = reqTypeIndicator;
        StatusIndicator = reqStatusIndicator;
        ValueDateIndicator = reqValueDateIndicator;
        NumberOfPaymentsIndicator = reqNumberOfPaymentsIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the balance type is requested.
    /// </summary>
    [IsoId("_RG0cINp-Ed-ak6NoX_4Aeg_-1267402960")]
    [DisplayName("Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpInd")]
    #endif
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator TypeIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TypeIndicator { get; init; } 
    #else
    public System.String TypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the balance status is requested.
    /// </summary>
    [IsoId("_RG0cIdp-Ed-ak6NoX_4Aeg_-1267402959")]
    [DisplayName("Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInd")]
    #endif
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator StatusIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatusIndicator { get; init; } 
    #else
    public System.String StatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value date is requested.
    /// </summary>
    [IsoId("_RG0cItp-Ed-ak6NoX_4Aeg_-1267402951")]
    [DisplayName("Value Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDtInd")]
    #endif
    [IsoXmlTag("ValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator ValueDateIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ValueDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ValueDateIndicator { get; init; } 
    #else
    public System.String ValueDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the number of payment is requested.
    /// </summary>
    [IsoId("_RG0cI9p-Ed-ak6NoX_4Aeg_-1267402950")]
    [DisplayName("Number Of Payments Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfPmtsInd")]
    #endif
    [IsoXmlTag("NbOfPmtsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator NumberOfPaymentsIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfPaymentsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfPaymentsIndicator { get; init; } 
    #else
    public System.String NumberOfPaymentsIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
