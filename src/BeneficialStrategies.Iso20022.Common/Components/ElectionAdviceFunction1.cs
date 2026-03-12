// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the type of election advice and linked messages.
/// </summary>
[IsoId("_Rjkpmtp-Ed-ak6NoX_4Aeg_1579470167")]
[DisplayName("Election Advice Function")]
public partial record ElectionAdviceFunction1
{
    #nullable enable
    
    /// <summary>
    /// Type of election advice.
    /// </summary>
    [IsoId("_RjuakNp-Ed-ak6NoX_4Aeg_1867607801")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public required ElectionType1Code ElectionType { get; init; } 
    
    /// <summary>
    /// Identification of the previous Agent Corporate Action Election Advice that is being amended.
    /// </summary>
    [IsoId("_Rjuakdp-Ed-ak6NoX_4Aeg_1835225142")]
    [DisplayName("Previous Agent CA Election Advice Identification")]
    [IsoXmlTag("PrvsAgtCAElctnAdvcId")]
    public DocumentIdentification8? PreviousAgentCAElectionAdviceIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the Agent Corporate Action Election Status Advice by which the issuer (agent) accepts the election amendment request.
    /// </summary>
    [IsoId("_Rjuaktp-Ed-ak6NoX_4Aeg_-1260629991")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    public DocumentIdentification8? AgentCAElectionStatusAdviceIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the Agent Corporate Action Election Amendment Request by which the CSD request the authorisation to amend an election.
    /// </summary>
    [IsoId("_Rjuak9p-Ed-ak6NoX_4Aeg_-1390844724")]
    [DisplayName("Agent CA Election Amendment Request Identification")]
    [IsoXmlTag("AgtCAElctnAmdmntReqId")]
    public DocumentIdentification8? AgentCAElectionAmendmentRequestIdentification { get; init; } 
    
    
    #nullable disable
    
}
