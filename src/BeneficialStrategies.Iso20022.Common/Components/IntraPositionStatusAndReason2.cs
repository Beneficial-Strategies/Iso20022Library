// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the movement status types.
/// </summary>
[IsoId("_XD6lSeFUEeWIA4E9cYSxxQ")]
[DisplayName("Intra Position Status And Reason")]
public partial record IntraPositionStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_XM13oeFUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; } 
    
    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_XM13o-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus16Choice_? SettlementStatus { get; init; } 
    
    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_XM13peFUEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; } 
    
    
    #nullable disable
    
}
