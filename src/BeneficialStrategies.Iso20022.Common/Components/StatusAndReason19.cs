// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of a transaction.
/// </summary>
[IsoId("_Spx8USwdEeOEV5XHD-BKpw")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason19
{
    #nullable enable
    
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_TC61EywdEeOEV5XHD-BKpw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus23Choice_? ProcessingStatus { get; init; } 
    
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    [IsoId("_TC61GywdEeOEV5XHD-BKpw")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus19Choice_? InferredMatchingStatus { get; init; } 
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_TC61IywdEeOEV5XHD-BKpw")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus19Choice_? MatchingStatus { get; init; } 
    
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_TC61KywdEeOEV5XHD-BKpw")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus7Choice_? SettlementStatus { get; init; } 
    
    
    #nullable disable
    
}
