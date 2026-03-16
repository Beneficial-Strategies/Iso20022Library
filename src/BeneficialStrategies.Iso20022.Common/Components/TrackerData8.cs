// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tracker Data8.
/// </summary>
[IsoId("_tLDxcVeWEe6G45fhJISx6Q")]
[DisplayName("Tracker Data8")]
public partial record TrackerData8
{
    #nullable enable

    /// <summary>
    /// Confirmed Amount.
    /// </summary>
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public ActiveCurrencyAndAmount? ConfirmedAmount { get; init; } 

    /// <summary>
    /// Confirmed Date.
    /// </summary>
    [DisplayName("Confirmed Date")]
    [IsoXmlTag("ConfdDt")]
    public DateAndDateTime2Choice_? ConfirmedDate { get; init; } 

    /// <summary>
    /// Previously Confirmed Amount.
    /// </summary>
    [DisplayName("Previously Confirmed Amount")]
    [IsoXmlTag("PrevslyConfdAmt")]
    public ActiveCurrencyAndAmount? PreviouslyConfirmedAmount { get; init; } 

    /// <summary>
    /// Previously Confirmed Date.
    /// </summary>
    [DisplayName("Previously Confirmed Date")]
    [IsoXmlTag("PrevslyConfdDt")]
    public DateAndDateTime2Choice_? PreviouslyConfirmedDate { get; init; } 

    /// <summary>
    /// Remaining To Be Confirmed Amount.
    /// </summary>
    [DisplayName("Remaining To Be Confirmed Amount")]
    [IsoXmlTag("RmngToBeConfdAmt")]
    public ActiveCurrencyAndAmount? RemainingToBeConfirmedAmount { get; init; } 

    /// <summary>
    /// Returned Confirmed Amount.
    /// </summary>
    [DisplayName("Returned Confirmed Amount")]
    [IsoXmlTag("RtrdConfdAmt")]
    public ActiveCurrencyAndAmount? ReturnedConfirmedAmount { get; init; } 

    /// <summary>
    /// Returned Confirmed Date.
    /// </summary>
    [DisplayName("Returned Confirmed Date")]
    [IsoXmlTag("RtrdConfdDt")]
    public DateAndDateTime2Choice_? ReturnedConfirmedDate { get; init; } 

    
    #nullable disable
    
}
