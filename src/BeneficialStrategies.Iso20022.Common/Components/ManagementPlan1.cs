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
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
[IsoId("_LYnu1H1DEeCF8NjrBemJWQ_327413113")]
[DisplayName("Management Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManagementPlan1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ManagementPlan1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ManagementPlan1( GenericIdentification35 reqTerminalManagerIdentification )
    {
        TerminalManagerIdentification = reqTerminalManagerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_LYnu1X1DEeCF8NjrBemJWQ_-1510703256")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification35? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification35? POIIdentification { get; init; } 
    #else
    public GenericIdentification35? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_LYnu1n1DEeCF8NjrBemJWQ_2053974420")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification35 TerminalManagerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification35 TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification35 TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification35 TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_LYnu131DEeCF8NjrBemJWQ_-223303412")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    public ValueList<TerminalManagementDataSet2> DataSet { get; init; } = new ValueList<TerminalManagementDataSet2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _LYnu131DEeCF8NjrBemJWQ_-223303412
    
    
    #nullable disable
    
}
