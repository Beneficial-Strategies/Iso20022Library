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
/// Acceptor configuration to be downloaded from the terminal management system.
/// </summary>
[IsoId("_PLZ6oXJ3Ee299ZbWCkdR_w")]
[DisplayName("Acceptor Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfiguration12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorConfiguration12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorConfiguration12( GenericIdentification176 reqTerminalManagerIdentification )
    {
        TerminalManagerIdentification = reqTerminalManagerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the acceptor parameters.
    /// </summary>
    [IsoId("_PRyPcXJ3Ee299ZbWCkdR_w")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification176 TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_PRyPc3J3Ee299ZbWCkdR_w")]
    [DisplayName("POI Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIGrpId")]
    #endif
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIGroupIdentification { get; init; } 
    #else
    public System.String? POIGroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data set containing the acceptor parameters of a point of interaction (POI).
    /// </summary>
    [IsoId("_PRyPdXJ3Ee299ZbWCkdR_w")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    public ValueList<AcceptorConfigurationDataSet4> DataSet { get; init; } = new ValueList<AcceptorConfigurationDataSet4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _PRyPdXJ3Ee299ZbWCkdR_w
    
    
    #nullable disable
    
}
