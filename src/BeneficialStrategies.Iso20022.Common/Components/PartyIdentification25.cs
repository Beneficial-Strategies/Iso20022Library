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
/// Identification of a person, or a non-financial institution.
/// </summary>
[IsoId("_Pb059Np-Ed-ak6NoX_4Aeg_-72138267")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification25
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification25 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification25( System.String reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_Pb059dp-Ed-ak6NoX_4Aeg_-72138265")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_Pb059tp-Ed-ak6NoX_4Aeg_-72138205")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryId")]
    #endif
    [IsoXmlTag("PrtryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification4? ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a non-financial institution.
    /// </summary>
    [IsoId("_Pb0599p-Ed-ak6NoX_4Aeg_-1406582918")]
    [DisplayName("BEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BEI")]
    #endif
    [IsoXmlTag("BEI")]
    [IsoSimpleType(IsoSimpleType.BEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBEIIdentifier? BEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BEI { get; init; } 
    #else
    public System.String? BEI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
