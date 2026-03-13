// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor configuration to be downloaded from the terminal management system.
/// </summary>
[IsoId("_LYek5H1DEeCF8NjrBemJWQ_-1760304679")]
[DisplayName("Acceptor Configuration")]
public partial record AcceptorConfiguration1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_LYek5X1DEeCF8NjrBemJWQ_-1107544142")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification35? POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_LYek5n1DEeCF8NjrBemJWQ_2018329979")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification35 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_LYek531DEeCF8NjrBemJWQ_-1096192441")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet3> DataSet { get; init; } = [];
    // ID for the above is _LYek531DEeCF8NjrBemJWQ_-1096192441
    
    
    #nullable disable
    
}
