// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the failure of the settlement of a movement.
/// </summary>
[IsoId("_Rjbfptp-Ed-ak6NoX_4Aeg_-659137401")]
[DisplayName("Corporate Action Movement Failed Status")]
public partial record CorporateActionMovementFailedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the agent account.
    /// </summary>
    [IsoId("_Rjbfp9p-Ed-ak6NoX_4Aeg_-123497061")]
    [DisplayName("Agent Account Identification")]
    [IsoXmlTag("AgtAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AgentAccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the client account.
    /// </summary>
    [IsoId("_RjbfqNp-Ed-ak6NoX_4Aeg_-158591004")]
    [DisplayName("Client Account Identification")]
    [IsoXmlTag("ClntAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientAccountIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the client account.
    /// </summary>
    [IsoId("_Rjbfqdp-Ed-ak6NoX_4Aeg_-232960947")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Provides information about the resource movement that failed and the reason of the failure.
    /// </summary>
    [IsoId("_Rjbfqtp-Ed-ak6NoX_4Aeg_-1713973917")]
    [DisplayName("Resource Details")]
    [IsoXmlTag("RsrcDtls")]
    public ValueList<FailedMovement1> ResourceDetails { get; init; } = new ValueList<FailedMovement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rjbfqtp-Ed-ak6NoX_4Aeg_-1713973917
    
    
    #nullable disable
    
}
