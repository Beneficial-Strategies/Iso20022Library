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
/// Defines and associates identifications for a party as a list of other global or qualified relative identifiers.
/// It is assumed that customers of a party can be referenced by an identifier local to the party. The party together with the local identifier can be used to reference the customer.
/// Multiple references can be given to identify the same party.
/// A short identification can be used for display purposes.
/// </summary>
[IsoId("_OTgzMjEy-AOSNFX-8224491")]
[DisplayName("Qualified Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QualifiedPartyIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QualifiedPartyIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QualifiedPartyIdentification1( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Schema ID to be used in IDREF values.
    /// </summary>
    [IsoId("_OTgzMjU0-AOSNFX-8224494")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoID Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// List of identifications for the same party.
    /// </summary>
    [IsoId("_OTgzMjU1-AOSNFX-8224494")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    public ValueList<SingleQualifiedPartyIdentification1> Party { get; init; } = new ValueList<SingleQualifiedPartyIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _OTgzMjU1-AOSNFX-8224494
    
    /// <summary>
    /// Short identification of the resulting party as a control mechanism for humans.
    /// </summary>
    [IsoId("_OTgzMjU2-AOSNFX-8224494")]
    [DisplayName("Short Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtId")]
    #endif
    [IsoXmlTag("ShrtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? ShortIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? ShortIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? ShortIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Formally defined role qualifying the party.
    /// </summary>
    [IsoId("_OTgzMjU3-AOSNFX-8224494")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? Role { get; init; } 
    #else
    public GenericIdentification1? Role { get; set; } 
    #endif
    
    /// <summary>
    /// Free form description of the party&apos;s role.
    /// </summary>
    [IsoId("_OTgzMjU4-AOSNFX-8224494")]
    [DisplayName("Role Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RoleDesc")]
    #endif
    [IsoXmlTag("RoleDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? RoleDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RoleDescription { get; init; } 
    #else
    public System.String? RoleDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
