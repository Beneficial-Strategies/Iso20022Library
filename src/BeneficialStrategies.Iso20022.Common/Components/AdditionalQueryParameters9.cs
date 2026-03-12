// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific query criteria.
/// </summary>
[IsoId("_t8MvNVhpEeS8HfHHd4stCA")]
[DisplayName("Additional Query Parameters")]
public partial record AdditionalQueryParameters9
{
    #nullable enable
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_uW-msVhpEeS8HfHHd4stCA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status8Choice_? Status { get; init; } 
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_uW-mtVhpEeS8HfHHd4stCA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Reason14Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_uW-muVhpEeS8HfHHd4stCA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
