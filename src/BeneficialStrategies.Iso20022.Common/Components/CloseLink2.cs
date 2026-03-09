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
/// Provides details of the close links as defined in the collateral reference data.
/// </summary>
[IsoId("_WBMWAeLXEeWFtOV72FbX9w")]
[DisplayName("Close Link")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CloseLink2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CloseLink2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CloseLink2( System.String reqSecurityIdentification,SystemPartyIdentification1Choice_ reqPartyIdentification )
    {
        SecurityIdentification = reqSecurityIdentification;
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_WMpYEeLXEeWFtOV72FbX9w")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecurityIdentification { get; init; } 
    #else
    public System.String SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party for which the close link is defined.
    /// </summary>
    [IsoId("_WMpYE-LXEeWFtOV72FbX9w")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification1Choice_ PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification1Choice_ PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification1Choice_ PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification1Choice_ PartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
