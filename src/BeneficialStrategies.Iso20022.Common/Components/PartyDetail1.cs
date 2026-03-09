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
/// Specifies further details of the party.
/// </summary>
[IsoId("_SlObEPH6Eeaz_YGUGLjP6A")]
[DisplayName("Party Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyDetail1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyDetail1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyDetail1( System.String reqPartyType,SupervisingAuthorityIdentification1Choice_ reqSupervisingAuthority )
    {
        PartyType = reqPartyType;
        SupervisingAuthority = reqSupervisingAuthority;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Full name of the party.
    /// </summary>
    [IsoId("_00Q3QfH6Eeaz_YGUGLjP6A")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FullName { get; init; } 
    #else
    public System.String? FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the party as recorded in the registration in its legal jurisdiction.
    /// </summary>
    [IsoId("_XbkCcfH7Eeaz_YGUGLjP6A")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Code indicating the type of party as per local regulation.
    /// </summary>
    [IsoId("_tWbeYfKXEeaz_YGUGLjP6A")]
    [DisplayName("Party Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyTp")]
    #endif
    [IsoXmlTag("PtyTp")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10Text PartyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartyType { get; init; } 
    #else
    public System.String PartyType { get; set; } 
    #endif
    
    /// <summary>
    /// Information detail about the institution supervising the party under the local regulation.
    /// </summary>
    [IsoId("_gsrzEPH8Eeaz_YGUGLjP6A")]
    [DisplayName("Supervising Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SprvsgAuthrty")]
    #endif
    [IsoXmlTag("SprvsgAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SupervisingAuthorityIdentification1Choice_ SupervisingAuthority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SupervisingAuthorityIdentification1Choice_ SupervisingAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupervisingAuthorityIdentification1Choice_ SupervisingAuthority { get; init; } 
    #else
    public SupervisingAuthorityIdentification1Choice_ SupervisingAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Address used to communicate with the party as recorded in the registration in its legal jurisdiction.
    /// </summary>
    [IsoId("_My_DEogNEeeMp7TnNqgLag")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress6? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress6? PostalAddress { get; init; } 
    #else
    public PostalAddress6? PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communicating with the party.
    /// </summary>
    [IsoId("_hblHIfIBEeaz_YGUGLjP6A")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress7? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress7? Contact { get; init; } 
    #else
    public CommunicationAddress7? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Any other additional information about the party.
    /// </summary>
    [IsoId("_zxVFQfKXEeaz_YGUGLjP6A")]
    [DisplayName("Comment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmnt")]
    #endif
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? Comment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Comment { get; init; } 
    #else
    public System.String? Comment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
