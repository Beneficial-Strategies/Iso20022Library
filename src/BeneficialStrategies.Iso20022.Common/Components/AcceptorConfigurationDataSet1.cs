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
[IsoId("_xqgssAueEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Configuration Data Set")]
public partial record AcceptorConfigurationDataSet1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_xqgssgueEeqw5uEXxQ9H4g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_xqgsswueEeqw5uEXxQ9H4g")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_xqgssQueEeqw5uEXxQ9H4g")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification176? POIIdentification { get; init; } 
    
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_xqgstAueEeqw5uEXxQ9H4g")]
    [DisplayName("Configuration Scope")]
    [IsoXmlTag("CfgtnScp")]
    public PartyType15Code? ConfigurationScope { get; init; } 
    
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_xqgstQueEeqw5uEXxQ9H4g")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required AcceptorConfigurationContent9 Content { get; init; } 
    
    
    #nullable disable
    
}
