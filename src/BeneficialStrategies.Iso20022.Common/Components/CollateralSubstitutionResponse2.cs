// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the rejected collateral substitution.
/// </summary>
[IsoId("_QnYHFNp-Ed-ak6NoX_4Aeg_-1313655286")]
[DisplayName("Collateral Substitution Response")]
public partial record CollateralSubstitutionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_QnYHFdp-Ed-ak6NoX_4Aeg_1984239657")]
    [DisplayName("Collateral Substitution Request Identification")]
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the collateral substitution amount that is rejected.
    /// </summary>
    [IsoId("_QnYHFtp-Ed-ak6NoX_4Aeg_873328238")]
    [DisplayName("Rejected Amount")]
    [IsoXmlTag("RjctdAmt")]
    public required ActiveCurrencyAndAmount RejectedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the reasons why the collateral substitution is rejected.
    /// </summary>
    [IsoId("_QnYHF9p-Ed-ak6NoX_4Aeg_-776739063")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required RejectionReasonV021Code RejectionReason { get; init; } 
    
    /// <summary>
    /// Provides additional information about the collateral substitution request rejection.
    /// </summary>
    [IsoId("_QnYHGNp-Ed-ak6NoX_4Aeg_1784143773")]
    [DisplayName("Rejection Reason Information")]
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? RejectionReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
