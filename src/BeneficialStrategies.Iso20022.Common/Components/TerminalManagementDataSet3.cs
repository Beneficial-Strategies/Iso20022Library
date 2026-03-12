// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
[IsoId("_K9f5En1DEeCF8NjrBemJWQ_137212968")]
[DisplayName("Terminal Management Data Set")]
public partial record TerminalManagementDataSet3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_K9f5E31DEeCF8NjrBemJWQ_2022622085")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification2 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_K9f5FH1DEeCF8NjrBemJWQ_-75183062")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_K9f5FX1DEeCF8NjrBemJWQ_843277362")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent1 Content { get; init; } 
    
    
    #nullable disable
    
}
