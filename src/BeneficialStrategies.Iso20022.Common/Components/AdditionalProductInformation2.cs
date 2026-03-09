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
/// Additional information required for distribution in the French market.
/// </summary>
[IsoId("_J8Y8UM3AEeuAE-cYsQdwHQ")]
[DisplayName("Additional Product Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalProductInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 01020.
    /// </summary>
    [IsoId("_eNL8AM3AEeuAE-cYsQdwHQ")]
    [DisplayName("AMF Doctrine")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AMFDctrn")]
    #endif
    [IsoXmlTag("AMFDctrn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AMFDoctrine1Code? AMFDoctrine { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AMFDoctrine1Code? AMFDoctrine { get; init; } 
    #else
    public AMFDoctrine1Code? AMFDoctrine { get; set; } 
    #endif
    
    
    #nullable disable
    
}
