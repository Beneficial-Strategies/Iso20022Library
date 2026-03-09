// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the type of election advice and linked messages.
/// </summary>
[IsoId("_Rjkpmtp-Ed-ak6NoX_4Aeg_1579470167")]
[DisplayName("Election Advice Function")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ElectionAdviceFunction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ElectionAdviceFunction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ElectionAdviceFunction1( ElectionType1Code reqElectionType )
    {
        ElectionType = reqElectionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of election advice.
    /// </summary>
    [IsoId("_RjuakNp-Ed-ak6NoX_4Aeg_1867607801")]
    [DisplayName("Election Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnTp")]
    #endif
    [IsoXmlTag("ElctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ElectionType1Code ElectionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ElectionType1Code ElectionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionType1Code ElectionType { get; init; } 
    #else
    public ElectionType1Code ElectionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the previous Agent Corporate Action Election Advice that is being amended.
    /// </summary>
    [IsoId("_Rjuakdp-Ed-ak6NoX_4Aeg_1835225142")]
    [DisplayName("Previous Agent CA Election Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsAgtCAElctnAdvcId")]
    #endif
    [IsoXmlTag("PrvsAgtCAElctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? PreviousAgentCAElectionAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? PreviousAgentCAElectionAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8? PreviousAgentCAElectionAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Agent Corporate Action Election Status Advice by which the issuer (agent) accepts the election amendment request.
    /// </summary>
    [IsoId("_Rjuaktp-Ed-ak6NoX_4Aeg_-1260629991")]
    [DisplayName("Agent CA Election Status Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnStsAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnStsAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? AgentCAElectionStatusAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? AgentCAElectionStatusAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8? AgentCAElectionStatusAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Agent Corporate Action Election Amendment Request by which the CSD request the authorisation to amend an election.
    /// </summary>
    [IsoId("_Rjuak9p-Ed-ak6NoX_4Aeg_-1390844724")]
    [DisplayName("Agent CA Election Amendment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAmdmntReqId")]
    #endif
    [IsoXmlTag("AgtCAElctnAmdmntReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? AgentCAElectionAmendmentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? AgentCAElectionAmendmentRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8? AgentCAElectionAmendmentRequestIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
