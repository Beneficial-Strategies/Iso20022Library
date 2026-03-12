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
[IsoId("_7Vxv0StXEeyhipY4f42fZQ")]
[DisplayName("Additional Query Parameters")]
public partial record AdditionalQueryParameters13
{
    #nullable enable
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_70ByEStXEeyhipY4f42fZQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status19Choice_? Status { get; init; } 
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_70ByFStXEeyhipY4f42fZQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Reason19Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_70ByGStXEeyhipY4f42fZQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
