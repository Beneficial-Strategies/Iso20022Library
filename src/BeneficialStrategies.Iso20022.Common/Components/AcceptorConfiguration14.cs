// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Configuration14.
/// </summary>
[IsoId("_TYF3waEvEe-MRKYsaX6JDg")]
[DisplayName("Acceptor Configuration14")]
public partial record AcceptorConfiguration14
{
    #nullable enable

    /// <summary>
    /// Data Set.
    /// </summary>
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<AcceptorConfigurationDataSet6> DataSet { get; init; } = [];

    /// <summary>
    /// POI Group Identification.
    /// </summary>
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    public ValueList<IsoMax35Text> POIGroupIdentification { get; init; } = [];

    /// <summary>
    /// Terminal Manager Identification.
    /// </summary>
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 

    
    #nullable disable
    
}
