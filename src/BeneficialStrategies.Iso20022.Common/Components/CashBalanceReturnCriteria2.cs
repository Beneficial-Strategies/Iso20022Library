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
[IsoId("_1M2zsXX4Eei3jO6riKEVXg")]
[DisplayName("Cash Balance Return Criteria")]
public partial record CashBalanceReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the balance type is requested.
    /// </summary>
    [IsoId("_1Z0RoXX4Eei3jO6riKEVXg")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance status is requested.
    /// </summary>
    [IsoId("_1Z0Ro3X4Eei3jO6riKEVXg")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator StatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the value date is requested.
    /// </summary>
    [IsoId("_1Z0RpXX4Eei3jO6riKEVXg")]
    [DisplayName("Value Date Indicator")]
    [IsoXmlTag("ValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ValueDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the processing date is requested.
    /// </summary>
    [IsoId("_50MyQXX4Eei3jO6riKEVXg")]
    [DisplayName("Processing Date Indicator")]
    [IsoXmlTag("PrcgDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator ProcessingDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the number of payment is requested.
    /// </summary>
    [IsoId("_1Z0Rp3X4Eei3jO6riKEVXg")]
    [DisplayName("Number Of Payments Indicator")]
    [IsoXmlTag("NbOfPmtsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public required IsoRequestedIndicator NumberOfPaymentsIndicator { get; init; } 
    
    
    #nullable disable
    
}
