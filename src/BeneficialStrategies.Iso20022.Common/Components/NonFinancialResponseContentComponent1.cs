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
/// Aim of the non financial response.
/// </summary>
[IsoId("_KKDwkC_uEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Response Content Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialResponseContentComponent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonFinancialResponseContentComponent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonFinancialResponseContentComponent1( NonFinancialRequestType1Code reqNonFinancialRequestType,ResponseType11 reqResponse )
    {
        NonFinancialRequestType = reqNonFinancialRequestType;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    [IsoId("_aO9-oS_uEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinReqTp")]
    #endif
    [IsoXmlTag("NonFinReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonFinancialRequestType1Code NonFinancialRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonFinancialRequestType1Code NonFinancialRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialRequestType1Code NonFinancialRequestType { get; init; } 
    #else
    public NonFinancialRequestType1Code NonFinancialRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    [IsoId("_pJh5cC_uEeugIJ3Gvoevmg")]
    [DisplayName("Acquirer Selected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrSelctd")]
    #endif
    [IsoXmlTag("AcqrrSelctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer10? AcquirerSelected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer10? AcquirerSelected { get; init; } 
    #else
    public Acquirer10? AcquirerSelected { get; set; } 
    #endif
    
    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk. 
    /// </summary>
    [IsoId("_LaIxAC_xEeugIJ3Gvoevmg")]
    [DisplayName("Risk Management Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskMgmtRslt")]
    #endif
    [IsoXmlTag("RskMgmtRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; } 
    #else
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; set; } 
    #endif
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_Se83kS_xEeugIJ3Gvoevmg")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action11? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action11? Action { get; init; } 
    #else
    public Action11? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_YlVnAS_xEeugIJ3Gvoevmg")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType11 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType11 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType11 Response { get; init; } 
    #else
    public ResponseType11 Response { get; set; } 
    #endif
    
    
    #nullable disable
    
}
