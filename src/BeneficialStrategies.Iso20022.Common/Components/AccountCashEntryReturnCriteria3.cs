// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the cash entry.
/// </summary>
[IsoId("_hUXR--0gEeWGZ8O9Moj6Zw")]
[DisplayName("Account Cash Entry Return Criteria")]
public partial record AccountCashEntryReturnCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the entry reference is requested.
    /// </summary>
    [IsoId("_heVtUe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Reference Indicator")]
    [IsoXmlTag("NtryRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EntryReferenceIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_heVtU-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Type Indicator")]
    [IsoXmlTag("AcctTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountTypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the entry amount is requested.
    /// </summary>
    [IsoId("_heVtVe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Amount Indicator")]
    [IsoXmlTag("NtryAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EntryAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_heVtV-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Currency Indicator")]
    [IsoXmlTag("AcctCcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountCurrencyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the entry status is requested.
    /// </summary>
    [IsoId("_heVtWe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Status Indicator")]
    [IsoXmlTag("NtryStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EntryStatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the entry date is requested.
    /// </summary>
    [IsoId("_heVtW-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Entry Date Indicator")]
    [IsoXmlTag("NtryDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? EntryDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [IsoId("_heVtXe0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Servicer Indicator")]
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account owner is requested.
    /// </summary>
    [IsoId("_heVtX-0gEeWGZ8O9Moj6Zw")]
    [DisplayName("Account Owner Indicator")]
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; } 
    
    
    #nullable disable
    
}
