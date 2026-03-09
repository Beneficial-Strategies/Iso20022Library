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
/// Provides the return indicators and the investigation result.
/// </summary>
[IsoId("_o8EakzzuEeGl7N0Cd54dlw")]
[DisplayName("Return Indicator")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnIndicator1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReturnIndicator1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReturnIndicator1( AuthorityRequestType1 reqAuthorityRequestType,InvestigationResult1Choice_ reqInvestigationResult )
    {
        AuthorityRequestType = reqAuthorityRequestType;
        InvestigationResult = reqInvestigationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the dates between which period the response results relate to.
    /// </summary>
    [IsoId("_c3ykVUMYEeGOTYFglkhSbA")]
    [DisplayName("Response Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnPrd")]
    #endif
    [IsoXmlTag("RspnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateOrDateTimePeriodChoice_? ResponsePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateOrDateTimePeriodChoice_? ResponsePeriod { get; init; } 
    #else
    public DateOrDateTimePeriodChoice_? ResponsePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the authority request type as a code.
    /// </summary>
    [IsoId("_rb9kgTzuEeGl7N0Cd54dlw")]
    [DisplayName("Authority Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyReqTp")]
    #endif
    [IsoXmlTag("AuthrtyReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorityRequestType1 AuthorityRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorityRequestType1 AuthorityRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorityRequestType1 AuthorityRequestType { get; init; } 
    #else
    public AuthorityRequestType1 AuthorityRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the investigation result.
    /// </summary>
    [IsoId("_uWrCITzuEeGl7N0Cd54dlw")]
    [DisplayName("Investigation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnRslt")]
    #endif
    [IsoXmlTag("InvstgtnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationResult1Choice_ InvestigationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigationResult1Choice_ InvestigationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationResult1Choice_ InvestigationResult { get; init; } 
    #else
    public InvestigationResult1Choice_ InvestigationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the investigation result.
    /// </summary>
    [IsoId("_10Z_ATzuEeGl7N0Cd54dlw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
