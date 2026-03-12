// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment transaction with an aggregated amount.
/// </summary>
[IsoId("_Yy7UkDDuEeO9waS4ina8CA")]
[DisplayName("Aggregation Transaction")]
public partial record AggregationTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the first payment.
    /// </summary>
    [IsoId("_j5xGIDDuEeO9waS4ina8CA")]
    [DisplayName("First Payment Date Time")]
    [IsoXmlTag("FrstPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FirstPaymentDateTime { get; init; } 
    
    /// <summary>
    /// Date and time of the last payment.
    /// </summary>
    [IsoId("_typ20DDuEeO9waS4ina8CA")]
    [DisplayName("Last Payment Date Time")]
    [IsoXmlTag("LastPmtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastPaymentDateTime { get; init; } 
    
    /// <summary>
    /// Total number of payments that has been aggregated.
    /// </summary>
    [IsoId("_1wf3IDDuEeO9waS4ina8CA")]
    [DisplayName("Number Of Payments")]
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfPayments { get; init; } 
    
    /// <summary>
    /// Individual payment that has been aggregated.
    /// </summary>
    [IsoId("__CQWYDDuEeO9waS4ina8CA")]
    [DisplayName("Individual Payment")]
    [IsoXmlTag("IndvPmt")]
    public DetailedAmount6? IndividualPayment { get; init; } 
    
    
    #nullable disable
    
}
