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
/// Additional information.
/// </summary>
[IsoId("_ho71Md1BEeqW_oCeEFhoHw")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalInformation25 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalInformation25( System.String reqQuery )
    {
        Query = reqQuery;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of query.
    /// </summary>
    [IsoId("_h9nrwd1BEeqW_oCeEFhoHw")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification36? QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36? QueryType { get; init; } 
    #else
    public GenericIdentification36? QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the query.
    /// </summary>
    [IsoId("_h9nrw91BEeqW_oCeEFhoHw")]
    [DisplayName("Query")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qry")]
    #endif
    [IsoXmlTag("Qry")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Query { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Query { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Query { get; init; } 
    #else
    public System.String Query { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the query.
    /// </summary>
    [IsoId("_t-VEkN1BEeqW_oCeEFhoHw")]
    [DisplayName("Query Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRsn")]
    #endif
    [IsoXmlTag("QryRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? QueryReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryReason { get; init; } 
    #else
    public System.String? QueryReason { get; set; } 
    #endif
    
    /// <summary>
    /// Reason the instruction was rejected.
    /// </summary>
    [IsoId("_x1W5IN1EEeqW_oCeEFhoHw")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RejectedReason33Choice_? RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedReason33Choice_? RejectionReason { get; init; } 
    #else
    public RejectedReason33Choice_? RejectionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
