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
[IsoId("_c-QgEQueEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Configuration")]
public partial record AcceptorConfiguration9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_dJccYQueEeqw5uEXxQ9H4g")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_dJccYwueEeqw5uEXxQ9H4g")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<AcceptorConfigurationDataSet1> DataSet { get; init; } = [];
    // ID for the above is _dJccYwueEeqw5uEXxQ9H4g
    
    
    #nullable disable
    
}
