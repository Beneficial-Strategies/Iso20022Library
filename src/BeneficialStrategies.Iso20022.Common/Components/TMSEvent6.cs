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
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
[IsoId("_4rGo4dqMEeearpaEPXv9UA")]
[DisplayName("TMS Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TMSEvent6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TMSEvent6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TMSEvent6( System.DateTime reqTimeStamp,TerminalManagementActionResult4Code reqResult,TMSActionIdentification5 reqActionIdentification )
    {
        TimeStamp = reqTimeStamp;
        Result = reqResult;
        ActionIdentification = reqActionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_40a88dqMEeearpaEPXv9UA")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    [IsoId("_40a889qMEeearpaEPXv9UA")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementActionResult4Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementActionResult4Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementActionResult4Code Result { get; init; } 
    #else
    public TerminalManagementActionResult4Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    [IsoId("_40a89dqMEeearpaEPXv9UA")]
    [DisplayName("Action Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnId")]
    #endif
    [IsoXmlTag("ActnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSActionIdentification5 ActionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSActionIdentification5 ActionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSActionIdentification5 ActionIdentification { get; init; } 
    #else
    public TMSActionIdentification5 ActionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    [IsoId("_40a899qMEeearpaEPXv9UA")]
    [DisplayName("Additional Error Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlErrInf")]
    #endif
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalErrorInformation { get; init; } 
    #else
    public System.String? AdditionalErrorInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) used with the action.
    /// </summary>
    [IsoId("_bvgFANwoEeeKpa-yxjuKzQ")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TerminalManagerIdentification { get; init; } 
    #else
    public System.String? TerminalManagerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
