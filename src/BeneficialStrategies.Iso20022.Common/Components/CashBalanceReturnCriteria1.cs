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
[IsoId("_4WGqR5laEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Balance Return Criteria")]
public partial record CashBalanceReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the balance type is requested.
    /// </summary>
    [IsoId("_4er-cZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance status is requested.
    /// </summary>
    [IsoId("_4er-c5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator StatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the value date is requested.
    /// </summary>
    [IsoId("_4er-dZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Value Date Indicator")]
    [IsoXmlTag("ValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ValueDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the number of payment is requested.
    /// </summary>
    [IsoId("_4er-d5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Number Of Payments Indicator")]
    [IsoXmlTag("NbOfPmtsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator NumberOfPaymentsIndicator { get; init; } 
    
    
    #nullable disable
    
}
