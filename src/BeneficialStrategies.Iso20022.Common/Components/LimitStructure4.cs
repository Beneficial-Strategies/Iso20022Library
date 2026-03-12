// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_LWX6EckIEem3UrxZgQhVAw")]
[DisplayName("Limit Structure")]
public partial record LimitStructure4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_Lmziw8kIEem3UrxZgQhVAw")]
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification5 LimitIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the limit becomes effective.
    /// </summary>
    [IsoId("_SKFpk8kIEem3UrxZgQhVAw")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public DateAndDateTime2Choice_? StartDateTime { get; init; } 
    
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_SKFplMkIEem3UrxZgQhVAw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; } 
    
    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [IsoId("_SKFplckIEem3UrxZgQhVAw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    
    #nullable disable
    
}
