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
/// Information related to the identification of an individual person.
/// </summary>
[IsoId("_QAVVMtp-Ed-ak6NoX_4Aeg_-1527540623")]
[DisplayName("Generic Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GenericIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GenericIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GenericIdentification10( System.String reqIdentification,PersonIdentificationType1Code reqIdentificationType,System.String reqExtendedIdentificationType )
    {
        Identification = reqIdentification;
        IdentificationType = reqIdentificationType;
        ExtendedIdentificationType = reqExtendedIdentificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_QAVVM9p-Ed-ak6NoX_4Aeg_-1520154884")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_QAVVNNp-Ed-ak6NoX_4Aeg_-1520154824")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PersonIdentificationType1Code IdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PersonIdentificationType1Code IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentificationType1Code IdentificationType { get; init; } 
    #else
    public PersonIdentificationType1Code IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature of the identification.
    /// </summary>
    [IsoId("_QAVVNdp-Ed-ak6NoX_4Aeg_-1520154729")]
    [DisplayName("Extended Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedIdTp")]
    #endif
    [IsoXmlTag("XtndedIdTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedIdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedIdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedIdentificationType { get; init; } 
    #else
    public System.String ExtendedIdentificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
