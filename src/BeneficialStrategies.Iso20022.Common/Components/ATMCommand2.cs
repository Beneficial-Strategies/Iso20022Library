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
/// Result of a maintenance command performed by the ATM.
/// </summary>
[IsoId("_srliUYryEeSvuOJS0mmL0g")]
[DisplayName("ATM Command")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommand2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMCommand2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMCommand2( ATMCommand2Code reqType,System.DateTime reqProcessedDateTime,TerminalManagementActionResult2Code reqResult )
    {
        Type = reqType;
        ProcessedDateTime = reqProcessedDateTime;
        Result = reqResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    [IsoId("_s5gpkYryEeSvuOJS0mmL0g")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMCommand2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMCommand2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand2Code Type { get; init; } 
    #else
    public ATMCommand2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    [IsoId("_s5gplYryEeSvuOJS0mmL0g")]
    [DisplayName("Required Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdDtTm")]
    #endif
    [IsoXmlTag("ReqrdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RequiredDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RequiredDateTime { get; init; } 
    #else
    public System.DateTime? RequiredDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    [IsoId("_YjsNsIr3EeSvuOJS0mmL0g")]
    [DisplayName("Processed Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcdDtTm")]
    #endif
    [IsoXmlTag("PrcdDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ProcessedDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ProcessedDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ProcessedDateTime { get; init; } 
    #else
    public System.DateTime ProcessedDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_s5gpl4ryEeSvuOJS0mmL0g")]
    [DisplayName("Command Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdId")]
    #endif
    [IsoXmlTag("CmdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #else
    public ATMCommandIdentification1? CommandIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    [IsoId("_4feN0Ir3EeSvuOJS0mmL0g")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementActionResult2Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementActionResult2Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementActionResult2Code Result { get; init; } 
    #else
    public TerminalManagementActionResult2Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    [IsoId("_-cdJoIr3EeSvuOJS0mmL0g")]
    [DisplayName("Additional Error Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlErrInf")]
    #endif
    [IsoXmlTag("AddtlErrInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalErrorInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalErrorInformation { get; init; } 
    #else
    public System.String? AdditionalErrorInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
