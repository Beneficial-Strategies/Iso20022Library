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
/// Specifies the requested authority investigation information details.
/// </summary>
[IsoId("_zIYkA01JEeGAs6v-iSb2RQ")]
[DisplayName("Authority Investigation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorityInvestigation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorityInvestigation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorityInvestigation2( AuthorityRequestType1 reqType,InvestigatedParties1Choice_ reqInvestigatedRoles )
    {
        Type = reqType;
        InvestigatedRoles = reqInvestigatedRoles;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type requested information as a code.
    /// </summary>
    [IsoId("_1ur36E1JEeGAs6v-iSb2RQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorityRequestType1 Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorityRequestType1 Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorityRequestType1 Type { get; init; } 
    #else
    public AuthorityRequestType1 Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the roles the customer plays in the requested information.
    /// </summary>
    [IsoId("_sGeWoU1AEeGAs6v-iSb2RQ")]
    [DisplayName("Investigated Roles")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtdRoles")]
    #endif
    [IsoXmlTag("InvstgtdRoles")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigatedParties1Choice_ InvestigatedRoles { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigatedParties1Choice_ InvestigatedRoles { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigatedParties1Choice_ InvestigatedRoles { get; init; } 
    #else
    public InvestigatedParties1Choice_ InvestigatedRoles { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the additional investigated parties.
    /// </summary>
    [IsoId("_80akgU1JEeGAs6v-iSb2RQ")]
    [DisplayName("Additional Investigated Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInvstgtdPties")]
    #endif
    [IsoXmlTag("AddtlInvstgtdPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestigatedParties1Choice_? AdditionalInvestigatedParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigatedParties1Choice_? AdditionalInvestigatedParties { get; init; } 
    #else
    public InvestigatedParties1Choice_? AdditionalInvestigatedParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the requested information.
    /// </summary>
    [IsoId("_6sOI8U1JEeGAs6v-iSb2RQ")]
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
