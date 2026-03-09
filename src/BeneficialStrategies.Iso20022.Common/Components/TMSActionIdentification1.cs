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
/// Result of an individual terminal management action by the point of interaction.
/// </summary>
[IsoId("_KsN72X1DEeCF8NjrBemJWQ_-230191666")]
[DisplayName("TMS Action Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSActionIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSActionIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSActionIdentification1( TerminalManagementAction1Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Types of terminal management action performed by a point of interaction.
    /// </summary>
    [IsoId("_KsXs0H1DEeCF8NjrBemJWQ_-626855899")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction1Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction1Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction1Code ActionType { get; init; } 
    #else
    public TerminalManagementAction1Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Data set on which the action has been performed.
    /// </summary>
    [IsoId("_KsXs0X1DEeCF8NjrBemJWQ_-1959099550")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetIdentification2? DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification2? DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification2? DataSetIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
