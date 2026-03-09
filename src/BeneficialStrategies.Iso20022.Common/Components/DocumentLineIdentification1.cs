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
/// Identifies the documents referred to in the remittance information.
/// </summary>
[IsoId("_1QJJIabjEeKvUvwX_r3tzA")]
[DisplayName("Document Line Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentLineIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of referred document line identification.
    /// </summary>
    [IsoId("_1Z0plabjEeKvUvwX_r3tzA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentLineType1? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentLineType1? Type { get; init; } 
    #else
    public DocumentLineType1? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the type specified for the referred document line.
    /// </summary>
    [IsoId("_1Z0pmabjEeKvUvwX_r3tzA")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Number { get; init; } 
    #else
    public System.String? Number { get; set; } 
    #endif
    
    /// <summary>
    /// Date associated with the referred document line.
    /// </summary>
    [IsoId("_1Z0pnabjEeKvUvwX_r3tzA")]
    [DisplayName("Related Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDt")]
    #endif
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RelatedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RelatedDate { get; init; } 
    #else
    public System.DateOnly? RelatedDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
