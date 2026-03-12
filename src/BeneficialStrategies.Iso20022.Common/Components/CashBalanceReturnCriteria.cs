// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the cash balance.
/// </summary>
[IsoId("_RGqrKtp-Ed-ak6NoX_4Aeg_-1267402961")]
[DisplayName("Cash Balance Return Criteria")]
public partial record CashBalanceReturnCriteria
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the balance type is requested.
    /// </summary>
    [IsoId("_RG0cINp-Ed-ak6NoX_4Aeg_-1267402960")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance status is requested.
    /// </summary>
    [IsoId("_RG0cIdp-Ed-ak6NoX_4Aeg_-1267402959")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator StatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the value date is requested.
    /// </summary>
    [IsoId("_RG0cItp-Ed-ak6NoX_4Aeg_-1267402951")]
    [DisplayName("Value Date Indicator")]
    [IsoXmlTag("ValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ValueDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the number of payment is requested.
    /// </summary>
    [IsoId("_RG0cI9p-Ed-ak6NoX_4Aeg_-1267402950")]
    [DisplayName("Number Of Payments Indicator")]
    [IsoXmlTag("NbOfPmtsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator NumberOfPaymentsIndicator { get; init; } 
    
    
    #nullable disable
    
}
