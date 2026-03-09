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
/// Provides details on the request.
/// </summary>
[IsoId("_RZlnI9p-Ed-ak6NoX_4Aeg_-946650708")]
[DisplayName("Receipt Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiptDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceiptDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceiptDetails1( AdditionalReferences reqRelatedReference )
    {
        RelatedReference = reqRelatedReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_RZlnJNp-Ed-ak6NoX_4Aeg_1612827078")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReferences RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReferences RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReferences RelatedReference { get; init; } 
    #else
    public AdditionalReferences RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_RZlnJdp-Ed-ak6NoX_4Aeg_1612826800")]
    [DisplayName("Request Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdlg")]
    #endif
    [IsoXmlTag("ReqHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestHandling? RequestHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestHandling? RequestHandling { get; init; } 
    #else
    public RequestHandling? RequestHandling { get; set; } 
    #endif
    
    
    #nullable disable
    
}
