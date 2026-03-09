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
/// Provides reasons of rejecting transactions.
/// </summary>
[IsoId("_oYN5QU2UEe2bQ-Ksk8mwQg")]
[DisplayName("Rejection Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionReason70
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionReason70 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionReason70( System.String reqMessageReportIdentification,ReportingMessageStatus2Code reqStatus )
    {
        MessageReportIdentification = reqMessageReportIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_oZjWAU2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Message Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRptId")]
    #endif
    [IsoXmlTag("MsgRptId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text MessageReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageReportIdentification { get; init; } 
    #else
    public System.String MessageReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_oZjWA02UEe2bQ-Ksk8mwQg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingMessageStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingMessageStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingMessageStatus2Code Status { get; init; } 
    #else
    public ReportingMessageStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_oZjWBU2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Detailed Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldVldtnRule")]
    #endif
    [IsoXmlTag("DtldVldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
