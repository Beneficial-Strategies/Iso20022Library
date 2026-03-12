// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Funds related service such as a payment or a transfer related to the transaction.
/// </summary>
[IsoId("_eC8lMYKxEeu4svNQ5N-l6w")]
[DisplayName("Funding Service")]
public partial record FundingService2
{
    #nullable enable
    
    /// <summary>
    /// Funding service details.
    /// </summary>
    [IsoId("_eH_dQYKxEeu4svNQ5N-l6w")]
    [DisplayName("Funding Service")]
    [IsoXmlTag("FndgSvc")]
    public TransferService2? FundingService { get; init; } 
    
    /// <summary>
    /// Source of funding.
    /// </summary>
    [IsoId("_eH_dQ4KxEeu4svNQ5N-l6w")]
    [DisplayName("Funding Source")]
    [IsoXmlTag("FndgSrc")]
    public FundingSource2? FundingSource { get; init; } 
    
    /// <summary>
    /// Information for claiming funds.
    /// </summary>
    [IsoId("_eH_dRYKxEeu4svNQ5N-l6w")]
    [DisplayName("Claim Information")]
    [IsoXmlTag("ClmInf")]
    public ClaimInformation1? ClaimInformation { get; init; } 
    
    
    #nullable disable
    
}
