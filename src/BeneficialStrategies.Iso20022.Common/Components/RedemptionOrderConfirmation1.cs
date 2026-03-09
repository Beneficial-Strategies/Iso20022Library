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
/// Order confirmation details.
/// </summary>
[IsoId("_ROtz5Np-Ed-ak6NoX_4Aeg_-2102884970")]
[DisplayName("Redemption Order Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionOrderConfirmation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionOrderConfirmation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionOrderConfirmation1( System.String reqAmendmentIndicator,RedemptionMultipleExecution3 reqMultipleExecutionDetails )
    {
        AmendmentIndicator = reqAmendmentIndicator;
        MultipleExecutionDetails = reqMultipleExecutionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_ROtz5dp-Ed-ak6NoX_4Aeg_-1358793124")]
    [DisplayName("Amendment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInd")]
    #endif
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AmendmentIndicator { get; init; } 
    #else
    public System.String AmendmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_ROtz5tp-Ed-ak6NoX_4Aeg_-2099192655")]
    [DisplayName("Multiple Execution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplExctnDtls")]
    #endif
    [IsoXmlTag("MltplExctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; } 
    #else
    public RedemptionMultipleExecution3 MultipleExecutionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_ROtz59p-Ed-ak6NoX_4Aeg_-2101037341")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = new ValueList<Intermediary9>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ROtz6Np-Ed-ak6NoX_4Aeg_-2100114299")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}
