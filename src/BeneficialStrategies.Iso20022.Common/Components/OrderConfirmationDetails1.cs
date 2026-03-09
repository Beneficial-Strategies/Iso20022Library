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
[IsoId("_RPAu1Np-Ed-ak6NoX_4Aeg_2133695541")]
[DisplayName("Order Confirmation Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrderConfirmationDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrderConfirmationDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrderConfirmationDetails1( System.String reqAmendmentIndicator,RedemptionBulkExecution3 reqBulkExecutionDetails )
    {
        AmendmentIndicator = reqAmendmentIndicator;
        BulkExecutionDetails = reqBulkExecutionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_RPAu1dp-Ed-ak6NoX_4Aeg_-1991936657")]
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
    [IsoId("_RPAu1tp-Ed-ak6NoX_4Aeg_2134621993")]
    [DisplayName("Bulk Execution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkExctnDtls")]
    #endif
    [IsoXmlTag("BlkExctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #else
    public RedemptionBulkExecution3 BulkExecutionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RPAu19p-Ed-ak6NoX_4Aeg_2134619167")]
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
    [IsoId("_RPAu2Np-Ed-ak6NoX_4Aeg_2134620848")]
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
