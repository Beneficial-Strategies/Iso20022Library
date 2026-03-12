// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the intra-balance movement status type.
/// </summary>
[IsoId("_WygsIeFUEeWIA4E9cYSxxQ")]
[DisplayName("Intra Balance Status And Reason")]
public partial record IntraBalanceStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_W7IckeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; } 
    
    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_W7Ick-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus16Choice_? SettlementStatus { get; init; } 
    
    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_W7IcleFUEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; } 
    
    
    #nullable disable
    
}
