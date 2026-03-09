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
/// Defines the criteria used to report on the cash entry.
/// </summary>
[IsoId("_hUXR--0gEeWGZ8O9Moj6Zw")]
[DisplayName("Account Cash Entry Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountCashEntryReturnCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the entry reference is requested.
    /// </summary>
    [IsoId("_heVtUe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryRefInd")]
    #endif
    [IsoXmlTag("NtryRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EntryReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryReferenceIndicator { get; init; } 
    #else
    public System.String? EntryReferenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_heVtU-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTpInd")]
    #endif
    [IsoXmlTag("AcctTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountTypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountTypeIndicator { get; init; } 
    #else
    public System.String? AccountTypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the entry amount is requested.
    /// </summary>
    [IsoId("_heVtVe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryAmtInd")]
    #endif
    [IsoXmlTag("NtryAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EntryAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryAmountIndicator { get; init; } 
    #else
    public System.String? EntryAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_heVtV-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Currency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctCcyInd")]
    #endif
    [IsoXmlTag("AcctCcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountCurrencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountCurrencyIndicator { get; init; } 
    #else
    public System.String? AccountCurrencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the entry status is requested.
    /// </summary>
    [IsoId("_heVtWe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryStsInd")]
    #endif
    [IsoXmlTag("NtryStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EntryStatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryStatusIndicator { get; init; } 
    #else
    public System.String? EntryStatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the entry date is requested.
    /// </summary>
    [IsoId("_heVtW-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryDtInd")]
    #endif
    [IsoXmlTag("NtryDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EntryDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryDateIndicator { get; init; } 
    #else
    public System.String? EntryDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [IsoId("_heVtXe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Servicer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrInd")]
    #endif
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerIndicator { get; init; } 
    #else
    public System.String? AccountServicerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account owner is requested.
    /// </summary>
    [IsoId("_heVtX-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Owner Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrInd")]
    #endif
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerIndicator { get; init; } 
    #else
    public System.String? AccountOwnerIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
