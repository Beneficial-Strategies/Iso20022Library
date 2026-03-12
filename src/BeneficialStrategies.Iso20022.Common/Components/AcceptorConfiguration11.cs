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
[IsoId("_UflwYVEJEeyApZmLzm74zA")]
[DisplayName("Acceptor Configuration")]
public partial record AcceptorConfiguration11
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_UmMusVEJEeyApZmLzm74zA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_UmMus1EJEeyApZmLzm74zA")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_UmMutVEJEeyApZmLzm74zA")]
    [DisplayName("Data Set")]
    [IsoXmlTag("DataSet")]
    public ValueList<AcceptorConfigurationDataSet3> DataSet { get; init; } = new ValueList<AcceptorConfigurationDataSet3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UmMutVEJEeyApZmLzm74zA
    
    
    #nullable disable
    
}
