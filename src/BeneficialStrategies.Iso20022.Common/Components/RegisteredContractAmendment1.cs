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
/// Amendment details and reason related to the registered contract.
/// </summary>
[IsoId("__zlVIdL3EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegisteredContractAmendment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegisteredContractAmendment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegisteredContractAmendment1( System.DateOnly reqAmendmentDate,DocumentIdentification28 reqDocument )
    {
        AmendmentDate = reqAmendmentDate;
        Document = reqDocument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the amendment of the registered contract.
    /// </summary>
    [IsoId("_OtXz4NL4EeSDLevdaFPXHw")]
    [DisplayName("Amendment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntDt")]
    #endif
    [IsoXmlTag("AmdmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate AmendmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly AmendmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly AmendmentDate { get; init; } 
    #else
    public System.DateOnly AmendmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the amendment document.
    /// </summary>
    [IsoId("_jCKiwNL4EeSDLevdaFPXHw")]
    [DisplayName("Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Doc")]
    #endif
    [IsoXmlTag("Doc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification28 Document { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification28 Document { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28 Document { get; init; } 
    #else
    public DocumentIdentification28 Document { get; set; } 
    #endif
    
    /// <summary>
    /// Date from which the amendment is applicable.
    /// </summary>
    [IsoId("_y1JvktOWEeSQ_-lmj1tzfw")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the amendment.
    /// </summary>
    [IsoId("_4nTUYtOWEeSQ_-lmj1tzfw")]
    [DisplayName("Amendment Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntRsn")]
    #endif
    [IsoXmlTag("AmdmntRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AmendmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendmentReason { get; init; } 
    #else
    public System.String? AmendmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the amendment.
    /// </summary>
    [IsoId("_CikDoNOXEeSQ_-lmj1tzfw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
